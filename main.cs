using System;

class MainClass {
  public static void Main (string[] args) {
    string val3;
		double mb;
		
		Console.WriteLine("Hello, Type the number of MB you want to convert to Bytes");

		val3 = Console.ReadLine();
		mb = Convert.ToInt32(val3);

		Console.WriteLine();
		Console.WriteLine(mb*1000000);
  }
}
