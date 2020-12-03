using System;

namespace EmployeeWage
{
    class Program
    {	
        static void Main(string[] args)
        {	
	    
	    Console.WriteLine("Welcome To Employee Wage Computation");

	    //UC9_Compute Employee Wages and save totalWages by company
            EmpWageBuilderObj dmart = new EmpWageBuilderObj("Dmart", 20, 2, 10);
            EmpWageBuilderObj reliance = new EmpWageBuilderObj("Reliance", 20, 2, 10);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            
        }  	              
     }
}
