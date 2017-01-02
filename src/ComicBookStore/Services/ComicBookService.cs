using ComicBookStore.Infrastructure;
using ComicBookStore.Models;
using ComicBookStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookStore.Services
{
    public class ComicBookService
    {

        private ComicBookRepository _comicRepo;

        public ComicBookService(ComicBookRepository comicRepo)
        {
           _comicRepo = comicRepo;            
        }

        public ICollection<ComicBookDTO> GetFeaturedComics() {
            return (from c in _comicRepo.List()
                    select new ComicBookDTO() {
                        Title = c.Title,
                        ImageUrl = c.ImageUrl,
                        Price = c.Price,
                    }).ToList();
        }
    }
}
