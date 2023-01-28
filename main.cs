using System;

class Program {
  public static void Main () {
    Console.WriteLine("what day is today?");
    //int day =1;
    string day =Console.ReadLine();
    switch (day)
    {
    case "mon" or "monday":
      Console.WriteLine("what will you do?");
      string work1 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work1);
      break;
    case "tue" or "tuesday":
      Console.WriteLine("what will you do?");
      string work2 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work2);
      break;
    case "wed" or "wednesday":
      Console.WriteLine("what will you do?");
      string work3 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work3);
      break;
    case "thur" or "thursday":
      Console.WriteLine("what will you do?");
      string work4 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work4);
      break;
    case "fri" or "friday":
      Console.WriteLine("what will you do?");
      string work5 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work5);
      break;
    case "satur" or "saturday":
      Console.WriteLine("what will you do?");
      string work6 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work6);
      break;
    case "sun" or "sunday":
      Console.WriteLine("what will you do?");
      string work7 =Console.ReadLine();
      Console.Write("today you need to do ");
      Console.WriteLine(work7);
      break;
    }
  }
}

