using NewTask.Models;
using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        { double number = 0;
         
            Console.WriteLine("1.Square" +
                "2.Rectangular" +
                "0.Quit");
                do
            {
                if (number==1)
                {

                    double side = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(side);
                    Console.WriteLine(square.CalcArea());
                }
                else if (number==2)
                {
                    double width = Convert.ToDouble(Console.ReadLine());
                    double length = Convert.ToDouble(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(width, length);
                    Console.WriteLine(rectangular.CalcArea());
                    else if (number==0)
                    {
                        Environment.Exit(0)
                    }
                
                
                

            } while (true);

         
            
            }
                }
}
