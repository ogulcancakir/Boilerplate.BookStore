using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace Ogulcan.BookStore.Authors
{
    public interface IAuthorsAppService : IAsyncCrudAppService<AuthorDto,int>
    {

    }
}
