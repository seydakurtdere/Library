using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class StudentDTO : IEntity
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string RecordStatusName { get; set; }
    }
}
