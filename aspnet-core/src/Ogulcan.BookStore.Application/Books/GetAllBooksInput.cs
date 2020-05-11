using System;

namespace Ogulcan.BookStore.Books
{
    public class GetAllBooksInput
    {
        public int TenantId { get; set; }
        public Guid? AuthorId { get; set; }
    }
}