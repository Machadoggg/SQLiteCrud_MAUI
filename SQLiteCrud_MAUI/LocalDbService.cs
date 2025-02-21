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
            var customer = await _connection.Table<Customer>().ToListAsync();
            return customer.OrderByDescending(c => c.Id).ToList();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _connection.Table<Customer>().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Customer customer)
        {
            await _connection.InsertAsync(customer);
        }

        public async Task Update(Customer customer)
        {
            await _connection.UpdateAsync(customer);
        }

        public async Task Delete(Customer customer)
        {
            await _connection.DeleteAsync(customer);
        }
    }
}
