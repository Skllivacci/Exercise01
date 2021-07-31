using System;
using System.Text.RegularExpressions;

namespace Exercise01
{
	class Program
	{
		static void Main(string[] args)
		{
			string regularExpression;
			Regex regexPattern = new Regex(@"^[a-z]+$");

			Console.WriteLine("The default regular expression checks for at least one digit");
			Console.WriteLine("Enter a regular expression (or press ENTER to use the default): ^[a-z]+$");
			Console.Write("Enter some input: ");
			regularExpression = Console.ReadLine();

			if (regexPattern.IsMatch(regularExpression))
			{
				Console.WriteLine(regularExpression + " matches ^[a-z]+$? True");
			}
			else {
				Console.WriteLine(regularExpression + " matches ^[a-z]+$? False");
			}
			
			Console.WriteLine("Press ESC to end or any key to try again");
			Console.ReadKey();
		}
	}
}
