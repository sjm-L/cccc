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
    string s = box.Get(); // 컴팡일에러가 에러가남 객체를 생성할때 int로 만들었는데 string으롬 만들려고 하니깐 컴파일 에러가 생기는 것 같습니다.
}