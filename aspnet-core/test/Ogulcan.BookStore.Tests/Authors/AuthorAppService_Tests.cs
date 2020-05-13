using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using Ogulcan.BookStore.Authors;
using System;

namespace Ogulcan.BookStore.Tests.Authors
{
    public class AuthorAppService_Tests : BookStoreTestBase
    {
        private readonly IAuthorAppService _authorAppService;
        public AuthorAppService_Tests()
        {
            _authorAppService = Resolve<IAuthorAppService>();
        }

        [Fact]
        public async Task CreateAuthorAsync_Test()
        {
            var authorCreated = await _authorAppService.CreateAsync(new AuthorDto
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

        [Fact]
        public async Task GetAllAuthorsAsync_Test()
        {
            await _authorAppService.CreateAsync(new AuthorDto
            {
                AuthorName = "Oğulcan Çakır",
                Bio = "İstanbulda doğdu, 27 yaşında",
                BornIn = new DateTime(1993, 6, 22)
            });
            await _authorAppService.CreateAsync(new AuthorDto
            {
                AuthorName = "Yarkın Çolak",
                Bio = "İstanbulda doğdu, 27 yaşında",
                BornIn = new DateTime(1993, 6, 12)
            });

            var result = await _authorAppService.GetAllAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 10, SkipCount = 10, Sorting = "" });

            result.TotalCount.ShouldBeGreaterThanOrEqualTo(2);

        }
    }
}
