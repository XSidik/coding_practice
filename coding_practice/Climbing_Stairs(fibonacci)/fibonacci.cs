namespace Fibonacci
{
   public class HelloWorld {
    public static void Main(string[] args) {
      int first = 0;
      int second = 1;

      for(int i = 0; i < 10; i++)
      {
          Console.WriteLine(first);
          int temp = first;
          first = second;
          second = temp + first;
      }
    }
  }
}
