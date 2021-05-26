using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L2V5.Models
{
    public class Repository : IRepository
    {
       
        private LinkContext Context;
        

        public IEnumerable<Link> Get()
        {
            return Context.Links;
        }
        public Link Get(long Id)
        {
            return Context.Links.Find(Id);
        }
        public Repository(LinkContext context)
        {
            Context = context;
 
        }
        public void Create(Link link)
        {
            Context.Links.Add(link);
            Context.SaveChanges();
        }
        public void Update(Link updatedLink)
        {
            Link currentLink = Get(updatedLink.Id);
            currentLink.Name = updatedLink.Name;
            currentLink.Url = updatedLink.Url;

            Context.Links.Update(currentLink);
            Context.SaveChanges();
        }

        public Link Delete(long Id)
        {
            Link link = Get(Id);

            if (link != null)
            {
                Context.Links.Remove(link);
                Context.SaveChanges();
            }

            return link;
        }
    }
}
