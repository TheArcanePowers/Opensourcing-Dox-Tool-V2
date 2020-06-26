using Dox_Tool_V2.My;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class Updater
	{
		private object thisVersion;

		private object currentVersion;

		private Functions functions;

		public Updater()
		{
			thisVersion = Application.ProductVersion;
			functions = new Functions();
			int num = (int)MessageBox.Show("Would you like to check for updates?", "Check for updates?", MessageBoxButtons.YesNo);
			if (num == 6)
			{
				Interaction.MsgBox("Program is now checking for updates. Please be patient.");
				currentVersion = new WebClient().DownloadString("http://Drizzybot.com/releases/version.txt");
				if (currentVersion.Equals(RuntimeHelpers.GetObjectValue(thisVersion)))
				{
					Interaction.MsgBox("No update is available at this time. Program will continue.");
					return;
				}
				Interaction.MsgBox("An update is available. The new version will now be downloaded...");
				NetworkCredential networkCredentials = new NetworkCredential(string.Empty, string.Empty);
				MyProject.Computer.Network.DownloadFile(new Uri("http://drizzybot.com/releases/Dox%20Tool%20V2.exe"), AppDomain.CurrentDomain.BaseDirectory + "Dox Tool V2 - Updated.exe", networkCredentials, showUI: false, 3500, overwrite: true);
				Interaction.MsgBox("Done! Launching new version...");
				Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Dox Tool V2 - Updated.exe");
				Application.Exit();
			}
		}
	}
}
