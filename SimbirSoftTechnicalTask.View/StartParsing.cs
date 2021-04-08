using SimbirSoftTechnicalTask.Controller;
using System;
using System.Threading.Tasks;

namespace SimbirSoftTechnicalTask.View
{
	/// <summary>
	/// Gets url from console,parsing and display to the console.
	/// </summary>
	public static class StartParsing
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <returns></returns>
		public static void Start()
		{
			var stringinput = "";
			while (true)
			{
				try
				{
					Console.WriteLine("Enter the url");
					stringinput = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(stringinput) && string.IsNullOrEmpty(stringinput))
					{
						throw new ArgumentException("input string is null or empty");
					}
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					Console.ReadLine();
					Console.Clear();
				}
			}
			ParsingController.Start(stringinput); 
		}
	}
}
