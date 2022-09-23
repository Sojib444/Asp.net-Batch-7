﻿using Infrastructure.BusinessObject;
using Infrastructure.Entities;
using Infrastructure.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class BookService : IBookService
    {
        private IApplicationUnitofWork _work;
        public BookService(IApplicationUnitofWork work)
        {
            _work = work;
        }
        public void CreateBook(BBook book)
        {
            book.BookLogic();

            Book book1 = new Book();
            book1.Name = book.Name;
            book1.Price = book.Price;
            book1.Writer = book.Writer;

            _work.bookRepository.Add(book1);
            _work.Save();
        }
    }
}
