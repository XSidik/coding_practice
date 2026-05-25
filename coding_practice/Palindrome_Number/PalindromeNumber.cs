
namespace Palindrome_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = 123;
            string inputString = input.ToString();
            string newinputString = "";

            for(int i = inputString.Length - 1; i >= 0 ; i--)
            {
                newinputString += inputString[i];
            }

            if(inputString == newinputString)
            {
                Console.WriteLine(input + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome number.");
            }
        }
    }
}
