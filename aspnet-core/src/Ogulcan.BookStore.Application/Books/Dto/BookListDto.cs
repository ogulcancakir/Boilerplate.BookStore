using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace Ogulcan.BookStore.Books.Dto
{
    [AutoMapFrom(typeof(Book))]
    public class BookListDto : EntityDto<Guid> , IHasCreationTime
    {
        public string AuthorName { get; set; }
        public Guid? AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public DateTime CreationTime { get ; set ; }
    }
}