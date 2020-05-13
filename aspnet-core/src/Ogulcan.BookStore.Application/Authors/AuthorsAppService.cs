using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ogulcan.BookStore.Authors
{
    public class AuthorsAppService : AsyncCrudAppService<Author, AuthorDto>, IAuthorsAppService
    {
        private readonly IRepository<Author> _authorRepository;
        public AuthorsAppService(IRepository<Author> authorRepository) : base(authorRepository)
        {
            _authorRepository = authorRepository;
        }
    }
}
