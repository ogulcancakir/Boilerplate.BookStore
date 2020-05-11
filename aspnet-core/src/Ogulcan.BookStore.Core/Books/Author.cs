﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Extensions;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogulcan.BookStore.Books
{
    [Table("AppAuthors")]
    public class Author : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public const int MaxAuthorNameLength = 256;
        public const int MaxBioLength = 64 * 1024;
        
        [StringLength(MaxAuthorNameLength)]
        public string AuthorName { get; set; }
        public DateTime BornIn { get; set; }
        [StringLength(MaxBioLength)]
        public string Bio { get; set; }
        public int TenantId { get; set; }

        public Author()
        {
            this.CreationTime = DateTime.Now;
        }

    }
}
