using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Agro.Tag.Core.Entities;

namespace Agro.Tag.Application.Contracts
{
    public interface ITagAplication
    {
        Core.Entities.Tag Get(int id);
        IEnumerable<Core.Entities.Tag> Get(Expression<Func<Core.Entities.Tag, bool>> expression);
        Core.Entities.Tag Insert(Core.Entities.Tag entity);
        //int Update(Core.Entities.Tag entity);
        Core.Entities.Tag Update(Core.Entities.Tag entity);

        Core.Entities.Tag Deleted(Core.Entities.Tag entity);

    }
}
