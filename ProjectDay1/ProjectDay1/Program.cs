using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_day
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Project 1
            //A given company has name, address, phone number, fax number, 
            //web site and manager. The manager has name, surname and phone number. 
            //Write a program that reads information about the company and its manager 
            //and then prints it on the console.

            //Ask info;  Assign info to string variables;
            //Company info;
            Console.WriteLine("What is your company name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your company address?");
            string address = Console.ReadLine();
            Console.WriteLine("What is your company phone number?");
            string phone = Console.ReadLine();
            Console.WriteLine("What is your company fax?");
            string fax = Console.ReadLine();
            Console.WriteLine("What is your company website?");
            string site = Console.ReadLine();
            //Manager info;
            Console.WriteLine("What is your manager's first name?");
            string mname = Console.ReadLine();
            Console.WriteLine("What is your manager's last name?");
            string msurname = Console.ReadLine();
            Console.WriteLine("What is your manager's phone number?");
            string mphone = Console.ReadLine();

            //Print info; use + to concatenate "text" + variables;
            Console.WriteLine("The company name is: " + name);
            Console.WriteLine("The company address is: " + address);
            Console.WriteLine("The company phone is: " + phone);
            Console.WriteLine("The company fax is: " + fax);
            Console.WriteLine("The company website is: " + site);
            Console.WriteLine("The company manager is: " + mname + " " + msurname);
            Console.WriteLine("The manager's phone number is: " + mphone);*/


            //Project 2
            //Write a program that reads five integer numbers from the console and prints their sum.

            //Input
            /*Console.WriteLine("Gimme some whole numbers! Five, to be exact.");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            string number3 = Console.ReadLine();
            string number4 = Console.ReadLine();
            string number5 = Console.ReadLine();
            Console.WriteLine("Stop now!");

            int a = Convert.ToInt32(number1);
            int b = Convert.ToInt32(number2);
            int c = Convert.ToInt32(number3);
            int d = Convert.ToInt32(number4);
            int e = Convert.ToInt32(number5);

            Console.Write("And the sum is: ");
            Console.Write(a + b + c + d + e);*/


            /*
            //Project 3
            //Write a program that reads from the console 
            //the radius "r" of a circle and prints its perimeter and area.

            //Input
            Console.WriteLine("What is the radius?");
            string radius = Console.ReadLine();
            int r = Convert.ToInt32(radius);

            //Calculate Perimeter and Area
            double p = Math.PI * 2 * r;
            double a = Math.PI * r * r;

            //Output P and A
            Console.WriteLine("Perimeter: " + p);
            Console.WriteLine("Area: " + a);
            */


            /*
            //Project 4
            //Write a program that writes to the console "Welcome to We Can Code IT".  
            //The quotation marks should be displayed on the console.  
            //(Hint: look up Escaping Characters)

            Console.WriteLine("\"We Can Code IT\"");
            */


            /*
            //Project 5
            //From problem 1 above, write a program that will print the manager's information.  
            //This time format the text so that each column is 
            //20 characters wide and the phone number is right aligned.  
            //(Hint: Check out the "Composite Formatting" section of Chapter 4 in the online book)

            //Manager info;
            Console.WriteLine("What is your manager's first name?");
            string mname = Console.ReadLine();
            Console.WriteLine("What is your manager's last name?");
            string msurname = Console.ReadLine();
            Console.WriteLine("What is your manager's phone number?");
            string mphone = Console.ReadLine();

            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Manager Name", "Last Name", "Phone Number");
            Console.WriteLine("{0,-20} {1,-20} {2,20}", mname, msurname, mphone);
            */
            

            
            Console.ReadKey();
        }
    }
}
