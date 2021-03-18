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

            if(!this.HasFieldError)
            {
                // add new student to student list
                StudentList.Add(new Student(this.Fields[0].Item1.Text, this.Fields[1].Item1.Text, this.Fields[2].Item1.Text, birthdate));

                // format all inputs and display on list box
                StudentInfo.Rows.Add(this.Fields[0].Item1.Text, this.Fields[1].Item1.Text,
                        birthdate.ToString("MM/dd/yyyy"), this.Fields[2].Item1.Text);
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

        #endregion
    }
}
