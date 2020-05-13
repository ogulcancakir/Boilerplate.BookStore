using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using Ogulcan.BookStore.Authors;
using System;

namespace Ogulcan.BookStore.Tests.Authors
{
    public class AuthorsAppService_Tests : BookStoreTestBase
    {
        private readonly IAuthorsAppService _authorsAppService;
        public AuthorsAppService_Tests()
        {
            _authorsAppService = Resolve<IAuthorsAppService>();
        }

        [Fact]
        public async Task CreateAuthorAsync_Test()
        {

            var authorCreated = await _authorsAppService.CreateAsync(new AuthorDto
            {
                AuthorName = "Oğulcan Çakır",
                Bio = "İstanbulda doğdu, 27 yaşında",
                BornIn = new DateTime(1993, 6, 22)
            });

            await UsingDbContextAsync(async context =>
            {
                var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == authorCreated.Id);
                author.ShouldNotBeNull();
            });
        }
    }
}
