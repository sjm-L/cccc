class Program
{
  public class Player
  {
    private int _gold;
    public int Gold
    {
      set { _gold = value; }
    }

    public void ShowGold()
    {
      Console.WriteLine($"Gold: {_gold}");
    }
  }

  public static void Main(string[] args)
  {
    Player P = new Player();
    P.Gold = 500; //값 설정
    P.ShowGold();
    //Console.WriteLine(P.Gold); //에러
  }
}