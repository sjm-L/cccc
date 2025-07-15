class Program
{

  //1단계 : 보상 인터페이스 만들기
  public interface IReward
  {
    void Describe();
  }
  //2단계 : 다양한 보상 클래스 만들기
  //골드 보상
  public class GoldReward : IReward
  {
    public int Amount { get; set; }
    public void Describe()
    {
      //TODO: 골드 출력
      Console.WriteLine($"{Amount}골드 획득 했습니다.");

    }
  }

  public class ItemReward : IReward
  {
    public string ItemName { get; set; }
    public void Describe()
    {
      //TODO : 아이템 출력
      Console.WriteLine($"{ItemName}아이템을 획득했습니다.");
    }
  }

  //경혐치 보상
  public class XPReward : IReward
  {
    public float XP { get; set; }
    public void Describe()
    {
      //TODO : XP 출력
      Console.WriteLine($"{XP}경험치 획득했습니다.");
    }
  }
  public static void Main(string[] args)
  {
    var GoldReward = new GoldReward
    {
      Amount = 500
    };
    var ItemReward = new ItemReward
    {
      ItemName = "현자의 돌"
    };

    var XPReward = new XPReward
    {
      XP = 25.5f
    };

    Console.WriteLine(GoldReward.Describe);
    Console.WriteLine(ItemReward.Describe);
    Console.WriteLine(XPReward.Describe);
  }
}