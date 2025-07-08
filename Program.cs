using System.Collections.Concurrent;

namespace ConsoleApp1;

class Program
{
  static void Main()
  {
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    //<> 제네릭 넣을 필요가 있는지?
    var evenNumbers = numbers.Where(n => n % 2 == 0);
    //n => n % 2 == 0 는 n은 2로 나누어서 나머지가 0이 나오는 리스트 저장 
    foreach (var num in evenNumbers)
    //foreach 이건 모르겠지만 var num형을 만들고 거기다가 evnNumers을 저장 
    //foreach은 컬랙션 요소를 하나식 꺼낼 때 ex: 리스트, 배여르 딕션너리
    {
      Console.WriteLine(num);
    }
  }
}
