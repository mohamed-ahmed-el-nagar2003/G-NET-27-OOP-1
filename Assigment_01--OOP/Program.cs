namespace Assigment_01__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-01
            //Q1 : Explain with code example how class and struct behave differently 
            //Student st01 = new Student("Mohamed ", 20, "Science", "20202020");
            //Student st02 = new Student("Ali ", 40, "Science", "80808080");
            //Student st03 = st01;
            //Console.WriteLine($"{st01.Name}");
            //Console.WriteLine($"{st03.Name}");
            //st03.Name = "Sammer";
            ////st01 will change also Although we change st03
            ////becouse Refrence type 
            //Console.WriteLine($"{st01.Name}");
            //Console.WriteLine($"{st03.Name}");



            //Dimention dim01 = new Dimention(3, 4);
            //Dimention dim02 = dim01;
            //Console.WriteLine($"{dim01.X}");
            //Console.WriteLine($"{dim02.X}");
            //dim02.X = 8;

            ////dim01 will not change also Although we change dim02 becouse Refrence type
            //Console.WriteLine($"{dim01.X}");
            //Console.WriteLine($"{dim02.X}");
            #endregion

            #region Q-02
            //Q2 : Explain the difference between public and private access modifiers with an example. 


            /*
            Private : The member is only accessible within the class or struct it is defined in.
                      It cannot be accessed from outside the class.
                      ------------- but-----------
           Public  : The member is accessible from anywhere in the application,
                     both within the same assembly (project) and from other assemblies.
            */

            // Console.WriteLine($"{st01.Name}");
            //we can print name inside or outside class becouse is Public 
            // but Password we cant't use it outside the class becouse it Private
            #endregion

            #region Q-03
            //Q3 : Describe the steps to create and use a class library in Visual    Studio.
            /*
           1- Create a Class Library project.

            2-  Add public classes and methods.

            3-  Build the library to generate DLL.

            4-  Create another project (e.g., Console App).

          5-   Add reference to the Class Library.

           6-  Use the classes by importing the namespace.

          7-  Create objects and call methods.
            */
            #endregion

            #region Q-04
            // Q4 : What is a class library? Why do we use class libraries?

            //Class Library : is Project contain group of classes to reusable them in any other Projects but don't have console .
            // We use Class Library becouse :
            //orgnization code 
            // reusable code 
            // different developers work on different libraries 
            // help maintenanse project easly
            #endregion

            #region Cinema_System
            //Ticket t1 = new Ticket();
            //Seat s1 = new Seat();
            //Console.Write("Enter Movie Name : ");
            //t1.MovieName = Console.ReadLine();
            //Console.Write("Enter Ticket type (standard = 0 , VIP = 1 , IMAX = 2): ");
            //t1.Type = (TicketType)Enum.Parse(typeof(TicketType), Console.ReadLine());
            //Console.Write("Enter Seat Row (A,B,C,....) : ");
            //s1.Row = Console.ReadLine();
            //Console.Write("Enter Seat Number : ");
            //s1.Number = int.Parse(Console.ReadLine());
            //Console.Write("Enter Discount Amount : ");
            //double discountAmount = double.Parse(Console.ReadLine());

            //t1.seat = s1;

            //t1.PrintTicket();


            //t1.ApplyDiscount(ref discountAmount); 
            #endregion   
        }
    }
}
