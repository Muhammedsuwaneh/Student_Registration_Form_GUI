namespace Student_Registation_Form
{
    partial class StudentRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ClearField = new System.Windows.Forms.Button();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentInfo = new System.Windows.Forms.DataGridView();
            this.mStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameError = new System.Windows.Forms.Label();
            this.StudentIDError = new System.Windows.Forms.Label();
            this.AddressError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(9, 119);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(65, 13);
            this.StudentIDLabel.TabIndex = 1;
            this.StudentIDLabel.Text = "Student ID *";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentIDTextBox.Location = new System.Drawing.Point(11, 138);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(351, 23);
            this.StudentIDTextBox.TabIndex = 2;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(9, 185);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(73, 13);
            this.DateOfBirthLabel.TabIndex = 1;
            this.DateOfBirthLabel.Text = "Date of Birth *";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(8, 235);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 13);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address *";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(11, 253);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(351, 128);
            this.AddressTextBox.TabIndex = 2;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(11, 205);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Green;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegisterButton.Location = new System.Drawing.Point(12, 405);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(350, 32);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.TabStop = false;
            this.RegisterButton.Text = "Register Student";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClearField, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(380, 441);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 38);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(229, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Delete Student";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(116, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.Text = "Edit Student Info";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ClearField
            // 
            this.ClearField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearField.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearField.FlatAppearance.BorderSize = 0;
            this.ClearField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearField.Location = new System.Drawing.Point(3, 3);
            this.ClearField.Name = "ClearField";
            this.ClearField.Size = new System.Drawing.Size(107, 32);
            this.ClearField.TabIndex = 0;
            this.ClearField.TabStop = false;
            this.ClearField.Text = "Clear Fields";
            this.ClearField.UseVisualStyleBackColor = false;
            this.ClearField.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(9, 54);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(82, 13);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Student Name *";
            // 
            // StudentInfo
            // 
            this.StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mStudentName,
            this.ID,
            this.BirthDate,
            this.StudentAddress});
            this.StudentInfo.Location = new System.Drawing.Point(380, 54);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(446, 379);
            this.StudentInfo.TabIndex = 0;
            // 
            // mStudentName
            // 
            this.mStudentName.HeaderText = "Name";
            this.mStudentName.Name = "mStudentName";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "DOB";
            this.BirthDate.Name = "BirthDate";
            // 
            // StudentAddress
            // 
            this.StudentAddress.HeaderText = "Address";
            this.StudentAddress.Name = "StudentAddress";
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentNameTextBox.Location = new System.Drawing.Point(12, 75);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(350, 23);
            this.StudentNameTextBox.TabIndex = 2;
            // 
            // StudentNameError
            // 
            this.StudentNameError.AutoSize = true;
            this.StudentNameError.Location = new System.Drawing.Point(9, 99);
            this.StudentNameError.Name = "StudentNameError";
            this.StudentNameError.Size = new System.Drawing.Size(0, 13);
            this.StudentNameError.TabIndex = 8;
            this.StudentNameError.Visible = false;
            // 
            // StudentIDError
            // 
            this.StudentIDError.AutoSize = true;
            this.StudentIDError.Location = new System.Drawing.Point(8, 162);
            this.StudentIDError.Name = "StudentIDError";
            this.StudentIDError.Size = new System.Drawing.Size(0, 13);
            this.StudentIDError.TabIndex = 8;
            this.StudentIDError.Visible = false;
            // 
            // AddressError
            // 
            this.AddressError.AutoSize = true;
            this.AddressError.Location = new System.Drawing.Point(9, 387);
            this.AddressError.Name = "AddressError";
            this.AddressError.Size = new System.Drawing.Size(0, 13);
            this.AddressError.TabIndex = 8;
            this.AddressError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register A Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "* for required fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(374, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current List ";
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressError);
            this.Controls.Add(this.StudentIDError);
            this.Controls.Add(this.StudentNameError);
            this.Controls.Add(this.StudentInfo);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentRegistrationForm";
            this.Text = "Student Registration Form";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ClearField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.DataGridView StudentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label StudentNameError;
        private System.Windows.Forms.Label StudentIDError;
        private System.Windows.Forms.Label AddressError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

