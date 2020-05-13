using Abp.Application.Services.Dto;
using Abp.Runtime.Session;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Ogulcan.BookStore.Authors
{
    [AutoMapFrom(typeof(Author))]
    public class AuthorDto : EntityDto
    {
        [StringLength(Author.MaxAuthorNameLength)]
        public string AuthorName { get; set; }
        public DateTime? BornIn { get; set; }
        [StringLength(Author.MaxBioLength)]
        public string Bio { get; set; }

    }

    [AutoMapFrom(typeof(Author))]
    public class CreateAuthorDto : AuthorDto, IHasCreationTime , ICreationAudited
    {
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }

    public class GetAllAuthorsInput : PagedAndSortedResultRequestDto
    {
        public string AuthorName { get; set; }
    }

    [AutoMapFrom(typeof(Author))]
    public class UpdateAuthorDto : AuthorDto, IHasModificationTime, IModificationAudited
    {
        public DateTime? LastModificationTime { get ; set ; }
        public long? LastModifierUserId { get ; set ; }
    }

    


}