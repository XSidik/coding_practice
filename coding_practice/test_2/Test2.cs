
namespace Test2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // soal
            int input = 4;
            for(int i = input; i > 0; i--)
            {
                for(int j = input; j > 0; j--)
                {
                    for(int k = 0; k < i; k++)
                    {
                        Console.Write(j);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // soal 2
            int input2 = 4;
            for(int i = 1; i <= input2; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for(int i = input2 - 1; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            for(int i = 1; i <= input2; i++)
            {
                for(int k = input2 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for(int i = input2 - 1; i > 0; i--)
            {
                for(int k = input2 - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }
    }
}