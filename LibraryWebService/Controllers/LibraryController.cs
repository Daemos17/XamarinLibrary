using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryWebService.Models;


namespace LibraryWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        libraryContext db;

       public LibraryController(libraryContext context)
        {
            db = context;
        }


        [HttpGet]
        public async Task <ActionResult<IEnumerable<Book>>> Get()
        {
            var query = (from bok in db.Set<Book>()
                         from gen in db.Set<Genre>().Where(x => x.IdGenre == bok.IdGenreFk)
                         from type in db.Set<Models.Type>().Where(x => x.IdType == bok.IdTypeFk)
                         from atu in db.Set<Author>().Where(x => x.IdAuthor == bok.IdAuthorFk)
                         select new Book
                         {
                             IdBook=bok.IdBook,
                             BookName = bok.BookName,
                             Amount=bok.Amount,
                             Year=bok.Year,
                            IdAuthorFkNavigation=atu,
                            ImagePath=bok.ImagePath,
                            IdGenreFkNavigation=gen,
                            IdTypeFkNavigation=type,
                            IdAuthorFk=atu.IdAuthor,
                            IdGenreFk=gen.IdGenre,
                            IdTypeFk=type.IdType
                            

                         }) ;
            return await query
                .ToListAsync();
        }





}
}
