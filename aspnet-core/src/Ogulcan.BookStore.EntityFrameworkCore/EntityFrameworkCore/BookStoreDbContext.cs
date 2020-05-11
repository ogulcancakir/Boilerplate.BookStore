using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ogulcan.BookStore.Authorization.Roles;
using Ogulcan.BookStore.Authorization.Users;
using Ogulcan.BookStore.MultiTenancy;
using Ogulcan.BookStore.Books;

namespace Ogulcan.BookStore.EntityFrameworkCore
{
    public class BookStoreDbContext : AbpZeroDbContext<Tenant, Role, User, BookStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }
    }
}
