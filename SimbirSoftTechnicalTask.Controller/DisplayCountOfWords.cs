using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Displaying count of words
	/// </summary>
	public static class DisplayCountOfWords
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="InputtedText">entered text</param>
		public static void Start()
		{
			var path = @"C:\WebPageText.txt";
			var listOfWords = File.ReadLines(path);
			var stringbuilder = new StringBuilder();
			foreach (var item in listOfWords)
			{
				stringbuilder.Append(item);
			}
			var words = stringbuilder.ToString();
			var dc = CounterOfWordsInText.Start(words);
			var kek = from i in dc orderby i.Value ascending select i;
			foreach (var kvp in kek)
			{
				Console.WriteLine($"{kvp.Key}-{kvp.Value}");
			}
		}
	}
}
