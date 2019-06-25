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
    public class BorrowUT
    {
        private BorrowService service;

        [TestInitialize]
        public void Setup()
        {
            service = new BorrowService();
        }

        [TestMethod]
        public void Borrow()
        {
          
            BorrowDTO borrow1 = new BorrowDTO
            {
                BookId = 2,
                StudentId = 1,
                BeginDate = new DateTime(2019, 5, 10),
                EndDate = new DateTime(2019,5,13)
            };
            BorrowDTO borrow2 = new BorrowDTO
            {
                BookId = 3,
                StudentId = 1,
                BeginDate = new DateTime(2019, 5, 10),
                EndDate = new DateTime(2019, 5, 13)
            };
            BorrowDTO borrow3 = new BorrowDTO
            {
                BookId = 1,
                StudentId = 1,
                BeginDate = new DateTime(2019, 5, 10),
                EndDate = new DateTime(2019, 5, 13)
            };

            List<BorrowDTO> list = new List<BorrowDTO>() { borrow1, borrow2, borrow3 };
            var result = service.Borrow(list);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return()
        {
            int studentId = 1;
            var result = service.Return(studentId);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ListBorrows()
        {
            var result = service.ListBorrows();
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void ListBorrowedBooks()
        {
            int studentId = 1;
            var result = service.ListBorrowedBooks(studentId);
            Assert.IsNotNull(result);
        }

    }
}
