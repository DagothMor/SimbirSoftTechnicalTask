using System;
using System.IO;
using System.Net;

namespace SimbirSoftTechnicalTask.Controller
{
	/// <summary>
	/// Gets html text through request
	/// </summary>
	public static class GetHtmlTextThroughRequest
	{
		/// <summary>
		/// Starts the process
		/// </summary>
		/// <param name="url">url</param>
		/// <returns></returns>
		public static string Start(string url)
		{
			string result = "";
			try
			{
				var request = (HttpWebRequest)WebRequest.Create(url);
				request.Method = "GET";
				using WebResponse response = request.GetResponse();
				using Stream stream = response.GetResponseStream();
				using StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
				result = reader.ReadToEnd();
			}
			catch (WebException ex)
			{
				WebExceptionStatus status = ex.Status;

				if (status == WebExceptionStatus.ProtocolError)
				{
					HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
					Console.WriteLine("Статусный код ошибки: {0} - {1}",
						(int)httpResponse.StatusCode, httpResponse.StatusCode);
				}
			}
			return result;
		}
	}
}
