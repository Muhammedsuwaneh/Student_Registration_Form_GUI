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
            this.ClearListButton = new System.Windows.Forms.Button();
            this.ClearField = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.ForeColor = System.Drawing.Color.White;
            this.StudentIDLabel.Location = new System.Drawing.Point(9, 131);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(86, 19);
            this.StudentIDLabel.TabIndex = 1;
            this.StudentIDLabel.Text = "Student ID *";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentIDTextBox.Location = new System.Drawing.Point(11, 153);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(351, 23);
            this.StudentIDTextBox.TabIndex = 2;
            this.StudentIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentIDTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(9, 195);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(98, 19);
            this.DateOfBirthLabel.TabIndex = 1;
            this.DateOfBirthLabel.Text = "Date of Birth *";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(8, 256);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 19);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address *";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(11, 279);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(351, 136);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(11, 220);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(154)))), ((int)(((byte)(239)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegisterButton.Location = new System.Drawing.Point(12, 435);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(350, 37);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.TabStop = false;
            this.RegisterButton.Text = "Register Student";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.ForeColor = System.Drawing.Color.White;
            this.StudentNameLabel.Location = new System.Drawing.Point(9, 66);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(109, 19);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Student Name *";
            // 
            // StudentInfo
            // 
            this.StudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mStudentName,
            this.ID,
            this.BirthDate,
            this.StudentAddress});
            this.StudentInfo.Location = new System.Drawing.Point(391, 69);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.RowHeadersWidth = 80;
            this.StudentInfo.Size = new System.Drawing.Size(482, 346);
            this.StudentInfo.TabIndex = 0;
            // 
            // mStudentName
            // 
            this.mStudentName.FillWeight = 150F;
            this.mStudentName.HeaderText = "Name";
            this.mStudentName.Name = "mStudentName";
            this.mStudentName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "DOB";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // StudentAddress
            // 
            this.StudentAddress.HeaderText = "Address";
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.ReadOnly = true;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentNameTextBox.Location = new System.Drawing.Point(12, 90);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(350, 23);
            this.StudentNameTextBox.TabIndex = 2;
            this.StudentNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentNameTextBox_KeyPress);
            // 
            // StudentNameError
            // 
            this.StudentNameError.AutoSize = true;
            this.StudentNameError.Location = new System.Drawing.Point(9, 114);
            this.StudentNameError.Name = "StudentNameError";
            this.StudentNameError.Size = new System.Drawing.Size(0, 13);
            this.StudentNameError.TabIndex = 8;
            this.StudentNameError.Visible = false;
            // 
            // StudentIDError
            // 
            this.StudentIDError.AutoSize = true;
            this.StudentIDError.Location = new System.Drawing.Point(8, 177);
            this.StudentIDError.Name = "StudentIDError";
            this.StudentIDError.Size = new System.Drawing.Size(0, 13);
            this.StudentIDError.TabIndex = 8;
            this.StudentIDError.Visible = false;
            // 
            // AddressError
            // 
            this.AddressError.AutoSize = true;
            this.AddressError.Location = new System.Drawing.Point(9, 402);
            this.AddressError.Name = "AddressError";
            this.AddressError.Size = new System.Drawing.Size(0, 13);
            this.AddressError.TabIndex = 8;
            this.AddressError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register A Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "* for required fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(386, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Student List ";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearListButton.BackColor = System.Drawing.Color.Red;
            this.ClearListButton.FlatAppearance.BorderSize = 0;
            this.ClearListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearListButton.Location = new System.Drawing.Point(765, 435);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Padding = new System.Windows.Forms.Padding(2);
            this.ClearListButton.Size = new System.Drawing.Size(108, 37);
            this.ClearListButton.TabIndex = 0;
            this.ClearListButton.TabStop = false;
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.UseVisualStyleBackColor = false;
            this.ClearListButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ClearField
            // 
            this.ClearField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClearField.FlatAppearance.BorderSize = 0;
            this.ClearField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearField.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearField.Location = new System.Drawing.Point(391, 435);
            this.ClearField.Name = "ClearField";
            this.ClearField.Padding = new System.Windows.Forms.Padding(2);
            this.ClearField.Size = new System.Drawing.Size(107, 37);
            this.ClearField.TabIndex = 0;
            this.ClearField.TabStop = false;
            this.ClearField.Text = "Clear Fields";
            this.ClearField.UseVisualStyleBackColor = false;
            this.ClearField.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(514, 435);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(2);
            this.EditButton.Size = new System.Drawing.Size(107, 37);
            this.EditButton.TabIndex = 0;
            this.EditButton.TabStop = false;
            this.EditButton.Text = "Edit Student Info";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(639, 435);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Size = new System.Drawing.Size(108, 37);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete Student";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(893, 510);
            this.Controls.Add(this.ClearField);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressError);
            this.Controls.Add(this.StudentIDError);
            this.Controls.Add(this.StudentNameError);
            this.Controls.Add(this.StudentInfo);
            this.Controls.Add(this.StudentNameTextBox);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
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
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.DataGridView StudentInfo;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label StudentNameError;
        private System.Windows.Forms.Label StudentIDError;
        private System.Windows.Forms.Label AddressError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button ClearField;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

