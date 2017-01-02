using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ComicBookStore.Services;
using ComicBookStore.Services.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookStore.Controllers
{
    [Route("api/[controller]")]
    public class ComicsController : Controller
    {

        private ComicBookService _comicService;

        public ComicsController(ComicBookService comicService)
        {
            _comicService = comicService;
        }


        //GET: api/comics/featured
        [HttpGet("featured")]
        public ICollection<ComicBookDTO> GetFeaturedComics() {
            return _comicService.GetFeaturedComics();
        }
    }
}
