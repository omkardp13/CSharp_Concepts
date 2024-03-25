class Student
{

  public string name{get;set;}
  public int age{get;set;}

  public PrintInfo()
  {
    Console.WriteLine($"Name:{name}, Age:{age}");
  }
}