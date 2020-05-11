using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Ogulcan.BookStore.Authorization.Roles;
using Ogulcan.BookStore.Authorization.Users;
using Ogulcan.BookStore.MultiTenancy;

namespace Ogulcan.BookStore.EntityFrameworkCore
{
    public class BookStoreDbContext : AbpZeroDbContext<Tenant, Role, User, BookStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }
    }
}
