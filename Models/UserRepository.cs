using SQLite;

namespace Shell_App.Models.ViewModels
{
    public class UserRepository
    {
        private const string DB_NAME = "users.db3";
        private readonly SQLiteAsyncConnection _connection;
        public UserRepository() 
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<User>();
        }
        public async Task<List<User>> GetAllUsers()
        {
            return await _connection.Table<User>().ToListAsync();
        }
        public async Task<User> GetById(int id)
        {
            return await _connection.Table<User>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task Create(User user)
        {
            await _connection.InsertAsync(user);
        }
        public async Task Update(User user)
        {
            await _connection.UpdateAsync(user);
        }
        public async Task Delete(User user)
        {
            await _connection.DeleteAsync(user);
        }
    }
}
