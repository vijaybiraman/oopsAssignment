using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noOfdays;
        private double ratePerday;
        
        public int NoOfDays
        {
            set { noOfdays = value; }
            get { return noOfdays; }
        }

        public double RatePerDay
        {
            set { ratePerday = value; }
            get { return ratePerday; }
        }

        public Trainee()
        {

        }
        public Trainee(String name, string address, int noOfdays, double ratePerday) : base(name,address)
        {
            this.noOfdays = noOfdays;
            this.ratePerday = ratePerday;
        }

        public override double CalculateSalary()
        {
            return noOfdays * ratePerday;
        }

        public override string ToString()
        {
            return string.Format($"Empno: {Empno}, name : {Name}, address : {Address}, noofdays : {noOfdays}, rateperday : {ratePerday}");
        }
    }
}
