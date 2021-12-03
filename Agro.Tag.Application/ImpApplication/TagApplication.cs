using Agro.Tag.Application.Contracts;
using Agro.Tag.Core.ContractRepositories.ContractsGeneic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Tag.Application.ImpApplication
{
    public class TagApplication : ITagAplication
    {

        private readonly IGenericRepository<Core.Entities.Tag> _genericRepository;

        public TagApplication(IGenericRepository<Core.Entities.Tag> genericRepository)
        {
            _genericRepository= genericRepository;
        }

        public Core.Entities.Tag Deleted(Core.Entities.Tag entity)
        {
            return _genericRepository.Deleted(entity);
        }

        public Core.Entities.Tag Get(int id)
        {
            return _genericRepository.Get(id);
        }

        public IEnumerable<Core.Entities.Tag> Get(Expression<Func<Core.Entities.Tag, bool>> expression)
        {
            return _genericRepository.Get(expression);
        }

        public Core.Entities.Tag Insert(Core.Entities.Tag entity)
        {
            return _genericRepository.Insert(entity);
        }

        //public int Update(Core.Entities.Tag entity)
        //{
        //    return _genericRepository.Update(entity);
        //}
        public Core.Entities.Tag Update(Core.Entities.Tag entity)
        {
            return _genericRepository.Update(entity);
        }
    }
}
