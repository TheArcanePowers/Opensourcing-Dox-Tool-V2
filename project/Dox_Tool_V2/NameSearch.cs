using Dox_Tool_V2.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class NameSearch
	{
		private object first;

		private object last;

		private object location;

		private Functions functions;

		public NameSearch(string firstName, string lastName, string locat)
		{
			functions = new Functions();
			first = firstName;
			last = lastName;
			location = locat;
		}

		public void Search411()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://www.411.com/name/", first), "-"), last), "/"), location));
			string pageSource = functions.GetPageSource(url);
			object objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "Lives at:  </span> (.*?)$"));
			checked
			{
				string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
				int num = 0;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Match match = (Match)enumerator.Current;
						string text = WebUtility.HtmlDecode(match.Groups[1].Value);
						text = text.Replace("/", "");
						text = (array[num] = text.Replace("<span>", ""));
						num++;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						Functions obj = functions;
						Form1 form;
						ListBox g = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = obj.Contains(ref g, text2);
						form.personSearchResults = g;
						if (Conversions.ToBoolean(Operators.NotObject(operand)) && !text2.ToLower().Contains("unknown"))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("411 Possible Address: " + text2);
							Console.WriteLine(text2);
						}
					}
				}
			}
		}

		public void SearchTenDigits()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://10digits.us/n/", first), "_"), last), "/location/"), location));
			string pageSource = functions.GetPageSource(url);
			object objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "itemtype=\"http://schema.org/PostalAddress\"><span>(.*?)</li>"));
			checked
			{
				string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
				int num = 0;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Match match = (Match)enumerator.Current;
						string text = WebUtility.HtmlDecode(match.Groups[1].Value);
						text = text.Replace("/", "");
						text = (array[num] = text.Replace("<span>", ""));
						num++;
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						Functions obj = functions;
						Form1 form;
						ListBox g = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = obj.Contains(ref g, text2);
						form.personSearchResults = g;
						if (Conversions.ToBoolean(Operators.NotObject(operand)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text2);
							Console.WriteLine(text2);
						}
					}
				}
			}
		}

		public void SearchZaba()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://www.zabasearch.com/people/", first), "+"), last), "/"), location));
			string pageSource = functions.GetPageSource(url);
			checked
			{
				if (!pageSource.Contains("Free <span class=\"listings-available-box\">Listings</span>"))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "initialize(.*?);</script>"));
					string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
					int num = 0;
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = ((IEnumerable)objectValue).GetEnumerator();
						while (enumerator.MoveNext())
						{
							Match match = (Match)enumerator.Current;
							string input = WebUtility.HtmlDecode(match.Groups[1].Value);
							input = (array[num] = Regex.Match(input, "'\"(.*?)\"'").Groups[1].Value);
							num++;
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (!string.IsNullOrEmpty(text))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text);
							Console.WriteLine(text);
						}
					}
					string value = Regex.Match(pageSource, "itemprop=\"telephone\">(.*?)</font>").Groups[1].Value;
					MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Phone: " + value);
					Console.WriteLine(value);
					return;
				}
				Console.WriteLine("More than one match");
				object objectValue2 = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "itemprop=\"streetAddress\">(.*?)</"));
				object objectValue3 = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
				string[] array3 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
				string[] array4 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue3, null, "Count", new object[0], null, null, null)) + 1];
				int num2 = 0;
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = ((IEnumerable)objectValue2).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Match match2 = (Match)enumerator2.Current;
						string text2 = array3[num2] = WebUtility.HtmlDecode(match2.Groups[1].Value);
						num2++;
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				num2 = 0;
				IEnumerator enumerator3 = default(IEnumerator);
				try
				{
					enumerator3 = ((IEnumerable)objectValue3).GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Match match3 = (Match)enumerator3.Current;
						string text3 = array4[num2] = WebUtility.HtmlDecode(match3.Groups[1].Value);
						num2++;
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				string[] array5 = array3;
				foreach (string text4 in array5)
				{
					if (!string.IsNullOrEmpty(text4))
					{
						Functions obj = functions;
						Form1 form;
						ListBox g = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = obj.Contains(ref g, text4);
						form.personSearchResults = g;
						if (Conversions.ToBoolean(Operators.NotObject(operand)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text4);
						}
					}
				}
				string[] array6 = array4;
				foreach (string text5 in array6)
				{
					if (!string.IsNullOrEmpty(text5))
					{
						Functions obj2 = functions;
						Form1 form;
						ListBox g = (form = MyProject.Forms.Form1).personSearchResults;
						object operand2 = obj2.Contains(ref g, text5);
						form.personSearchResults = g;
						if (Conversions.ToBoolean(Operators.NotObject(operand2)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Phone Number: " + text5);
						}
					}
				}
			}
		}
	}
}
