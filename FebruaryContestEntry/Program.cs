using System;

namespace FebruaryContestEntry
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			
			var rectangle = new Rectangle();
			rectangle
				.Width(15)
				.Height(30)
				.BuildRectangle()
				.FillRectangle()
				.ShowRectangleColor();

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
