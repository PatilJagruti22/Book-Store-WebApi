using BookCart.Models.Data;
using BookCart.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCart.Services.BookCart
{
    public class BookCartService : IBookCartService
    {
        private readonly BookCartDbContext _bookCartDbContext;
        public BookCartService(BookCartDbContext bookCartDbContext)
        {
            _bookCartDbContext = bookCartDbContext;
        }
        public async Task<BookCartViewModel> GetBook(Guid id)
        {
            var bookData = await _bookCartDbContext.Books.Where(x => x.BookId == id)
                .Select(s => new BookCartViewModel
                {
                    BookId = s.BookId,
                    Title = s.Title,
                    TotalPages = s.TotalPages,
                    Price = s.Price,
                    Authors = s.Authors,
                    IsPublished = s.IsPublished,
                    PublishedOn = s.PublishedOn,
                }).FirstOrDefaultAsync();
            return bookData;
        }

        public async Task<IEnumerable<BookCartViewModel>> GetBookList()
        {
            var bookList = await _bookCartDbContext.Books.Select(s => new BookCartViewModel
            {
                BookId = s.BookId,
                Title = s.Title,
                TotalPages = s.TotalPages,
                Price = s.Price,
                Authors = s.Authors,
                IsPublished = s.IsPublished,
                PublishedOn = s.PublishedOn,
            }).ToListAsync();
            return bookList;
        }

        public async Task<BookCartViewModel> CreateBook(BookCartViewModel Book)
        {
            var bookData = new Models.BookCart
            {
                BookId = Book.BookId,
                Title = Book.Title,
                Price = Book.Price,
                TotalPages = Book.TotalPages,
                Authors = Book.Authors,
                PublishedOn = Book.PublishedOn,
                IsPublished = Book.IsPublished,
            };
            _bookCartDbContext.Add(bookData);
            _bookCartDbContext.SaveChanges();
            return Book;
        }
    }
}
