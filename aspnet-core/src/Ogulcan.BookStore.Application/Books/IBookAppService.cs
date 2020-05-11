using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ogulcan.BookStore.Books.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ogulcan.BookStore.Books
{
    public interface IBookAppService : IApplicationService
    {
        Task<ListResultDto<BookListDto>> GetAll(GetAllBooksInput input);

        Task CreateBook(CreateBookDto input);
    }
}
