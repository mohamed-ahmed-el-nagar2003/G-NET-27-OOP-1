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
        }
    }
}
