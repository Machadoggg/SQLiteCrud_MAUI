using SQLite;

namespace SQLiteCrud_MAUI
{
    public class LocalDbService
    {
        private const string DB_NAME = "sqlitecrud_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Customer>();
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _connection.Table<Customer>().ToListAsync();
        }
    }
}
