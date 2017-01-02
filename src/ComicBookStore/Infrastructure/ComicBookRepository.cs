using ComicBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookStore.Infrastructure
{
    public class ComicBookRepository : GenericRepository<ComicBook>
    {
        public ComicBookRepository(ApplicationDbContext db) : base(db) { }
    } 
}
