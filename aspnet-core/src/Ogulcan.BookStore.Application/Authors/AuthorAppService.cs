using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ogulcan.BookStore.Authors
{
    //AuthorAppService : AsyncCrudAppService<Author, AuthorDto,int,GetAllAuthorsInput,CreateAuthorDto,UpdateAuthorDto>, IAuthorAppService
    public class AuthorAppService : AsyncCrudAppService<Author, AuthorDto>, IAuthorAppService
    {
        private readonly IRepository<Author> _authorRepository;
        public AuthorAppService(IRepository<Author> authorRepository) : base(authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public override Task<AuthorDto> CreateAsync(AuthorDto input)
        {
            var author = MapToEntity(input);

            author.CreatorUserId = AbpSession.UserId;
            author.CreationTime = DateTime.Now;

            var result = _authorRepository.Insert(author);

            return new Task<MapToEntityDto(result)>;
        }

    }
}
