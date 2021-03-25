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
    /// <summary>
    /// Handles all Studenty registration operations
    /// </summary>
    public partial class StudentRegistrationForm : Form
    {
        #region Private Attributes   

        private List<Student> StudentList = new List<Student>();
        private List<Tuple<TextBox, Label, Label>> Fields = new List<Tuple<TextBox, Label, Label>>();
        private bool HasFieldError;

        #endregion

        #region Constructor
        public StudentRegistrationForm()
        {
            InitializeComponent();
            this.HasFieldError = false;
        }

        #endregion


        #region Private Helpers
        /// <summary>
        /// Register's Student 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {

            Fields.Add(new Tuple<TextBox, Label, Label>(StudentNameTextBox, StudentNameError, StudentNameLabel));
            Fields.Add(new Tuple<TextBox, Label, Label>(StudentIDTextBox, StudentIDError, StudentIDLabel));
            Fields.Add(new Tuple<TextBox, Label, Label>(AddressTextBox, AddressError, AddressLabel));
            DateTime birthdate = DateOfBirth.Value;

            EmptyFieldErrors();

            if (!this.HasFieldError)
            {
                bool studentExist = CheckIfStudentExist(Fields);

                if (studentExist)
                {
                    // add new student to student list
                    StudentList.Add(new Student(this.Fields[0].Item1.Text, this.Fields[1].Item1.Text, this.Fields[2].Item1.Text, birthdate));

                    // format all inputs and display on list box
                    StudentInfo.Rows.Add(StudentList[StudentList.Count-1].mStudentName.ToString(), 
                        StudentList[StudentList.Count - 1].mStudentAddress.ToString(),
                            birthdate.ToString("MM/dd/yyyy"), StudentList[StudentList.Count - 1].mStudentID.ToString());
                }
                else
                {
                    MessageBox.Show("The student you're trying to add already exist. Try again",
                    "Student Exist Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            ClearFields();
        }

        /// <summary>
        /// Clears input fields in the form
        /// </summary>
        private void ClearFields()
        {
            StudentNameTextBox.Text = string.Empty;
            StudentIDTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Clears input fields in the form onclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearField_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Checks for empty field errors
        /// </summary>
        private void EmptyFieldErrors()
        {
           for(var i = 0; i < Fields.Count; i++)
           {
                // check for empty fields and give errors based on field
                 if(Fields[i].Item1.Text == string.Empty || Fields[i].Item1.Text.Length == 0)
                 {
                    string temp = Fields[i].Item3.Text + " is required";

                    // new error string to be displayed to user 
                    if(Fields[i].Item2.Text == string.Empty) Fields[i].Item2.Text = temp;

                    // manipulate field properties
                    Fields[i].Item2.ForeColor = Color.Red;
                    Fields[i].Item2.Visible = true;

                    this.HasFieldError = true;
                 }
                 else
                 {
                    Fields[i].Item2.Visible = false;
                    this.HasFieldError = false;
                 }
           }
        }

        /// <summary>
        /// Checks if a student we are registering already exists
        /// </summary>
        /// <param name="NewStudent"></param>
        /// <returns></returns>
        private bool CheckIfStudentExist(List<Tuple<TextBox, Label, Label>> NewStudent)
        {
            if(StudentList.Count > 0)
            {
                foreach (Student student in StudentList)
                {
                    if (student.mStudentName.ToLower() == NewStudent[0].Item1.Text.ToLower() || student.mStudentID == NewStudent[1].Item1.Text)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        #endregion

        /// <summary>
        /// Allows only numbers in the Student ID field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        ///  Avoids the typing of non alphabetics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// For Address text box to only accept numbers and alphabets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z0-9]*$")
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Deletes selected student(s) from the lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in StudentInfo.SelectedRows)
            {
                int index = row.Index;

                // remove from data grid view 
                StudentInfo.Rows.RemoveAt(index);

                // remove from list 
                StudentList.RemoveAt(index);
            }
        }

        /// <summary>
        /// Deletes all students from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            if(StudentList.Count > 0)
            {
                // clear all students from Data Grid View
                StudentInfo.Rows.Clear();

                // refresh Data Grid View
                StudentInfo.Refresh();

                // Clear all students on list
                StudentList.Clear();
            }
        }


        /// <summary>
        /// Edits student's info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
