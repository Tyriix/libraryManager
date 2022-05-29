﻿using LibraryManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Services.BorrowServices
{
    public interface IBorrowService
    {
        ICollection<Borrow> GetBorrows();
        Task<Borrow> BorrowBook(Borrow borrow, Book book, Client client);
    }
}