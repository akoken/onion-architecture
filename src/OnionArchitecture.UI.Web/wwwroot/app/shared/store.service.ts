import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class StoreService {
    
    constructor(private http: Http) { }

    getCategories() {
        return this.http.get('api/store')
            .map(response => <Object[]>response.json());
    }
}