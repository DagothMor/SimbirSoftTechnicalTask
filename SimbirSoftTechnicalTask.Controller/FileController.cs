using System;
using System.IO;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Writes a file on the path
	/// </summary>
	public static class FileController
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="text">Entered text</param>
		public static void Start(string text)
		{
			string writePath = @"C:\WebPageText.txt";
			try
			{
				using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.UTF8))//переписал на ютф8
				{
					sw.WriteLine(text);
				}
				using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))//переписал на ютф8
				{
					sw.WriteLine(text);
				}
				Console.WriteLine("Запись выполнена");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
