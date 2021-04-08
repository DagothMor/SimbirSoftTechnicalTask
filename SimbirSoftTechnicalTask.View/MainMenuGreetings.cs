using SimbirSoftTechnicalTask.Controller;
using System;


namespace SimbirSoftTechnicalTask.View
{
	/// <summary>
	/// Console view to interact with the user.
	/// </summary>
	public static class MainMenuGreetings
	{
		/// <summary>
		/// Main menu in application.
		/// </summary>
		public static void MainMenu()
		{
			while (true)
			{
				Greetings();
				var input = Console.ReadLine();
				if (InputController.CheckForNullEmptyOrWhiteSpace(input))
				{
					continue;
				}
				if (input.ToLower() == "exit")
				{
					Environment.Exit(0);
				}
				else if (input == "start")
				{
					Console.Clear();
					StartParsing.Start();
					Console.WriteLine("Exit application?y/n");
					input = Console.ReadLine();
					if (input.ToLower() == "y")
					{
						Environment.Exit(0);
					}
					else
					{
						Console.Clear();
						continue;
					}
				}
			}
		}
		/// <summary>
		/// Enter the greetings text.
		/// </summary>
		private static void Greetings()
		{
			Console.WriteLine($"Welcome {Environment.UserName} to the SiteWordsParser!");
			Console.WriteLine("You are in main menu!" + Environment.NewLine + "Enter the:" + Environment.NewLine +
				"start - to start parsing");
			Console.WriteLine(
				"exit - exit from application");
			Console.WriteLine();
		}
	}

}
