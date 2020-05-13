using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace Ogulcan.BookStore.Authors
{
    //IAuthorAppService : IAsyncCrudAppService<AuthorDto,int,GetAllAuthorsInput,CreateAuthorDto,UpdateAuthorDto>
    public interface IAuthorAppService : IAsyncCrudAppService<AuthorDto>
    {

    }
}
