using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L2V5.Models
{
    public interface IRepository
    {
        IEnumerable<Link> Get();
        Link Get(long id);
        void Create(Link link);
        void Update(Link link);
        Link Delete(long id);
    }
}
