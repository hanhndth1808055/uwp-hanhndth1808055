using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Models
{
    class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }
        public enum StudentStatus
        {
            Deactive = 0,
            Active = 1
        }

        public bool IsNewStudent()
        {
            return DateTime.Now.Subtract(this.CreatedAt).TotalDays <= 60;
        }

        public bool IsDeactive()
        {
            return this.Status == StudentStatus.Deactive;
        }
    }
}
