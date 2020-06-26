using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class Functions
	{
		public string GetPageSource(string url)
		{
			string result = string.Empty;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Timeout = 5000;
				httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				result = streamReader.ReadToEnd();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine(url + ": " + ex2.Message);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public object GetMatches(string toSearch, string regexPattern)
		{
			return Regex.Matches(toSearch, regexPattern, RegexOptions.Multiline);
		}

		public bool IsUri(string source)
		{
			Uri result;
			if (!string.IsNullOrEmpty(source) && Uri.IsWellFormedUriString(source, UriKind.RelativeOrAbsolute))
			{
				return Uri.TryCreate(source, UriKind.RelativeOrAbsolute, out result);
			}
			return false;
		}

		public void SearchGoogle(string query, ref ListBox g)
		{
			string pageSource = GetPageSource("http://www.google.com/search?num=100&q=\"" + query + "\"");
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = new Regex("url\\?q=(.*?)&").Matches(pageSource).GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "groups", new object[1]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					if (!g.Items.Contains(text) && !text.Contains("googleusercontent") && !text.Contains("/settings/ads"))
					{
						g.Items.Add("Possible Connection: " + WebUtility.HtmlDecode(text));
						Console.WriteLine(text);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		public object Contains(ref ListBox g, string f)
		{
			bool flag = false;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = g.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string value = Conversions.ToString(enumerator.Current);
					if (f.Equals(value))
					{
						flag = true;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return flag;
		}
	}
}
