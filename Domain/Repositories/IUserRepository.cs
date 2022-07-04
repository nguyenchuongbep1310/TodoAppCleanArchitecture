using Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IUserRepository
    {
        User GetById(int UserId);
        void Insert(User user);
        void Update(User User);
        void Save();
    }
}
