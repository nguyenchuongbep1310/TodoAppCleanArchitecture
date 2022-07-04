using Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface ITodoTaskRepository
    {
        IEnumerable<TodoTask> GetAll();
        void Insert(TodoTask task);
        void Update(TodoTask task);
        void Delete(int TaskId);
        void Save();
    }
}
