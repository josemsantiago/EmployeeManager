namespace SantiagoEchevarria_CourseProject_Part2
{
    partial class InputForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.LifeInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsuranceLabel = new System.Windows.Forms.Label();
            this.HealthInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsuranceLabel = new System.Windows.Forms.Label();
            this.VacationDaysTextBox = new System.Windows.Forms.TextBox();
            this.VacationLabel = new System.Windows.Forms.Label();
            this.EmployeeTypeLabel = new System.Windows.Forms.Label();
            this.HourlyRadioRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.HoursWorkedTextbox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.HourlyRateTextbox = new System.Windows.Forms.TextBox();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.Salarytextbox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(43, 53);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(162, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name: ";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(197, 46);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(357, 38);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(197, 106);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(357, 38);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(43, 113);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(160, 31);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(197, 169);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(357, 38);
            this.SSNTextBox.TabIndex = 2;
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(118, 176);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(85, 31);
            this.SSNLabel.TabIndex = 4;
            this.SSNLabel.Text = "SSN: ";
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(61, 247);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(144, 31);
            this.HireDateLabel.TabIndex = 6;
            this.HireDateLabel.Text = "Hire Date: ";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(86, 559);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(175, 59);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(336, 559);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 59);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(197, 240);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(357, 38);
            this.HireDateTextBox.TabIndex = 3;
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceLabel);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceLabel);
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysTextBox);
            this.BenefitsGroupBox.Controls.Add(this.VacationLabel);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(647, 46);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(504, 358);
            this.BenefitsGroupBox.TabIndex = 4;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // LifeInsuranceTextBox
            // 
            this.LifeInsuranceTextBox.Location = new System.Drawing.Point(261, 125);
            this.LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            this.LifeInsuranceTextBox.Size = new System.Drawing.Size(237, 38);
            this.LifeInsuranceTextBox.TabIndex = 1;
            // 
            // LifeInsuranceLabel
            // 
            this.LifeInsuranceLabel.AutoSize = true;
            this.LifeInsuranceLabel.Location = new System.Drawing.Point(54, 125);
            this.LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            this.LifeInsuranceLabel.Size = new System.Drawing.Size(193, 31);
            this.LifeInsuranceLabel.TabIndex = 6;
            this.LifeInsuranceLabel.Text = "Life Insurance:";
            // 
            // HealthInsuranceTextBox
            // 
            this.HealthInsuranceTextBox.Location = new System.Drawing.Point(261, 68);
            this.HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            this.HealthInsuranceTextBox.Size = new System.Drawing.Size(237, 38);
            this.HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            this.HealthInsuranceLabel.AutoSize = true;
            this.HealthInsuranceLabel.Location = new System.Drawing.Point(12, 75);
            this.HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            this.HealthInsuranceLabel.Size = new System.Drawing.Size(235, 31);
            this.HealthInsuranceLabel.TabIndex = 4;
            this.HealthInsuranceLabel.Text = "Health Insurance :";
            // 
            // VacationDaysTextBox
            // 
            this.VacationDaysTextBox.Location = new System.Drawing.Point(261, 180);
            this.VacationDaysTextBox.Name = "VacationDaysTextBox";
            this.VacationDaysTextBox.Size = new System.Drawing.Size(237, 38);
            this.VacationDaysTextBox.TabIndex = 2;
            // 
            // VacationLabel
            // 
            this.VacationLabel.AutoSize = true;
            this.VacationLabel.Location = new System.Drawing.Point(49, 187);
            this.VacationLabel.Name = "VacationLabel";
            this.VacationLabel.Size = new System.Drawing.Size(198, 31);
            this.VacationLabel.TabIndex = 2;
            this.VacationLabel.Text = "Vacation Days:";
            // 
            // EmployeeTypeLabel
            // 
            this.EmployeeTypeLabel.AutoSize = true;
            this.EmployeeTypeLabel.Location = new System.Drawing.Point(43, 348);
            this.EmployeeTypeLabel.Name = "EmployeeTypeLabel";
            this.EmployeeTypeLabel.Size = new System.Drawing.Size(210, 31);
            this.EmployeeTypeLabel.TabIndex = 7;
            this.EmployeeTypeLabel.Text = "Employee Type:";
            // 
            // HourlyRadioRadioButton
            // 
            this.HourlyRadioRadioButton.AutoSize = true;
            this.HourlyRadioRadioButton.Location = new System.Drawing.Point(273, 346);
            this.HourlyRadioRadioButton.Name = "HourlyRadioRadioButton";
            this.HourlyRadioRadioButton.Size = new System.Drawing.Size(111, 35);
            this.HourlyRadioRadioButton.TabIndex = 5;
            this.HourlyRadioRadioButton.TabStop = true;
            this.HourlyRadioRadioButton.Text = "Hourly";
            this.HourlyRadioRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(402, 346);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(109, 35);
            this.SalaryRadioButton.TabIndex = 6;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // HoursWorkedTextbox
            // 
            this.HoursWorkedTextbox.Location = new System.Drawing.Point(227, 489);
            this.HoursWorkedTextbox.Name = "HoursWorkedTextbox";
            this.HoursWorkedTextbox.Size = new System.Drawing.Size(357, 38);
            this.HoursWorkedTextbox.TabIndex = 8;
            this.HoursWorkedTextbox.Visible = false;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(12, 496);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(195, 31);
            this.HoursWorkedLabel.TabIndex = 13;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            this.HoursWorkedLabel.Visible = false;
            // 
            // HourlyRateTextbox
            // 
            this.HourlyRateTextbox.Location = new System.Drawing.Point(227, 429);
            this.HourlyRateTextbox.Name = "HourlyRateTextbox";
            this.HourlyRateTextbox.Size = new System.Drawing.Size(357, 38);
            this.HourlyRateTextbox.TabIndex = 9;
            this.HourlyRateTextbox.Visible = false;
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(37, 436);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(166, 31);
            this.HourlyRateLabel.TabIndex = 11;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            this.HourlyRateLabel.Visible = false;
            // 
            // Salarytextbox
            // 
            this.Salarytextbox.Location = new System.Drawing.Point(227, 431);
            this.Salarytextbox.Name = "Salarytextbox";
            this.Salarytextbox.Size = new System.Drawing.Size(357, 38);
            this.Salarytextbox.TabIndex = 7;
            this.Salarytextbox.Visible = false;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(104, 438);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(99, 31);
            this.SalaryLabel.TabIndex = 15;
            this.SalaryLabel.Text = "Salary:";
            this.SalaryLabel.Visible = false;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 643);
            this.Controls.Add(this.Salarytextbox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.HoursWorkedTextbox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.HourlyRateTextbox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioRadioButton);
            this.Controls.Add(this.EmployeeTypeLabel);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SSNLabel;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.GroupBox BenefitsGroupBox;
        public System.Windows.Forms.TextBox LifeInsuranceTextBox;
        private System.Windows.Forms.Label LifeInsuranceLabel;
        public System.Windows.Forms.TextBox HealthInsuranceTextBox;
        private System.Windows.Forms.Label HealthInsuranceLabel;
        public System.Windows.Forms.TextBox VacationDaysTextBox;
        private System.Windows.Forms.Label VacationLabel;
        public System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label EmployeeTypeLabel;
        public System.Windows.Forms.TextBox HoursWorkedTextbox;
        public System.Windows.Forms.TextBox HourlyRateTextbox;
        public System.Windows.Forms.TextBox Salarytextbox;
        public System.Windows.Forms.RadioButton HourlyRadioRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
        public System.Windows.Forms.Label HoursWorkedLabel;
        public System.Windows.Forms.Label HourlyRateLabel;
        public System.Windows.Forms.Label SalaryLabel;
    }
}