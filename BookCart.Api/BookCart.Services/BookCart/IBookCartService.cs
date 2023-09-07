using BookCart.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Services.BookCart
{
    public interface IBookCartService
    {
        Task<BookCartViewModel> GetBook(Guid id);
        Task<IEnumerable<BookCartViewModel>> GetBookList();
        Task<BookCartViewModel> CreateBook(BookCartViewModel Book);
    }
}
