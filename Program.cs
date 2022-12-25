namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int an, ax;

            Console.Write("Find the perfect number between two numbers:\n");

            Console.Write("\n\n");

            Console.Write("Enter First Number : ");
            an = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("The perfect number between the two numbers is : ");
            for (n = an; n <= ax; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");

        }
    }
}