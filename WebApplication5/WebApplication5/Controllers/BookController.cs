using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null; 

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public IActionResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public BookModel GetBookValue(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }


    }
}
