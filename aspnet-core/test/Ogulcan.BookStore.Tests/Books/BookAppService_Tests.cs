using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using Ogulcan.BookStore.Books;
using System;

namespace Ogulcan.BookStore.Tests.Books
{
    public class BookAppService_Tests : BookStoreTestBase
    {
        private readonly IBookAppService _bookAppService;

        public BookAppService_Tests()
        {
            _bookAppService = Resolve<IBookAppService>();
        }

        [Fact]
        public async Task CreateBook_Test()
        {
            Task t = _bookAppService.CreateBook(new BookStore.Books.Dto.CreateBookDto
            {
                AuthorId = null,
                Description = "Book Description",
                Title = "Book Title",
                Published = DateTime.Now
                
            });


            await UsingDbContextAsync(async context =>
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.Title == "Book Title");
                book.ShouldNotBeNull();
            });
        }

    }
}
