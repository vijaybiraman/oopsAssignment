using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRAPP
{
    public class Program 
    {
        static void Main(string[] args)
        {
            
            Program program = new Program();

            try
            {
                List<ConfirmEmployee> list = new List<ConfirmEmployee>();
               list.Add(new ConfirmEmployee("Monu", "mumbai", 50000.0, "dev"));
               list.Add(new ConfirmEmployee("gonu", "Delhi", 50000.0, "dev"));

               ConfirmEmployee confirmEmployee = new ConfirmEmployee("Sushant", "pune", 30000.0, "manager");
                Console.WriteLine(confirmEmployee.ToString());
               Console.WriteLine("netSalary :" + confirmEmployee.CalculateSalary());

                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }
            catch(SalaryOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
             List<Trainee> list1 = new List<Trainee>();
            list1.Add(new Trainee("Monu", "mumbai", 30, 2000));
            list1.Add(new Trainee("gonu", "Delhi", 20, 3000));
            Trainee trainee = new Trainee("Kamlesh","Mumbai",30,1000.0);
            Console.WriteLine(trainee.ToString());
            Console.WriteLine("salary :"+trainee.CalculateSalary());
            foreach (var i in list1)
            {
                Console.WriteLine(i);
            }


          
            List<Employee> list5 = new List<Employee>();
           list5.Add(new ConfirmEmployee("sushant","pune",50000,"manager"));
            list5.Add(new Trainee("Roshant", "satara", 3, 50000));
            list5.Add(new ConfirmEmployee("pratham", "pune", 60000, "manager"));
            
            Console.WriteLine("Do you continue the program");
            string ans = Console.ReadLine();
            while(ans=="Y")
            {
                Console.WriteLine("1.Display All Employees");
                Console.WriteLine("2.Insert Confirm Employee");
                Console.WriteLine("3.Insert Trainee");
                Console.WriteLine("4.Delete Employee by no");
                Console.WriteLine("5.Display Employee by No");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice==1)
                {
                    try
                    {
                        foreach (var i in list5)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    catch (SalaryOutOfRangeException ex1)
                     {
                        Console.WriteLine(ex1.Message);
                     }
                    Program.Choice();
                }
                if (choice == 2)
                {
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter address");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter designation");
                        string designation = Console.ReadLine();
                        Console.WriteLine("Enter salary>5000");
                        int salary = Convert.ToInt32(Console.ReadLine());
                       ConfirmEmployee confirmEmployee = new ConfirmEmployee();
                        int Empno=0;
                       int i= Employee.ReturnEmpno(Empno);
                        confirmEmployee.Empno = i;
                        confirmEmployee.Address = address;
                        confirmEmployee.Name = name;
                        confirmEmployee.Designation = designation;
                        confirmEmployee.Basicsalary = salary;
                        
                        list5.Add(confirmEmployee);
                    Program.Choice();
                }
                if (choice == 3)
                {
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter address");
                    string address = Console.ReadLine();
                    Console.WriteLine("no of days");
                    int noOfdays = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("rate per day");
                    int Rateperday = Convert.ToInt32(Console.ReadLine());

                    Trainee trainee1 = new Trainee();
                    int Empno = 0;
                    int i = Employee.ReturnEmpno(Empno);
                    trainee1.Empno = i;
                    trainee1.Name = name;
                    trainee1.Address = address;
                    trainee1.NoOfDays= noOfdays;
                    trainee1.RatePerDay = Rateperday;

                    list5.Add(trainee1);
                    Program.Choice();
                }
                if (choice == 4)
                {
                    Console.WriteLine("Enter your number");
                    int num = Convert.ToInt32(Console.ReadLine());

                    int count = 0;
                    foreach (var j in list5)
                    {
                        if (num == j.Empno)
                        {
                            list5.Remove(j);
                            count++;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Record not found");
                    }
                    Program.Choice();
                }
                if (choice == 5)
                {
                    Console.WriteLine("Enter your number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int count = 0;
                    foreach(var j in list5)
                    {
                       if(num==j.Empno)
                        {
                            Console.WriteLine(j);
                            count++;
                        }
                    }    
                    if(count==0)
                    {
                        Console.WriteLine("Record not found");
                    }
                    Program.Choice();
                }
            }
            Console.ReadLine();
        }      

        public static void Choice()
        {
            Console.WriteLine("Do you want continue the program");
            String ans = Console.ReadLine();
        }
    }
}
