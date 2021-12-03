using Agro.Tag.Core.ContractRepositories.ContractsGeneic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agro.Tag.Core.Entities;
using System.Linq.Expressions;
using Agro.Tag.EF.BD.Infrastructure.DAL;

namespace Agro.Tag.EF.BD.Infrastructure.ImpContractRepository
{
    public class TagRepository : IGenericRepository<Core.Entities.Tag>
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public TagRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Core.Entities.Tag Deleted(Core.Entities.Tag entity)
        {
            
            var dt = _applicationDbContext.Entry(entity).State;
            if (_applicationDbContext.Entry(entity).State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {

                _applicationDbContext.Remove(entity);
                _applicationDbContext.SaveChanges();

            }
            return entity;

        }

        public Core.Entities.Tag Get(int id)
        {
            var result = _applicationDbContext.Tag.FirstOrDefault(c => c.Id == id);
            return result;
        }

        public IEnumerable<Core.Entities.Tag> Get(Expression<Func<Core.Entities.Tag, bool>> expression)
        {
            var list = _applicationDbContext.Tag.Where(expression).ToList();
            return list;
        }

        public Core.Entities.Tag Insert(Core.Entities.Tag entity)
        {
            

            var dt = _applicationDbContext.Entry(entity).State;

            if (_applicationDbContext.Entry(entity).State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {

             _applicationDbContext.Add(entity);
             _applicationDbContext.SaveChanges();

            }
            return entity;
        }

        public Core.Entities.Tag Update(Core.Entities.Tag entity)
        {
           

            var dt = _applicationDbContext.Entry(entity).State;
            if (_applicationDbContext.Entry(entity).State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {
                
                _applicationDbContext.Update(entity);
                _applicationDbContext.SaveChanges();
            }
            
            return entity;
        }
    }
}
