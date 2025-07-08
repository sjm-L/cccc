using System.Collections.Concurrent;

namespace ConsoleApp1;

class Program
{
  static void Main()
  {
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

    var evenNumbers = numbers.Where(n => n % 2 == 0);

    foreach (var num in evenNumbers)
    {
      Console.WriteLine(num);
    }
  }
}
