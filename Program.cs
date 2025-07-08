// 1. List<string> fruits = new List<string> { "apple", "banana", "cherry" }; 에서 "a"로 시작하는 과일만 필터링하려면 어떻게 해야 할까?

namespace ConsoleApp1;

class Program
{
  static void Main()
  {
    List<string> fruits = new List<string> { "apple", "banana", "cherry" };
    var a = fruits.Where(fruits => fruits.StartsWith("a")).ToList();

    foreach (var fruit in a)
      {
        Console.WriteLine(fruit);
      }
  }
}