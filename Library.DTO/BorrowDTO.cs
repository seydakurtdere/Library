using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class BorrowDTO : IEntity
    {
        public int BorrowId { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public System.DateTime BeginDate { get; set; }
        public System.DateTime EndDate { get; set; }

        public string StudentName { get; set; }
        public string BookName { get; set; }
        public int NumberOfBooks { get; set; }

        public String DisplayString { get { return StudentName + " " + NumberOfBooks + " kitap"; } }
    }
}
