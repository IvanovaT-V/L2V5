
using Microsoft.EntityFrameworkCore;

namespace L2V5.Models
{
    public class LinkContext : DbContext
    { 

      public LinkContext(DbContextOptions<LinkContext> options)
            : base(options)
        {
           }
        public DbSet<Link> Links { get; set; }



        }


    }
    
