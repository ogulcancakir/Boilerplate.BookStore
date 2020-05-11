

using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogulcan.BookStore.Books
{
    [Table("AppBooks")]
    public class Book : FullAuditedEntity<Guid> , IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string BookName { get; set; }
        
    }
}
