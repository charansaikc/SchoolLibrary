using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public interface IBookService
    {
        IEnumerable<string> GetAllBooksForCategory(string categoryId);
        IEnumerable<string> GetBooksForCategory(string categoryid);
    }
    public interface IEmailSender
    {
        void SendEmail(string to, string subject, string body);
    }
    public class AccountService
    {
        private IBookService _bookService;
        public AccountService(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IEnumerable<string> GetAllBooksForCategory(string categoryId)
        {
            var allBooks = _bookService.GetBooksForCategory(categoryId);//fake
            return allBooks;
        }


    }
}
