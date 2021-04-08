using System;
using System.Threading.Tasks;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Parsing the words which see a user in inputed url.
	/// </summary>
	public static class ParsingController
	{
		/// <summary>
		/// Starting process.
		/// </summary>
		/// <param name="url">url which need a parse</param>
		public static void Start(string url)
		{
			var htmltext = GetHtmlTextThroughRequest.Start(url);
			var txtFromWebPage = ExtractPlainTextFromHtmlPage.Start(htmltext);
			FileRecorder.Start(txtFromWebPage);
			DisplayCountOfWords.Start();
		}
	}
}
