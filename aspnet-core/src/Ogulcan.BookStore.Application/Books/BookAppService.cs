using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Ogulcan.BookStore.Books.Dto;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ogulcan.BookStore.Books
{
    public class BookAppService : BookStoreAppServiceBase, IBookAppService
    {
        private readonly IRepository<Book, Guid> _bookRepository; 
        public BookAppService(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task CreateBook(CreateBookDto input)
        {
            var book = ObjectMapper.Map<Book>(input);
            await _bookRepository.InsertAsync(book);
        }

        public async Task<ListResultDto<BookListDto>> GetAll(GetAllBooksInput input)
        {
            var books = await _bookRepository
                .GetAll()
                .Where(x=>x.TenantId == input.TenantId)
               // .WhereIf(input.AuthorId.HasValue,x => x.Author.Id == input.AuthorId.Value)
                .ToListAsync();

            return new ListResultDto<BookListDto>(
                ObjectMapper.Map<List<BookListDto>>(books));

            throw new System.NotImplementedException();
        }
    }
}
