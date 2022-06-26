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
	public static class TextController
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="InputtedText">entered text</param>
		public static void DisplayCountOfWords()
		{
			var path = @"C:\WebPageText.txt";
			var listOfWords = File.ReadLines(path);
			var stringbuilder = new StringBuilder();
			foreach (var item in listOfWords)
			{
				stringbuilder.Append(item);
			}
			var words = stringbuilder.ToString();
			var dc = CountWords(words);
			var kek = from i in dc orderby i.Value ascending select i;
			foreach (var kvp in kek)
			{
				Console.WriteLine($"{kvp.Key}-{kvp.Value}");
			}
		}
		/// <summary>
		/// Counting words
		/// </summary>
		/// <param name="inputText">inputted text</param>
		/// <returns></returns>
		public static Dictionary<string, int> CountWords(string inputText)
		{

			var list = inputText.Split(' ').ToList();
			var dictionary = new Dictionary<string, int>();
			foreach (string word in list)
			{
				if (dictionary.ContainsKey(word))
				{
					dictionary[word]++;
				}
				else
				{
					dictionary.Add(word, 1);
				}
			}
			return dictionary;
		}
	}
}
