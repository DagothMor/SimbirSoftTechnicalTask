using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Extracting Plain text from Html page
	/// </summary>
	public static class ExtractPlainTextFromHtmlPage
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="htmlPage">text including HtmlPage</param>
		/// <returns></returns>
		public static string Start(string htmlPage)
        {
            List<string> chunks = GetInnerTextFromHTMLNodes(htmlPage);
            var arraySplitwords = String.Join(" ", chunks).Split(new[] {' ', ',', '.', '!', '?','"', ';', ':', '[', ']', '(', ')', '\n',
                '\r', '\t'
            });
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            var words = regex.Replace(string.Join(" ", arraySplitwords), " ");

            return words;

            
        }
        static List<string> GetInnerTextFromHTMLNodes(string htmlPage)
        {
            List<string> chunks = new List<string>();
            IEnumerable<HtmlNode> nodes;
            GetNodesFromHTMLPage(htmlPage, out nodes);
            foreach (var node in nodes)
            {
                if (node.NodeType == HtmlNodeType.Text && node.ParentNode.Name != "script")
                {
                    chunks.Add(node.InnerText.ToLower());
                }
            }

            return chunks;
        }

        private static void GetNodesFromHTMLPage(string htmlPage, out IEnumerable<HtmlNode> nodes)
        {
            if (htmlPage == null) throw new ArgumentNullException(nameof(htmlPage));
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlPage);
            nodes = doc.DocumentNode.SelectSingleNode("//body").DescendantsAndSelf();
        }
    }
}
