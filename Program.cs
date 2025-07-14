public class Box<T>
{
  private T item;
  public void Add(T value) => item = value;
  public T Get() => item;
}

public class Program
{
  static void Main()
  {
    var box = new Box<int>();
    box.Add(10);
    string s = box.Get(); // 
}