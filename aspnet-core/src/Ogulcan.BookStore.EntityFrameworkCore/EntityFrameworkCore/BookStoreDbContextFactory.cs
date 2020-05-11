﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Ogulcan.BookStore.Configuration;
using Ogulcan.BookStore.Web;

namespace Ogulcan.BookStore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BookStoreDbContextFactory : IDesignTimeDbContextFactory<BookStoreDbContext>
    {
        public BookStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BookStoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BookStoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BookStoreConsts.ConnectionStringName));

            return new BookStoreDbContext(builder.Options);
        }
    }
}
