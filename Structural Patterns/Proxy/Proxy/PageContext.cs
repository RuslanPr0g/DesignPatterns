using Microsoft.EntityFrameworkCore;

namespace Proxy
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
