class Program
{
  public class Quest<T>
  {
    public string Title { get; set; }
    public T Reward { get; set; }

    public void ShowReward()
    {
      Console.WriteLine($"퀘스트 '{Title}'의 보상 : {Reward}");
    }
  }

  public static void Main(string[] args)
  {
    var goldQuest = new Quest<int> { Title = "도적 소탕", Reward = 1000 };
    var itemQuest = new Quest<string> { Title = "마법서 찾기", Reward = "마법서" };
    var xpQuest = new Quest<float> { Title = "훈현 참여", Reward = 25.25F };

    goldQuest.ShowReward();
    itemQuest.ShowReward();
    xpQuest.ShowReward();
  }
}