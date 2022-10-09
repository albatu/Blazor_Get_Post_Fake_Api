using Business.Entities;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class TodoManager : ITodoService
    {
        private HttpClient _httpClient;

        public TodoManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PostTodo> Add(PostTodo entity)
        {
            var post = await _httpClient.PostAsJsonAsync("https://jsonplaceholder.typicode.com/posts", entity);
            return await post.Content.ReadFromJsonAsync<PostTodo>();
        }

        public async Task<List<PostTodo>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<PostTodo>>("https://jsonplaceholder.typicode.com/todos");
        }

        public async Task<List<PostTodo>> GetById(int id)
        {
            var getById = await _httpClient.GetFromJsonAsync<PostTodo>("https://jsonplaceholder.typicode.com/todos/"+id);

            return new List<PostTodo>() { getById };
        }
    }
}
