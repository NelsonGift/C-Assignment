using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter number of odd numbers between 7 amd 15");
            int odd = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum=0;
            Console.WriteLine("The odd numbers are:");
            for (i=7; i<=15; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                
            }
            
            Console.WriteLine("Their sum is:"+ sum);

           
           
        }
    }
}