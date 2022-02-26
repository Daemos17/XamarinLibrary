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
            return await db.Books
                .ToListAsync();
        }





}
}
