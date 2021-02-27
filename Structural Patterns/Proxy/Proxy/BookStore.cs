using System.Linq;

namespace Proxy
{
    class BookStore : IBook
    {
        PageContext db;
        public BookStore()
        {
            db = new PageContext();
        }
        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
