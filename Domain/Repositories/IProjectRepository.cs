using Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IProjectRepository
    {
        IEnumerable<Project> GetAll();
        Project GetById(int ProjectId);
        void Insert(Project project);
        void Update(Project project);
        void Delete(int ProjectId);
        void Save();
    }
}
