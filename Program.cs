class Program
{
  public class Quset<T>
  {
    public string Title { get; set; }
    public T Reward { get; set; }

    public void ShowReward()
    {
      Console.WriteLine($"퀘스트'{Title}'의 보상: {Reward}");
    }
  }
  static void Main(string[] args)
  {
    var goldQuest = new Quset<int> { Title = "도전 소탕", Reward = 1000 };
    var itemQuest = new Quset<string> { Title = "마법서 찾기", Reward = "마법서" };
    //순서 변경 해도 되는 듯 
    var xpQuest = new Quset<float> { Reward = 25.5f, Title = "경험치 상승률" };

    goldQuest.ShowReward();
    itemQuest.ShowReward();
    xpQuest.ShowReward();
  }
}