using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Random rand = new Random();
            //int a, b, c;
            //a = rand.Next(100);
            //b = rand.Next(100);
            //c = rand.Next(100);
            //Console.WriteLine("{0}  {1}   {2}", a,b,c);
            //Console.ReadLine();

            //2
            //Random rand = new Random();
            //int a, b, c;
            //a = rand.Next(100);
            //b = rand.Next(100);
            //c = rand.Next(100);
            //Console.WriteLine(a + "\n" + b + "\n" + c);
            //Console.ReadLine();

            //3
            //Console.WriteLine("centimeter");
            //int cm = Int32.Parse(Console.ReadLine());
            //int m = (int)(cm * 0.001);
            //Console.WriteLine("m = " + m);
            //Console.ReadLine();

            //4
            //int Week = 7;
            //int Days = 234;
            //int DaysWeek = Days / Week;
            //Console.WriteLine("Weeks = " + DaysWeek);
            //Console.ReadLine();

            //5
            //Random rand = new Random();
            //int Number;
            //Number = rand.Next(100);
            //int Tens = Number / 10;
            //int Units = Number % 10;
            //int Sum = Number + Units;
            //int Composition = Tens * Units;
            //Console.WriteLine(" Number = {0}  Tens = {1}  Units = {2}  Sum = {3}  Composition = {4}", Number, Tens, Units, Sum, Composition);
            //Console.ReadLine();


            
            bool A = true;
            bool B = false;
            bool C = false;

            bool res1 = A || B;
            bool res2 = A && B;
            bool res3 = B || C;

            Console.WriteLine("A || B = " + res1);
            Console.WriteLine("A && B = " + res2);
            Console.WriteLine("B || C = " + res3);

            Console.ReadLine();





        }
    }
}
