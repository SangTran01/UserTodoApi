using System.Text.Json;
using UserTodoApi.Models;

namespace UserTodoApi.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetUsers();
    }

    public class UserService : IUserService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                var users = await JsonSerializer.DeserializeAsync
                    <IEnumerable<User>>(contentStream);

                if (users != null) return users;
            }
            return null;
        }
    }
}
