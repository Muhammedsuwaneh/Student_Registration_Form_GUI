using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registation_Form
{
    /// <summary>
    /// Student Class 
    /// </summary>
    public class Student
    {
        public string mStudentName { get; set; }
        public string mStudentID { get; set; }
        public string mStudentAddress { get; set; }
        public DateTime mStudentDateOfBirth { get; set; }
        public Student(string name, string id, string address, DateTime birtdate)
        {
            this.mStudentName = name;
            this.mStudentID = id;
            this.mStudentAddress = address;
            this.mStudentDateOfBirth = birtdate;
        }
    }
}
