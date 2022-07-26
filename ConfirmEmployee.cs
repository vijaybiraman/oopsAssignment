using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private double basicsalary;
        private string designation;
        
        public double Basicsalary
        {
            set { basicsalary = value; }
            get { return basicsalary; }
        }

        public string Designation
        {
            set { designation = value; }
            get { return designation; }
        }
        public ConfirmEmployee()
        {

        }
        public ConfirmEmployee(string name, string address, double basicsalary, string designation) : base(name,address)
        {
         
            this.basicsalary = basicsalary;
            this.designation = designation;
        }

        public override double CalculateSalary()
        {
            if(basicsalary>=30000)
            {
                return basicsalary + (basicsalary * 30 / 100) + (basicsalary * 30 / 100) - (basicsalary * 10 / 100);
            }
            else if(basicsalary>=20000)
            {
                return basicsalary + (basicsalary * 20 / 100) + (basicsalary * 20 / 100) - (basicsalary * 10 / 100);
            }
            else
            {
                return basicsalary + (basicsalary * 10 / 100) + (basicsalary * 10 / 100) - (basicsalary * 10 / 100);
            }
        }  
        public override string ToString()
        {
            if (basicsalary < 5000)
            {
                throw new SalaryOutOfRangeException("Your salary below 5000 please enter salary above 5000");
            }
            else
            {
                return string.Format($"Empno : {Empno}, name : {Name}, address : {Address}, Salary : {Basicsalary}, Designation : {Designation}");
            }
        }
    }

    public class SalaryOutOfRangeException : Exception
    {
       public SalaryOutOfRangeException(String msg) : base(msg)
        {

        }
    }
}
