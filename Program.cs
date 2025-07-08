using System.Collections.Concurrent;

namespace ConsoleApp1;

class Program
{
  static void Main(string[] args)
  {
    Book gulliver = new Book();
    Console.WriteLine(gulliver);
  }
}

class Book
{
  string Title;
  decimal ISBN13;
  string Contents;
  string Author;
  int pageCpunt;
}