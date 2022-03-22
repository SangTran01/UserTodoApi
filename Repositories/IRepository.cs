using UserTodoApi.Models;
using UserTodoApi.Services;

namespace UserTodoApi.Repositories
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();
    }

    public class UserRepository : IRepository<User>
    {
        private readonly IUserService _userService;

        public UserRepository(IUserService userService) { 
            _userService = userService;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userService.GetUsers();
        }
    }
}
