﻿namespace Bookie.Data.Contracts
{
    using System;
    using System.Linq;
    using Bookie.Models;

    public interface IBookieData : IDisposable
    {
        IGenericRepository<User> Users { get; }

        IGenericRepository<Author> Authors { get; }

        IGenericRepository<Book> Books { get; }

        IGenericRepository<BookComment> BookComments { get; }

        IGenericRepository<Publisher> Publishers { get; }

        IGenericRepository<Category> Categories { get; }

        IGenericRepository<SubCategory> SubCategories { get; }

        IGenericRepository<PurchasedBook> PurchasedBooks { get; }

        int SaveChanges();
    }
}