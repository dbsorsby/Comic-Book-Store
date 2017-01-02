using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookStore.Services.Models
{
    public class ComicBookDTO
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

    }
}
