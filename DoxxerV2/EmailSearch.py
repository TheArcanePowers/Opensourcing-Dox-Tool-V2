def  SearchWhoIsMind():
    url = "http://www.whoismind.com/email/" + email + ".html"

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
		string url = "https://hacked-emails.com/api?q=" + email;
		string pageSource = functions.GetPageSource(url);
		JObject jObject = JObject.Parse(pageSource);
		List<JToken> list = jObject.Children().ToList();
		foreach (JProperty item in list)
		{
			item.CreateReader();
			Console.WriteLine(item.Name);
			string name = item.Name;
			if (Operators.CompareString(name, "data", TextCompare: false) == 0)
			{
				foreach (JObject item2 in item.Values())
				{
					string text = item2["source_url"]!.ToString();
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
