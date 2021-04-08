using System.Collections.Generic;
using System.Linq;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Counts words in text
	/// </summary>
	public static class CounterOfWordsInText
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="inputText">entered text</param>
		/// <returns></returns>
		public static Dictionary<string, int> Start(string inputText)
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
