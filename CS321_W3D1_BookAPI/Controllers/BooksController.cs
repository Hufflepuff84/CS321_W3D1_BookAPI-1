using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookApi.Services;
using BookApi.Models;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/values
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookService.Get(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            var book = _bookService.Add(newBook);
            if (book == null) return BadRequest();
            return CreatedAtAction("Get", new { id = newBook.Id }, newBook);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book updatedBook)
        {
            var book = _bookService.Update(updatedBook);
            if (book == null) return BadRequest();
            return Ok(book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _bookService.Get(id);
            if (book == null) return NotFound();
            _bookService.Remove(book);
            return NoContent();

        }
    }
}
