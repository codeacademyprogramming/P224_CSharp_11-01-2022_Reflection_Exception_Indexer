using P224Exception.Models;
using System;

namespace P224Exception
{
    class Program
    {
        static void Main(string[] args)
        {


            //try
            //{
            //    int[] arr = { 5, 7, 9 };
            //    Console.WriteLine(arr[99]);
            //    int a = 0;
            //    int b = 5;
            //    Console.WriteLine(b / a);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine(new IndexOutOfRangeException("Daxil Etdiyniz Index Yanlisdir").Message);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine(new DivideByZeroException("Ededi Sifira Bolmek Mumkun Deyil").Message);
            //}
            //finally 
            //{

            //}


            //Students students1 = new Students { Name = "Arif" };
            //Students students2 = new Students { Name = "Akif" };
            //Students students3 = new Students { Name = "Rustem" };

            //Group group = new Group { Name = "P224" };
            //group.StudentsList.Add(students1);
            //group.StudentsList.Add(students2);
            //group.StudentsList.Add(students3);
            //group.FindStudent("test");
            check:
            string str = Console.ReadLine();
            try
            {
                int a = int.Parse(str);
            }
            catch (FormatException)
            {
                Console.WriteLine(new FormatException("Duzgun Daxil Et").Message);
                goto check;
            }
        }
    }
}
