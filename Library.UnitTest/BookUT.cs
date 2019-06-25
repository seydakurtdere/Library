using Library.DTO;
using Library.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UnitTest
{
    [TestClass]
    public class BookUT
    {
        private BookService service;

        [TestInitialize]
        public void Setup()
        {
            service = new BookService();
        }
        [TestMethod]
        public void Save()
        {
            BookDTO book = new BookDTO
            {
                BookName = "Suç ve Ceza",
                GenreId = 4,
                Author = "Dostoyevski",
                PublishDate = new DateTime(2019, 1, 1),
                UnitsInStock = 20
            };
            BookDTO book1 = new BookDTO
            {
                BookName = "1984",
                GenreId = 4,
                Author = "George Orwell",
                PublishDate = new DateTime(1954, 1, 1),
                UnitsInStock = 15
            };
            BookDTO book2 = new BookDTO
            {
                BookName = "Ezilenler",
                GenreId = 4,
                Author = "Dostoyevski",
                PublishDate = new DateTime(2010, 1, 1),
                UnitsInStock = 25
            };
            BookDTO book3 = new BookDTO
            {
                BookName = "Harry Potter",
                GenreId = 4,
                Author = "Dostoyevski",
                PublishDate = new DateTime(2010, 1, 1),
                UnitsInStock = 25
            };
            var result1 = service.Save(book1);
            var result2 = service.Save(book2);
            var result3 = service.Save(book3);
            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            Assert.IsNotNull(result3);
        }

        [TestMethod]
        public void List()
        {
            var result = service.List();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get()
        {
            int id = 1;
            var result = service.Get(id);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Update()
        {
            BookDTO book3 = new BookDTO
            {
                BookId = 2,
                BookName = "Harry Potter",
                GenreId = 4,
                Author = "Dostoyevski",
                PublishDate = new DateTime(2010, 1, 1),
                UnitsInStock = 15,
                CreatedDate = DateTime.Now,
                RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif)
            };
            var result = service.Update(book3);
            Assert.IsTrue(result);
        }
    }
}
