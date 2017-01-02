using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookStore.Models
{
    public class ComicBook
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int IssueNumber { get; set; }

        public decimal Price { get; set; }

        public string Author { get; set; }

        public string Artist { get; set; }

        public string ImageUrl { get; set; }
    }
}
