using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
	    Console.WriteLine("Welcome To Employee Wage Computation");
	    int isFullTime = 1;
            int isPartTime = 2;
            Random rand = new Random();
            int rn = rand.Next(1, 3);
            if (isFullTime == 1)
                Console.WriteLine("Employee Is presnet FullTime");
            else if (isPartTime == 2)
                Console.WriteLine("Employee Is present PartTime");
            else
                Console.WriteLine("Employee Absent.!!!");
        }  
    }
}
