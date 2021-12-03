using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agro.Tag.Core.ContractRepositories.ContractsGeneic
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> expression);
        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Deleted(TEntity entity);
    }
}
