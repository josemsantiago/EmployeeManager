using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantiagoEchevarria_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Hide();
        }

        private void HourlyRadioRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HourlyRadioRadioButton.Checked)
            {
                SalaryLabel.Visible = false;
                Salarytextbox.Visible = false;

                HourlyRateTextbox.Visible = true;
                HourlyRateLabel.Visible = true;
                HoursWorkedLabel.Visible = true;
                HoursWorkedTextbox.Visible = true;

            }
        }

        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SalaryRadioButton.Checked)
            {
                SalaryLabel.Visible = true;
                Salarytextbox.Visible = true;

                HourlyRateTextbox.Visible = false;
                HourlyRateLabel.Visible = false;
                HoursWorkedLabel.Visible = false;
                HoursWorkedTextbox.Visible = false;

            }
        }
    }
}
