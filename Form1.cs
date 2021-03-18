using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registation_Form
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Register's Student 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            List<Student> StudentList = new List<Student>();

            string name = StudentName.Text;
            string id = StudentID.Text;
            string address = Address.Text;
            DateTime birthdate = DateOfBirth.Value;

            StudentList.Add(new Student(name, id, address, birthdate));

            foreach(Student student in StudentList)
            {
                StudentInfo.Rows.Add(student.mStudentName, student.mStudentID, 
                    student.mStudentDateOfBirth.ToString(), student.mStudentAddress);
            }

            ClearFields();
        }


        private void ClearFields()
        {
            StudentName.Text = string.Empty;
            StudentID.Text = string.Empty;
            Address.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
