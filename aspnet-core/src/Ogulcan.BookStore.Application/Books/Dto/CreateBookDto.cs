using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
namespace Ogulcan.BookStore.Books.Dto
{
    [AutoMapTo(typeof(Book))]
    public class CreateBookDto
    {
        [Required]
        public int TenantId { get; set; }
        [Required]
        [StringLength(Book.MaxTitleLength)]
        public string Title { get; set; }
        [Required]
        [StringLength(Book.MaxDescriptionLength)]
        public string Description { get; set; }
        public DateTime? Published { get; set; }
        public byte[] BookImage { get; set; }
        public Guid? AuthorId { get; set; }
    }
}
