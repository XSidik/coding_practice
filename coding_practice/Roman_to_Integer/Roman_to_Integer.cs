
namespace Roman_to_Integer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int,string> romanNumerals = new Dictionary<int,string>()
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},
                {10, "X"}
            };

            string input = "X";

            for(int i = 1; i <= romanNumerals.Count; i++)
            {
                if(romanNumerals[i] == input)
                {
                    Console.WriteLine($"angka dari romawi {input} adalah {i}");
                }
            }
        }
    }
}
