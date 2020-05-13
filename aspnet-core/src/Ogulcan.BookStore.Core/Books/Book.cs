

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ogulcan.BookStore.Authors;

namespace Ogulcan.BookStore.Books
{
    [Table("AppBooks")]
    public class Book : FullAuditedEntity<Guid> , IMustHaveTenant, IPassivable
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64kb
        public int TenantId { get; set; }
        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }
        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
        public DateTime? Published { get; set; }
        public byte[] BookImage { get; set; }
        public bool IsActive { get; set; }
        public Author Author { get; set; }

        public Book()
        {
            this.CreationTime = DateTime.Now;
            this.IsActive = true;
            
        }

    }
}
