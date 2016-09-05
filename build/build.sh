#!/usr/bin/env bash

#exit if any command fails
set -e

artifactsFolder="./artifacts"

if [ -d $artifactsFolder ]; then  
  rm -R $artifactsFolder
fi

dotnet restore

# Instead, run directly with mono for the full .net version 
dotnet build ./src/OnionArchitecture.Core.Domain -c Release -f netcoreapp

revision=${TRAVIS_JOB_ID:=1}  
revision=$(printf "%04d" $revision) 

dotnet pack ./src/OnionArchitecture.Core.Domain -c Release -o ./artifacts --version-suffix=$revision  