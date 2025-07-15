// class Program
// {

//   //1단계 : 보상 인터페이스 만들기
//   public interface IReward
//   {
//     void Describe();
//   }
//   //2단계 : 다양한 보상 클래스 만들기
//   //골드 보상
//   public class GoldReward : IReward
//   {
//     public int Amount { get; set; }
//     public void Describe()
//     {
//       //TODO: 골드 출력
//       Console.WriteLine($"{Amount}골드 획득 했습니다.");

//     }
//   }

//   public class ItemReward : IReward
//   {
//     public string ItemName { get; set; }
//     public void Describe()
//     {
//       //TODO : 아이템 출력
//       Console.WriteLine($"{ItemName}아이템을 획득했습니다.");
//     }
//   }

//   //경혐치 보상
//   public class XPReward : IReward
//   {
//     public float XP { get; set; }
//     public void Describe()
//     {
//       //TODO : XP 출력
//       Console.WriteLine($"{XP}경험치 획득했습니다.");
//     }
//   }
//   public static void Main(string[] args)
//   {
//     var goldReward = new GoldReward
//     {
//       Amount = 500
//     };
//     var itemReward = new ItemReward
//     {
//       ItemName = "현자의 돌"
//     };

//     var xpReward = new XPReward
//     {
//       XP = 25.5f
//     };

//     goldReward.Describe();
//     itemReward.Describe();
//     xpReward.Describe();
//   }
// }



using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    string item_One = "사과";
    string item_two = "우유";
    //string fileName = "shopping.txt";
    // string fileName = "C:\\이것도 만들어지면문제이지\\shopping.txt";
    string fileName = "C:\\Temp\\bad?*/\name.txt";
    // 1. 디렉토리 존재 여부 확인
    Console.WriteLine("실행 전 디렉토리 존재 여부: " + Directory.Exists(fileName));

    string content = "구매할 것들: \n1. " + item_One + "\n2. " + item_two;

    try
    {
      
      File.WriteAllText(fileName, content);
      Console.WriteLine("파일 만들어짐");
    }
    catch (Exception e)
    {
      Console.WriteLine("에러 발생: " + e.Message);
    }
  }
}