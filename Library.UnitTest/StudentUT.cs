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
    public class StudentUT
    {
        private StudentService service;
        [TestInitialize]
        public void Setup()
        {
            service = new StudentService();
        }

        [TestMethod]
        public void Save()
        {
            StudentDTO student = new StudentDTO
            {
                FirstName = "Seyda",
                LastName = "Kurtdere",
                StudentNumber = "5557788",
                MobilePhone = "053845781450",
                EmailAddress = "skurtdere@gmail.com"
            };
            

            StudentDTO student2 = new StudentDTO
            {
                FirstName = "Cansu",
                LastName = "Tanrıöver",
                StudentNumber = "6644778",
                MobilePhone = "05324875946",
                EmailAddress = "cansutnrover@gmail.com"
            };
            var result2 = service.Save(student2);
            Assert.IsNotNull(result2);


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
            StudentDTO student2 = new StudentDTO
            {
                StudentId = 1,
                FirstName = "Cansu",
                LastName = "Tanrıöver",
                StudentNumber = "6644778",
                MobilePhone = "05324875946",
                EmailAddress = "cansutnrover@gmail.com",
                RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif),
                CreatedDate = DateTime.Now
            };

            var result = service.Update(student2);

            Assert.IsTrue(result);
        }

    }
}
