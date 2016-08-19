namespace OnionArchitecture.Infrastructure.Data.Repositories
{
    public class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
