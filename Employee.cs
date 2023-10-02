using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantiagoEchevarria_CourseProject_Part2
{
    [Serializable]
    public abstract  class Employee
    {
        private string firsName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits;

        public Employee()
        {
            firsName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hireDate = new DateTime();
            benefits = new Benefits();
        }

        public Employee(string firsName, string lastName, string ssn, DateTime hireDate,Benefits benefits)
        {
            this.firsName = firsName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            this.benefits = benefits;
        }

        public override string ToString()
        {
            return "firstName=" + firsName + ", lastName=" + lastName
                  + ", ssn=" + ssn + ", hireDate=" + hireDate.ToShortDateString()
                  + ", healthIns=" + benefits.HealthInsurance
                  + ", lifeIns=" + benefits.LifeInsurance
                  + ", vacation=" + benefits.Vacation;
        }

        public abstract double CalculatePay();
      

        public string FirstName
        {
            get { return firsName; }
            set { firsName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Benefits BenefitsEmp
        {
            get { return benefits; }
            set { benefits = value; }

        }
    }
}
