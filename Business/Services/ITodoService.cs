using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ITodoService
    {
        Task<List<PostTodo>> GetAll();
        Task<PostTodo> Add(PostTodo entity);
        Task<List<PostTodo>> GetById(int id);
    }
}
