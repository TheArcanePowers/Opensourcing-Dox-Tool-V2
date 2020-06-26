using Dox_Tool_V2.My;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Dox_Tool_V2
{
	public class EmailSearch
	{
		private string email;

		private Functions functions;

		public EmailSearch(string toSearch)
		{
			functions = new Functions();
			email = toSearch;
		}

		public void SearchThatsThem()
		{
			string url = "https://thatsthem.com/email/" + email;
			string pageSource = functions.GetPageSource(url);
			object objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "<span itemprop=\"streetAddress\">(.*?)</span>"));
			object objectValue2 = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
			int num = 0;
			checked
			{
				string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
				string[] array2 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue).GetEnumerator();
					while (enumerator.MoveNext())
					{
						Match match = (Match)enumerator.Current;
						string text = array[num] = match.Groups[1].Value;
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
				string[] array3 = array;
				foreach (string text2 in array3)
				{
					if (!string.IsNullOrEmpty(text2) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text2))
					{
						MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Address: " + text2);
						Console.WriteLine(text2);
					}
				}
				num = 0;
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = ((IEnumerable)objectValue2).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Match match2 = (Match)enumerator2.Current;
						string text3 = array2[num] = match2.Groups[1].Value;
						num++;
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				string[] array4 = array2;
				foreach (string text4 in array4)
				{
					if (!string.IsNullOrEmpty(text4) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text4))
					{
						MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Phone: " + text4);
						Console.WriteLine(text4);
					}
				}
			}
		}

		public void SearchWhoIsMind()
		{
			string url = "http://www.whoismind.com/email/" + email + ".html";
			string pageSource = functions.GetPageSource(url);
			MatchCollection matchCollection = (MatchCollection)functions.GetMatches(pageSource, "<a href=\"/whois/(.*?).html");
			checked
			{
				string[] array = new string[matchCollection.Count + 1];
				int num = 0;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = matchCollection.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Match match = (Match)enumerator.Current;
						string value = match.Groups[1].Value;
						value = value.Replace("<a href=\"/whois/", "");
						value = (array[num] = value.Replace(".html", ""));
						if (!string.IsNullOrEmpty(value) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(value))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add("Domain name:  http://" + value);
							Console.WriteLine(value);
						}
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
				foreach (string str in array2)
				{
					string pageSource2 = functions.GetPageSource("http://api.bulkwhoisapi.com/whoisAPI.php?domain=" + str + "&token=usemeforfree");
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource2));
						object obj = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantName"
						}, null).ToString();
						object left = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantStreet"
						}, null).ToString();
						left = Operators.AddObject(left, " - " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantCity"
						}, null).ToString());
						left = Operators.AddObject(left, ", " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantPostalCode"
						}, null).ToString());
						object obj2 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantPhone"
						}, null).ToString();
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(obj)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible name:  ", obj));
						}
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(left)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible address:  ", left));
						}
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(obj2)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible phone:  ", obj2));
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		public void SearchDatabases()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			string url = "https://hacked-emails.com/api?q=" + email;
			string pageSource = functions.GetPageSource(url);
			JObject val = JObject.Parse(pageSource);
			List<JToken> list = ((IEnumerable<JToken>)(object)((JContainer)val).Children()).ToList();
			foreach (JProperty item in list)
			{
				JProperty val2 = (JProperty)(object)item;
				((JToken)val2).CreateReader();
				Console.WriteLine(val2.get_Name());
				string name = val2.get_Name();
				if (Operators.CompareString(name, "data", TextCompare: false) == 0)
				{
					foreach (JObject item2 in (IEnumerable<JToken>)Extensions.Values((IEnumerable<JToken>)val2))
					{
						JObject val3 = (JObject)(object)item2;
						string text = val3.get_Item("source_url").ToString();
						if (!text.Equals("#") && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Data Leak:  " + text);
							Console.WriteLine(text);
						}
					}
				}
			}
		}
	}
}
