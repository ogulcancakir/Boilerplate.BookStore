using Abp.Application.Services.Dto;
using Abp.Runtime.Session;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ogulcan.BookStore.Authors
{
    [AutoMapTo(typeof(Author))]
    public class AuthorDto : EntityDto
    {
        [StringLength(Author.MaxAuthorNameLength)]
        public string AuthorName { get; set; }
        public DateTime? BornIn { get; set; }
        [StringLength(Author.MaxBioLength)]
        public string Bio { get; set; }

    }
}