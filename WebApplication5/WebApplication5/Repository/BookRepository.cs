using System.Collections.Generic;
using WebApplication5.Models;
using System.Linq;

namespace WebApplication5.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.ID == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string tittle,string authorName)
        {
            if (tittle == null || authorName == null)
            {
                return null;
            }

            return DataSource().Where(x  => x.Title.Equals(tittle) || x.Author.Equals(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { ID = 1,Title = "MVC",Author = "Trung Hieu" },
                new BookModel() { ID = 2,Title = "Dot net",Author = "Trung Hieu" },
                new BookModel() { ID = 3,Title = "C#",Author = "Monika" },
                new BookModel() { ID = 4,Title = "Java",Author = "Web5Ngay" },
                new BookModel() { ID = 5,Title = "Php",Author = "Draw Your Brain" },
            };
        }

    }
}
