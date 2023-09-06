using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.EF.Repository
{

   public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _Context;
        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            _Context = applicationDbContext;
        }
        public T FindId(int id)
        {
            return  _Context.Set<T>().Find(id);
        }
    }
}
