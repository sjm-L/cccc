using System.Reflection;

class Program
{
  public class ComplexQuest 
  {
    public int Gold { get; set; }
    public string Item { get; set; }
    public float XP { get; set; }
  }

  public class Quest<T>
  {
    public string Title { get; set; }
    public T Reward { get; set; }
  }


  public static void Main(string[] args)
  {
    var comlexQuest = new Quest<ComplexQuest>
    {
      Title = "고블린 왕 처치",
      Reward = new ComplexQuest
      {
        Gold = 100,
        Item = "전설의 검",
        XP = 250.5f
      }
    };
  }
}