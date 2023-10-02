using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SantiagoEchevarria_CourseProject_Part2
{
    public partial class Form1 : Form
    {
        private const string FILENAME = "employee.dat";

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InputForm frmInput = new InputForm();
            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;
                string fName = frmInput.FirstNameTextBox.Text.Trim();
                string lname = frmInput.LastNameTextBox.Text.Trim();
                string ssn = frmInput.SSNTextBox.Text.Trim();
                string date = frmInput.HireDateTextBox.Text.Trim();
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text.Trim();
                int lifeInns = int.Parse(frmInput.LifeInsuranceTextBox.Text.Trim());
                int vacation = int.Parse(frmInput.VacationDaysTextBox.Text.Trim());

                Benefits ben = new Benefits(healthIns, lifeInns, vacation);
                Employee emp = null;

                if (frmInput.SalaryRadioButton.Checked)
                {
                    double salary = double.Parse(frmInput.Salarytextbox.Text.Trim());
                    emp = new Salary(fName, lname, ssn, hireDate, ben, salary);
                }
                else if (frmInput.HourlyRadioRadioButton.Checked)
                {
                    double hourlyRate = double.Parse(frmInput.HourlyRateTextbox.Text.Trim());
                    double hoursWorked = double.Parse(frmInput.HoursWorkedTextbox.Text.Trim());
                    emp = new Hourly(fName, lname, ssn, hireDate, ben, hourlyRate, hoursWorked);
                }
                else
                {
                    MessageBox.Show("Error. Please select an employee type");
                    return;
                }

                EmployeeListBox.Items.Add(emp);

                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            List <Employee> empList = new List<Employee>();
            foreach(Employee emp in EmployeeListBox.Items)
            {
                empList.Add(emp);
            }

            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, empList);
            fs.Close();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int itemNumber = EmployeeListBox.SelectedIndex;
            if (itemNumber > -1)
            {
                EmployeeListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            EmployeeListBox.Items.Clear();

            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();   
                List<Employee> list = (List<Employee>)formatter.Deserialize(fs);
                fs.Close();

                EmployeeListBox.Items.Clear();
                foreach (Employee emp in list)
                    EmployeeListBox.Items.Add(emp);
            }

        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            foreach ( Employee emp in EmployeeListBox.Items)
            {
                string line1 = "Pay To: " + emp.FirstName + " " + emp.LastName;
                string line2 = "Amount Of: " + emp.CalculatePay().ToString("C2");
                string output = "Paycheck:\n\n" + line1 + "\n" + line2;

                MessageBox.Show(output);
            }
        }

        private void EmployeeListBox_DoubleClick(object sender, EventArgs e)
        {
            Employee emp = EmployeeListBox.SelectedItem as Employee;

            InputForm frmupdate = new InputForm();
            frmupdate.FirstNameTextBox.Text = emp.FirstName;
            frmupdate.LastNameTextBox.Text = emp.LastName;
            frmupdate.SSNTextBox.Text = emp.SSN;
            frmupdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
            frmupdate.HealthInsuranceTextBox.Text = emp.BenefitsEmp.HealthInsurance;
            frmupdate.LifeInsuranceTextBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
            frmupdate.VacationDaysTextBox.Text = emp.BenefitsEmp.Vacation.ToString();

            if (emp is Salary)
            {
                frmupdate.HourlyRateLabel.Visible = false;
                frmupdate.HourlyRateTextbox.Visible = false;
                frmupdate.HoursWorkedLabel.Visible = false;
                frmupdate.HoursWorkedTextbox.Visible = false;
                frmupdate.SalaryLabel.Visible = true;
                frmupdate.Salarytextbox.Visible = true;
                frmupdate.SalaryRadioButton.Checked = true;

                Salary sal = (Salary)emp;

                frmupdate.Salarytextbox.Text = sal.AnnualSalary.ToString("F2");
            }
            else if (emp is Hourly)
            {
                frmupdate.HourlyRateLabel.Visible = true;
                frmupdate.HourlyRateTextbox.Visible = true;
                frmupdate.HoursWorkedLabel.Visible = true;
                frmupdate.HoursWorkedTextbox.Visible = true;
                frmupdate.SalaryLabel.Visible = false;
                frmupdate.Salarytextbox.Visible = false;

                frmupdate.HourlyRadioRadioButton.Checked = true;

                Hourly hrly = (Hourly)emp;

                frmupdate.HoursWorkedTextbox.Text = hrly.HoursWorked.ToString("F2");
                frmupdate.HourlyRateTextbox.Text = hrly.HourlyRate.ToString("F2");
            }
            else
            {
                MessageBox.Show("Error. Invalid employee type found.");
                return;
            }

            DialogResult result = frmupdate.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            int position = EmployeeListBox.SelectedIndex;
            EmployeeListBox.Items.RemoveAt(position);

            Employee newEmp = null;
            string fname = frmupdate.FirstNameTextBox.Text;
            string lname = frmupdate.LastNameTextBox.Text;
            string ssn = frmupdate.SSNTextBox.Text;
            DateTime hireDate = DateTime.Parse(frmupdate.HireDateTextBox.Text);
            string healthInsurance = frmupdate.HealthInsuranceTextBox.Text;
            int lifeInsurance = int.Parse(frmupdate.LifeInsuranceTextBox.Text);
            int vacation = int.Parse(frmupdate.VacationDaysTextBox.Text);

            Benefits ben = new Benefits(healthInsurance, lifeInsurance, vacation);

            if (frmupdate.SalaryRadioButton.Checked)
            {
                double salary = double.Parse(frmupdate.Salarytextbox.Text.Trim());
                newEmp = new Salary(fname, lname, ssn, hireDate, ben, salary);
            }
            else if (frmupdate.HourlyRadioRadioButton.Checked)
            {
                double hourlyRate = double.Parse(frmupdate.HourlyRateTextbox.Text.Trim());
                double hoursWorked = double.Parse(frmupdate.HoursWorkedTextbox.Text.Trim());
                newEmp = new Hourly(fname, lname, ssn, hireDate, ben, hourlyRate, hoursWorked);
            }
            else
            {
                MessageBox.Show("Error. Invalid employee type.");
                return;
            }

            EmployeeListBox.Items.Add(newEmp);
        }
    }
}
