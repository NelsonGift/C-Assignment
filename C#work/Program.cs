namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 6;
            int[] negatives = new int[length];
            Console.WriteLine("Enter negative numbers between -20 and -15");
            for (int i = 0; i<length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= -20 && num <= -15)
                {
                    negatives[i] = num;
                }
                else
                {
                    Console.WriteLine("{0} has been skipped", num);
                    i-=1;
                }
            }
            Console.WriteLine("Negative numbers are [{0}]", string.Join(", ", negatives));
            int[] reversedArr = new int[length];
            for (int l = negatives.Length-1; l>=0; l--)
            {
                string formatter = ",";
                if (l == 0)
                {
                    formatter = "";
                }
                Console.Write(negatives[l]+ ""+ formatter);
            }
        }
    }
}