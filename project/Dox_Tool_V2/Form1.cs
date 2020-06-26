using Dox_Tool_V2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		public class WorkerArgs
		{
			public string first;

			public string last;

			public string location;

			public string email;

			public string username;

			public string query;

			public ListBox box;

			public LogInProgressBar bar;
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__15_002D0
		{
			public object _0024VB_0024Local_oo;

			public ListBox _0024VB_0024Local_g;

			internal void _Lambda_0024__0()
			{
				if (!string.IsNullOrEmpty(Conversions.ToString(_0024VB_0024Local_oo)))
				{
					_0024VB_0024Local_g.Items.Add(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_oo));
				}
			}
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__16_002D0
		{
			public ListBox _0024VB_0024Local_g;

			public Form1 _0024VB_0024Me;

			internal void _Lambda_0024__0()
			{
				_0024VB_0024Me.clean(_0024VB_0024Local_g);
			}
		}

		[CompilerGenerated]
		internal sealed class _Closure_0024__18_002D0
		{
			public LogInProgressBar _0024VB_0024Local_bar;

			public int _0024VB_0024Local_g;

			internal void _Lambda_0024__0()
			{
				if (_0024VB_0024Local_bar.Value < 100)
				{
					_0024VB_0024Local_bar.Value = _0024VB_0024Local_g;
				}
			}
		}

		private Functions functions;

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInThemeContainer1")]
		private LogInThemeContainer _LogInThemeContainer1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInTabControl1")]
		private LogInTabControl _LogInTabControl1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("nameSearch")]
		private LogInButton _nameSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("location")]
		private LogInNormalTextBox _location;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel3")]
		private LogInLabel _LogInLabel3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lastName")]
		private LogInNormalTextBox _lastName;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("firstName")]
		private LogInNormalTextBox _firstName;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel2")]
		private LogInLabel _LogInLabel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel1")]
		private LogInLabel _LogInLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("email")]
		private LogInNormalTextBox _email;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel4")]
		private LogInLabel _LogInLabel4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("emailSearch")]
		private LogInButton _emailSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("userSearch")]
		private LogInButton _userSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("usernameSearch")]
		private LogInNormalTextBox _usernameSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel5")]
		private LogInLabel _LogInLabel5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInGroupBox1")]
		private LogInGroupBox _LogInGroupBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("zipCode")]
		private LogInNormalTextBox _zipCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel9")]
		private LogInLabel _LogInLabel9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("latLong")]
		private LogInNormalTextBox _latLong;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel8")]
		private LogInLabel _LogInLabel8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cityState")]
		private LogInNormalTextBox _cityState;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel7")]
		private LogInLabel _LogInLabel7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ipSearchButton")]
		private LogInButton _ipSearchButton;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ipText")]
		private LogInNormalTextBox _ipText;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel6")]
		private LogInLabel _LogInLabel6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("mapButton")]
		private LogInButton _mapButton;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInGroupBox2")]
		private LogInGroupBox _LogInGroupBox2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("exportButton")]
		private LogInButton _exportButton;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("otherInfo")]
		private LogInRichTextBox _otherInfo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel15")]
		private LogInLabel _LogInLabel15;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("emailTemplate")]
		private LogInNormalTextBox _emailTemplate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel14")]
		private LogInLabel _LogInLabel14;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("addressTemplate")]
		private LogInNormalTextBox _addressTemplate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel13")]
		private LogInLabel _LogInLabel13;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("phoneTemplate")]
		private LogInNormalTextBox _phoneTemplate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel12")]
		private LogInLabel _LogInLabel12;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ageTemplate")]
		private LogInNormalTextBox _ageTemplate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel11")]
		private LogInLabel _LogInLabel11;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("nameTemplate")]
		private LogInNormalTextBox _nameTemplate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel10")]
		private LogInLabel _LogInLabel10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("personSearchResults")]
		private ListBox _personSearchResults;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("emailSearchResults")]
		private ListBox _emailSearchResults;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("usernameSearchResults")]
		private ListBox _usernameSearchResults;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("personSearch")]
		private BackgroundWorker _personSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel16")]
		private LogInLabel _LogInLabel16;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("personProgress")]
		private LogInProgressBar _personProgress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("emailWorker")]
		private BackgroundWorker _emailWorker;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel17")]
		private LogInLabel _LogInLabel17;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("emailProgress")]
		private LogInProgressBar _emailProgress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("LogInLabel18")]
		private LogInLabel _LogInLabel18;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("usernameProgress")]
		private LogInProgressBar _usernameProgress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("googleWorker")]
		private BackgroundWorker _googleWorker;

		[field: AccessedThroughProperty("LogInThemeContainer1")]
		internal virtual LogInThemeContainer LogInThemeContainer1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInTabControl1")]
		internal virtual LogInTabControl LogInTabControl1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage1")]
		internal virtual TabPage TabPage1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage2")]
		internal virtual TabPage TabPage2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LogInButton nameSearch
		{
			[CompilerGenerated]
			get
			{
				return _nameSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = nameSearch_Click;
				LogInButton nameSearch = _nameSearch;
				if (nameSearch != null)
				{
					nameSearch.Click -= value2;
				}
				_nameSearch = value;
				nameSearch = _nameSearch;
				if (nameSearch != null)
				{
					nameSearch.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("location")]
		internal virtual LogInNormalTextBox location
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel3")]
		internal virtual LogInLabel LogInLabel3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lastName")]
		internal virtual LogInNormalTextBox lastName
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("firstName")]
		internal virtual LogInNormalTextBox firstName
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel2")]
		internal virtual LogInLabel LogInLabel2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel1")]
		internal virtual LogInLabel LogInLabel1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage3")]
		internal virtual TabPage TabPage3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage4")]
		internal virtual TabPage TabPage4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("email")]
		internal virtual LogInNormalTextBox email
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel4")]
		internal virtual LogInLabel LogInLabel4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LogInButton emailSearch
		{
			[CompilerGenerated]
			get
			{
				return _emailSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = emailSearch_Click;
				LogInButton emailSearch = _emailSearch;
				if (emailSearch != null)
				{
					emailSearch.Click -= value2;
				}
				_emailSearch = value;
				emailSearch = _emailSearch;
				if (emailSearch != null)
				{
					emailSearch.Click += value2;
				}
			}
		}

		internal virtual LogInButton userSearch
		{
			[CompilerGenerated]
			get
			{
				return _userSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = userSearch_Click;
				LogInButton userSearch = _userSearch;
				if (userSearch != null)
				{
					userSearch.Click -= value2;
				}
				_userSearch = value;
				userSearch = _userSearch;
				if (userSearch != null)
				{
					userSearch.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("usernameSearch")]
		internal virtual LogInNormalTextBox usernameSearch
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel5")]
		internal virtual LogInLabel LogInLabel5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInGroupBox1")]
		internal virtual LogInGroupBox LogInGroupBox1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("zipCode")]
		internal virtual LogInNormalTextBox zipCode
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel9")]
		internal virtual LogInLabel LogInLabel9
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("latLong")]
		internal virtual LogInNormalTextBox latLong
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel8")]
		internal virtual LogInLabel LogInLabel8
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cityState")]
		internal virtual LogInNormalTextBox cityState
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel7")]
		internal virtual LogInLabel LogInLabel7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LogInButton ipSearchButton
		{
			[CompilerGenerated]
			get
			{
				return _ipSearchButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ipSearchButton_Click;
				LogInButton ipSearchButton = _ipSearchButton;
				if (ipSearchButton != null)
				{
					ipSearchButton.Click -= value2;
				}
				_ipSearchButton = value;
				ipSearchButton = _ipSearchButton;
				if (ipSearchButton != null)
				{
					ipSearchButton.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("ipText")]
		internal virtual LogInNormalTextBox ipText
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel6")]
		internal virtual LogInLabel LogInLabel6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LogInButton mapButton
		{
			[CompilerGenerated]
			get
			{
				return _mapButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = mapButton_Click;
				LogInButton mapButton = _mapButton;
				if (mapButton != null)
				{
					mapButton.Click -= value2;
				}
				_mapButton = value;
				mapButton = _mapButton;
				if (mapButton != null)
				{
					mapButton.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("LogInGroupBox2")]
		internal virtual LogInGroupBox LogInGroupBox2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LogInButton exportButton
		{
			[CompilerGenerated]
			get
			{
				return _exportButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = exportButton_Click;
				LogInButton exportButton = _exportButton;
				if (exportButton != null)
				{
					exportButton.Click -= value2;
				}
				_exportButton = value;
				exportButton = _exportButton;
				if (exportButton != null)
				{
					exportButton.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("otherInfo")]
		internal virtual LogInRichTextBox otherInfo
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel15")]
		internal virtual LogInLabel LogInLabel15
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("emailTemplate")]
		internal virtual LogInNormalTextBox emailTemplate
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel14")]
		internal virtual LogInLabel LogInLabel14
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("addressTemplate")]
		internal virtual LogInNormalTextBox addressTemplate
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel13")]
		internal virtual LogInLabel LogInLabel13
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("phoneTemplate")]
		internal virtual LogInNormalTextBox phoneTemplate
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel12")]
		internal virtual LogInLabel LogInLabel12
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("ageTemplate")]
		internal virtual LogInNormalTextBox ageTemplate
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel11")]
		internal virtual LogInLabel LogInLabel11
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("nameTemplate")]
		internal virtual LogInNormalTextBox nameTemplate
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel10")]
		internal virtual LogInLabel LogInLabel10
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ListBox personSearchResults
		{
			[CompilerGenerated]
			get
			{
				return _personSearchResults;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = personSearchResults_DoubleClick;
				ListBox personSearchResults = _personSearchResults;
				if (personSearchResults != null)
				{
					personSearchResults.DoubleClick -= value2;
				}
				_personSearchResults = value;
				personSearchResults = _personSearchResults;
				if (personSearchResults != null)
				{
					personSearchResults.DoubleClick += value2;
				}
			}
		}

		internal virtual ListBox emailSearchResults
		{
			[CompilerGenerated]
			get
			{
				return _emailSearchResults;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = emailSearchResults_SelectedIndexChanged;
				EventHandler value3 = emailSearchResults_DoubleClick;
				ListBox emailSearchResults = _emailSearchResults;
				if (emailSearchResults != null)
				{
					emailSearchResults.SelectedIndexChanged -= value2;
					emailSearchResults.DoubleClick -= value3;
				}
				_emailSearchResults = value;
				emailSearchResults = _emailSearchResults;
				if (emailSearchResults != null)
				{
					emailSearchResults.SelectedIndexChanged += value2;
					emailSearchResults.DoubleClick += value3;
				}
			}
		}

		internal virtual ListBox usernameSearchResults
		{
			[CompilerGenerated]
			get
			{
				return _usernameSearchResults;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = usernameSearchResults_DoubleClick;
				ListBox usernameSearchResults = _usernameSearchResults;
				if (usernameSearchResults != null)
				{
					usernameSearchResults.DoubleClick -= value2;
				}
				_usernameSearchResults = value;
				usernameSearchResults = _usernameSearchResults;
				if (usernameSearchResults != null)
				{
					usernameSearchResults.DoubleClick += value2;
				}
			}
		}

		internal virtual BackgroundWorker personSearch
		{
			[CompilerGenerated]
			get
			{
				return _personSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
				ProgressChangedEventHandler value3 = personSearch_ProgressChanged;
				BackgroundWorker personSearch = _personSearch;
				if (personSearch != null)
				{
					personSearch.DoWork -= value2;
					personSearch.ProgressChanged -= value3;
				}
				_personSearch = value;
				personSearch = _personSearch;
				if (personSearch != null)
				{
					personSearch.DoWork += value2;
					personSearch.ProgressChanged += value3;
				}
			}
		}

		[field: AccessedThroughProperty("LogInLabel16")]
		internal virtual LogInLabel LogInLabel16
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("personProgress")]
		internal virtual LogInProgressBar personProgress
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual BackgroundWorker emailWorker
		{
			[CompilerGenerated]
			get
			{
				return _emailWorker;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = emailWorker_DoWork;
				BackgroundWorker emailWorker = _emailWorker;
				if (emailWorker != null)
				{
					emailWorker.DoWork -= value2;
				}
				_emailWorker = value;
				emailWorker = _emailWorker;
				if (emailWorker != null)
				{
					emailWorker.DoWork += value2;
				}
			}
		}

		[field: AccessedThroughProperty("LogInLabel17")]
		internal virtual LogInLabel LogInLabel17
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("emailProgress")]
		internal virtual LogInProgressBar emailProgress
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LogInLabel18")]
		internal virtual LogInLabel LogInLabel18
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("usernameProgress")]
		internal virtual LogInProgressBar usernameProgress
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual BackgroundWorker googleWorker
		{
			[CompilerGenerated]
			get
			{
				return _googleWorker;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = googleWorker_DoWork;
				BackgroundWorker googleWorker = _googleWorker;
				if (googleWorker != null)
				{
					googleWorker.DoWork -= value2;
				}
				_googleWorker = value;
				googleWorker = _googleWorker;
				if (googleWorker != null)
				{
					googleWorker.DoWork += value2;
				}
			}
		}

		public Form1()
		{
			base.Load += Form1_Load;
			functions = new Functions();
			InitializeComponent();
		}

		private void nameSearch_Click(object sender, EventArgs e)
		{
			personProgress.Value = 0;
			personSearchResults.Items.Clear();
			NameSearch nameSearch = new NameSearch(firstName.Text, lastName.Text, location.Text);
			WorkerArgs workerArgs = new WorkerArgs();
			workerArgs.first = firstName.Text;
			workerArgs.last = lastName.Text;
			workerArgs.location = location.Text;
			personSearch.RunWorkerAsync(workerArgs);
		}

		private void emailSearch_Click(object sender, EventArgs e)
		{
			emailProgress.Value = 0;
			emailSearchResults.Items.Clear();
			WorkerArgs workerArgs = new WorkerArgs();
			workerArgs.email = email.Text;
			workerArgs.query = email.Text;
			workerArgs.box = emailSearchResults;
			workerArgs.bar = emailProgress;
			emailWorker.RunWorkerAsync(workerArgs);
		}

		private void userSearch_Click(object sender, EventArgs e)
		{
			usernameProgress.Value = 0;
			usernameSearchResults.Items.Clear();
			WorkerArgs workerArgs = new WorkerArgs();
			workerArgs.query = usernameSearch.Text;
			workerArgs.box = usernameSearchResults;
			workerArgs.bar = usernameProgress;
			googleWorker.RunWorkerAsync(workerArgs);
		}

		private void ipSearchButton_Click(object sender, EventArgs e)
		{
			string pageSource = functions.GetPageSource("http://ip-api.com/json/" + ipText.Text);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource));
				cityState.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet(objectValue, new object[1]
				{
					"city"
				}, null), "/"), NewLateBinding.LateIndexGet(objectValue, new object[1]
				{
					"regionName"
				}, null)));
				latLong.Text = NewLateBinding.LateIndexGet(objectValue, new object[1]
				{
					"lat"
				}, null).ToString() + "," + NewLateBinding.LateIndexGet(objectValue, new object[1]
				{
					"lon"
				}, null).ToString();
				zipCode.Text = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1]
				{
					"zip"
				}, null));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine(ex2.Message);
				ipText.Text = "Error.";
				ProjectData.ClearProjectError();
			}
		}

		private void mapButton_Click(object sender, EventArgs e)
		{
			Process.Start("http://maps.google.com?q=" + latLong.Text);
		}

		private void exportButton_Click(object sender, EventArgs e)
		{
			using (StreamWriter streamWriter = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "dox.txt"))
			{
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine("╔═══╗╔═══╗╔═╗╔═╗╔═══╗╔═══╗");
				streamWriter.WriteLine("╚╗╔╗║║╔═╗║╚╗╚╝╔╝║╔══╝╚╗╔╗║");
				streamWriter.WriteLine("─║║║║║║─║║─╚╗╔╝─║╚══╗─║║║║");
				streamWriter.WriteLine("─║║║║║║─║║─╔╝╚╗─║╔══╝─║║║║");
				streamWriter.WriteLine("╔╝╚╝║║╚═╝║╔╝╔╗╚╗║╚══╗╔╝╚╝║");
				streamWriter.WriteLine("╚═══╝╚═══╝╚═╝╚═╝╚═══╝╚═══╝");
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine("Name: " + nameTemplate.Text);
				streamWriter.WriteLine("Age: " + ageTemplate.Text);
				streamWriter.WriteLine("Phone Number: " + phoneTemplate.Text);
				streamWriter.WriteLine("Address: " + addressTemplate.Text);
				streamWriter.WriteLine("Email: " + emailTemplate.Text);
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine(otherInfo.Text);
			}
			Process.Start(AppDomain.CurrentDomain.BaseDirectory + "dox.txt");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll"))
			{
				Interaction.MsgBox("The program will now download a required assembly to run...");
				MyProject.Computer.Network.DownloadFile("http://drizzybot.com/releases/Newtonsoft.Json.dll", AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll");
				Interaction.MsgBox("Done! The program will now start...");
			}
			Updater updater = new Updater();
		}

		private void personSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(personSearchResults.SelectedItem, null, "Substring", new object[1]
			{
				Operators.AddObject(NewLateBinding.LateGet(personSearchResults.SelectedItem, null, "IndexOf", new object[1]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (functions.IsUri(Conversions.ToString(objectValue)))
			{
				Type typeFromHandle = typeof(Process);
				object[] obj = new object[1]
				{
					objectValue
				};
				object[] array = obj;
				bool[] obj2 = new bool[1]
				{
					true
				};
				bool[] array2 = obj2;
				NewLateBinding.LateCall(null, typeFromHandle, "Start", obj, null, null, obj2, IgnoreReturn: true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		private void emailSearchResults_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void emailSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(emailSearchResults.SelectedItem, null, "Substring", new object[1]
			{
				Operators.AddObject(NewLateBinding.LateGet(emailSearchResults.SelectedItem, null, "IndexOf", new object[1]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (functions.IsUri(Conversions.ToString(objectValue)))
			{
				Type typeFromHandle = typeof(Process);
				object[] obj = new object[1]
				{
					objectValue
				};
				object[] array = obj;
				bool[] obj2 = new bool[1]
				{
					true
				};
				bool[] array2 = obj2;
				NewLateBinding.LateCall(null, typeFromHandle, "Start", obj, null, null, obj2, IgnoreReturn: true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		private void usernameSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(usernameSearchResults.SelectedItem, null, "Substring", new object[1]
			{
				Operators.AddObject(NewLateBinding.LateGet(usernameSearchResults.SelectedItem, null, "IndexOf", new object[1]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (functions.IsUri(Conversions.ToString(objectValue)))
			{
				Type typeFromHandle = typeof(Process);
				object[] obj = new object[1]
				{
					objectValue
				};
				object[] array = obj;
				bool[] obj2 = new bool[1]
				{
					true
				};
				bool[] array2 = obj2;
				NewLateBinding.LateCall(null, typeFromHandle, "Start", obj, null, null, obj2, IgnoreReturn: true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Console.WriteLine("Starting 10Digits");
			WorkerArgs workerArgs = (WorkerArgs)e.Argument;
			string url = "http://10digits.us/n/" + workerArgs.first + "_" + workerArgs.last + "/location/" + workerArgs.location;
			string pageSource = functions.GetPageSource(url);
			Console.WriteLine("Got Source");
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
				Console.WriteLine("Got matches: " + num);
				int num2 = num;
				for (int i = 0; i <= num2; i++)
				{
					string text2 = array[i];
					AddToListBox(personSearchResults, "Possible Address: " + text2);
					Console.WriteLine(text2);
				}
				UpdateBar(personProgress, 33);
				try
				{
					Console.WriteLine("Starting 411");
					url = "http://www.411.com/name/" + workerArgs.first + "-" + workerArgs.last + "/" + workerArgs.location;
					pageSource = functions.GetPageSource(url);
					objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "Lives at:  </span> (.*?)$"));
					string[] array2 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
					num = 0;
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = ((IEnumerable)objectValue).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Match match2 = (Match)enumerator2.Current;
							string text3 = WebUtility.HtmlDecode(match2.Groups[1].Value);
							text3 = text3.Replace("/", "");
							text3 = (array2[num] = text3.Replace("<span>", ""));
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
					string[] array3 = array2;
					foreach (string text4 in array3)
					{
						AddToListBox(personSearchResults, "Possible Address: " + text4);
						Console.WriteLine(text4);
					}
					UpdateBar(personProgress, 66);
					Console.WriteLine("Starting Zaba");
					url = "http://www.zabasearch.com/people/" + workerArgs.first + "+" + workerArgs.last + "/" + workerArgs.location;
					pageSource = functions.GetPageSource(url);
					if (!pageSource.Contains("Free <span class=\"listings-available-box\">Listings</span>"))
					{
						objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "initialize(.*?);</script>"));
						string[] array4 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
						num = 0;
						IEnumerator enumerator3 = default(IEnumerator);
						try
						{
							enumerator3 = ((IEnumerable)objectValue).GetEnumerator();
							while (enumerator3.MoveNext())
							{
								Match match3 = (Match)enumerator3.Current;
								string input = WebUtility.HtmlDecode(match3.Groups[1].Value);
								input = (array4[num] = Regex.Match(input, "'\"(.*?)\"'").Groups[1].Value);
								num++;
							}
						}
						finally
						{
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
						string[] array5 = array4;
						foreach (string text5 in array5)
						{
							if (!string.IsNullOrEmpty(text5))
							{
								AddToListBox(personSearchResults, "Possible Address: " + text5);
								Console.WriteLine(text5);
							}
						}
						string value = Regex.Match(pageSource, "itemprop=\"telephone\">(.*?)</font>").Groups[1].Value;
						AddToListBox(personSearchResults, "Possible Phone: " + value);
						Console.WriteLine(value);
					}
					else
					{
						Console.WriteLine("More than one match");
						objectValue = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "itemprop=\"streetAddress\">(.*?)</"));
						object objectValue2 = RuntimeHelpers.GetObjectValue(functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
						string[] array6 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
						string[] array7 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
						num = 0;
						IEnumerator enumerator4 = default(IEnumerator);
						try
						{
							enumerator4 = ((IEnumerable)objectValue).GetEnumerator();
							while (enumerator4.MoveNext())
							{
								Match match4 = (Match)enumerator4.Current;
								string text6 = array6[num] = WebUtility.HtmlDecode(match4.Groups[1].Value);
								num++;
							}
						}
						finally
						{
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
						num = 0;
						IEnumerator enumerator5 = default(IEnumerator);
						try
						{
							enumerator5 = ((IEnumerable)objectValue2).GetEnumerator();
							while (enumerator5.MoveNext())
							{
								Match match5 = (Match)enumerator5.Current;
								string text7 = array7[num] = WebUtility.HtmlDecode(match5.Groups[1].Value);
								num++;
							}
						}
						finally
						{
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
						string[] array8 = array6;
						foreach (string text8 in array8)
						{
							AddToListBox(personSearchResults, "Possible Address: " + text8);
							Console.WriteLine(text8);
						}
						string[] array9 = array7;
						foreach (string text9 in array9)
						{
							AddToListBox(personSearchResults, "Possible Phone Number: " + text9);
							Console.WriteLine(text9);
						}
					}
					UpdateBar(personProgress, 100);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Console.WriteLine(ex2.InnerException);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void AddToListBox(ListBox g, object oo)
		{
			Invoke((MethodInvoker)delegate
			{
				if (!string.IsNullOrEmpty(Conversions.ToString(oo)))
				{
					g.Items.Add(RuntimeHelpers.GetObjectValue(oo));
				}
			});
		}

		private void CleanThread(ListBox g)
		{
			Invoke((MethodInvoker)delegate
			{
				clean(g);
			});
		}

		public void clean(ListBox g)
		{
			List<string> list = new List<string>();
			int count = g.Items.Count;
			for (int i = 0; i <= count; i = checked(i + 1))
			{
				string text = g.Items[i].ToString().Substring(g.Items[i].ToString().IndexOf(": "));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			g.Items.Clear();
			foreach (string item in list)
			{
				g.Items.Add(item);
			}
		}

		public void UpdateBar(LogInProgressBar bar, int g)
		{
			Invoke((MethodInvoker)delegate
			{
				if (bar.Value < 100)
				{
					bar.Value = g;
				}
			});
		}

		private void personSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			Console.WriteLine(Conversions.ToDouble("Progress: ") + (double)e.ProgressPercentage);
		}

		private void emailWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_0563: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Expected O, but got Unknown
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Expected O, but got Unknown
			Console.WriteLine("Started");
			WorkerArgs workerArgs = (WorkerArgs)e.Argument;
			Console.WriteLine("Got arguments");
			string url = "https://thatsthem.com/email/" + workerArgs.email;
			string pageSource = functions.GetPageSource(url);
			Console.WriteLine("Got source");
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
					AddToListBox(emailSearchResults, "Possible Address: " + text2);
					Console.WriteLine(text2);
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
					AddToListBox(emailSearchResults, "Possible Phone: " + text4);
					Console.WriteLine(text4);
				}
				UpdateBar(emailProgress, 33);
				url = "http://www.whoismind.com/email/" + workerArgs.email + ".html";
				pageSource = functions.GetPageSource(url);
				MatchCollection matchCollection = (MatchCollection)functions.GetMatches(pageSource, "<a href=\"/whois/(.*?).html");
				string[] array5 = new string[matchCollection.Count + 1];
				num = 0;
				IEnumerator enumerator3 = default(IEnumerator);
				try
				{
					enumerator3 = matchCollection.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Match match3 = (Match)enumerator3.Current;
						string value = match3.Groups[1].Value;
						value = value.Replace("<a href=\"/whois/", "");
						value = (array5[num] = value.Replace(".html", ""));
						AddToListBox(emailSearchResults, "Domain Name:  http://" + value);
						Console.WriteLine(value);
						num++;
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				string[] array6 = array5;
				foreach (string str in array6)
				{
					string pageSource2 = functions.GetPageSource("http://api.bulkwhoisapi.com/whoisAPI.php?domain=" + str + "&token=usemeforfree");
					try
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource2));
						object right = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantName"
						}, null).ToString();
						object left = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantStreet"
						}, null).ToString();
						left = Operators.AddObject(left, " - " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantCity"
						}, null).ToString());
						left = Operators.AddObject(left, ", " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantPostalCode"
						}, null).ToString());
						object right2 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[1]
						{
							"formatted_data"
						}, null), new object[1]
						{
							"RegistrantPhone"
						}, null).ToString();
						AddToListBox(emailSearchResults, Operators.AddObject("Possible Name:  ", right));
						AddToListBox(emailSearchResults, Operators.AddObject("Possible Address:  ", left));
						AddToListBox(emailSearchResults, Operators.AddObject("Possible Phone:  ", right2));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Console.WriteLine(ex2.Message);
						ProjectData.ClearProjectError();
					}
				}
				UpdateBar(emailProgress, 66);
				url = "https://hacked-emails.com/api?q=" + workerArgs.email;
				pageSource = functions.GetPageSource(url);
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
							string text5 = val3.get_Item("source_url").ToString();
							if (!text5.Equals("#"))
							{
								AddToListBox(emailSearchResults, "Possible Data Leak:  " + text5);
								Console.WriteLine(text5);
							}
						}
					}
				}
				UpdateBar(emailProgress, 70);
				googleWorker.RunWorkerAsync(RuntimeHelpers.GetObjectValue(e.Argument));
				Console.WriteLine("Done");
			}
		}

		private void googleWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			WorkerArgs workerArgs = (WorkerArgs)e.Argument;
			string pageSource = functions.GetPageSource("http://www.google.com/search?num=100&q=\"" + workerArgs.query + "\"");
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
					Console.WriteLine(text);
					if (!text.Contains("googleusercontent") && !text.Contains("/settings/ads"))
					{
						AddToListBox(workerArgs.box, "Possible Connection: " + WebUtility.HtmlDecode(text));
						UpdateBar(workerArgs.bar, checked(workerArgs.bar.Value + 2));
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
			UpdateBar(workerArgs.bar, 100);
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dox_Tool_V2.Form1));
			personSearch = new System.ComponentModel.BackgroundWorker();
			emailWorker = new System.ComponentModel.BackgroundWorker();
			googleWorker = new System.ComponentModel.BackgroundWorker();
			LogInThemeContainer1 = new Dox_Tool_V2.LogInThemeContainer();
			LogInTabControl1 = new Dox_Tool_V2.LogInTabControl();
			TabPage1 = new System.Windows.Forms.TabPage();
			LogInLabel16 = new Dox_Tool_V2.LogInLabel();
			personProgress = new Dox_Tool_V2.LogInProgressBar();
			personSearchResults = new System.Windows.Forms.ListBox();
			nameSearch = new Dox_Tool_V2.LogInButton();
			location = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel3 = new Dox_Tool_V2.LogInLabel();
			lastName = new Dox_Tool_V2.LogInNormalTextBox();
			firstName = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel2 = new Dox_Tool_V2.LogInLabel();
			LogInLabel1 = new Dox_Tool_V2.LogInLabel();
			TabPage2 = new System.Windows.Forms.TabPage();
			LogInLabel17 = new Dox_Tool_V2.LogInLabel();
			emailProgress = new Dox_Tool_V2.LogInProgressBar();
			emailSearchResults = new System.Windows.Forms.ListBox();
			emailSearch = new Dox_Tool_V2.LogInButton();
			email = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel4 = new Dox_Tool_V2.LogInLabel();
			TabPage3 = new System.Windows.Forms.TabPage();
			LogInLabel18 = new Dox_Tool_V2.LogInLabel();
			usernameProgress = new Dox_Tool_V2.LogInProgressBar();
			usernameSearchResults = new System.Windows.Forms.ListBox();
			userSearch = new Dox_Tool_V2.LogInButton();
			usernameSearch = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel5 = new Dox_Tool_V2.LogInLabel();
			TabPage4 = new System.Windows.Forms.TabPage();
			LogInGroupBox2 = new Dox_Tool_V2.LogInGroupBox();
			exportButton = new Dox_Tool_V2.LogInButton();
			otherInfo = new Dox_Tool_V2.LogInRichTextBox();
			LogInLabel15 = new Dox_Tool_V2.LogInLabel();
			emailTemplate = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel14 = new Dox_Tool_V2.LogInLabel();
			addressTemplate = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel13 = new Dox_Tool_V2.LogInLabel();
			phoneTemplate = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel12 = new Dox_Tool_V2.LogInLabel();
			ageTemplate = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel11 = new Dox_Tool_V2.LogInLabel();
			nameTemplate = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel10 = new Dox_Tool_V2.LogInLabel();
			LogInGroupBox1 = new Dox_Tool_V2.LogInGroupBox();
			mapButton = new Dox_Tool_V2.LogInButton();
			zipCode = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel9 = new Dox_Tool_V2.LogInLabel();
			latLong = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel8 = new Dox_Tool_V2.LogInLabel();
			cityState = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel7 = new Dox_Tool_V2.LogInLabel();
			ipSearchButton = new Dox_Tool_V2.LogInButton();
			ipText = new Dox_Tool_V2.LogInNormalTextBox();
			LogInLabel6 = new Dox_Tool_V2.LogInLabel();
			LogInThemeContainer1.SuspendLayout();
			LogInTabControl1.SuspendLayout();
			TabPage1.SuspendLayout();
			TabPage2.SuspendLayout();
			TabPage3.SuspendLayout();
			TabPage4.SuspendLayout();
			LogInGroupBox2.SuspendLayout();
			LogInGroupBox1.SuspendLayout();
			SuspendLayout();
			LogInThemeContainer1.AllowClose = true;
			LogInThemeContainer1.AllowMaximize = false;
			LogInThemeContainer1.AllowMinimize = true;
			LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
			LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(35, 35, 35);
			LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(60, 60, 60);
			LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(54, 54, 54);
			LogInThemeContainer1.Controls.Add(LogInTabControl1);
			LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInThemeContainer1.FontSize = 12;
			LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(42, 42, 42);
			LogInThemeContainer1.Location = new System.Drawing.Point(0, 0);
			LogInThemeContainer1.Name = "LogInThemeContainer1";
			LogInThemeContainer1.ShowIcon = true;
			LogInThemeContainer1.Size = new System.Drawing.Size(447, 504);
			LogInThemeContainer1.TabIndex = 0;
			LogInThemeContainer1.Text = "Dox Tool By Drizzy V2";
			LogInTabControl1.ActiveColour = System.Drawing.Color.FromArgb(47, 47, 47);
			LogInTabControl1.BackTabColour = System.Drawing.Color.FromArgb(54, 54, 54);
			LogInTabControl1.BaseColour = System.Drawing.Color.FromArgb(35, 35, 35);
			LogInTabControl1.BorderColour = System.Drawing.Color.FromArgb(30, 30, 30);
			LogInTabControl1.Controls.Add(TabPage1);
			LogInTabControl1.Controls.Add(TabPage2);
			LogInTabControl1.Controls.Add(TabPage3);
			LogInTabControl1.Controls.Add(TabPage4);
			LogInTabControl1.Font = new System.Drawing.Font("Segoe UI", 10f);
			LogInTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(23, 119, 151);
			LogInTabControl1.ItemSize = new System.Drawing.Size(240, 32);
			LogInTabControl1.Location = new System.Drawing.Point(3, 34);
			LogInTabControl1.Name = "LogInTabControl1";
			LogInTabControl1.SelectedIndex = 0;
			LogInTabControl1.Size = new System.Drawing.Size(443, 467);
			LogInTabControl1.TabIndex = 0;
			LogInTabControl1.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInTabControl1.UpLineColour = System.Drawing.Color.FromArgb(0, 160, 199);
			TabPage1.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			TabPage1.Controls.Add(LogInLabel16);
			TabPage1.Controls.Add(personProgress);
			TabPage1.Controls.Add(personSearchResults);
			TabPage1.Controls.Add(nameSearch);
			TabPage1.Controls.Add(location);
			TabPage1.Controls.Add(LogInLabel3);
			TabPage1.Controls.Add(lastName);
			TabPage1.Controls.Add(firstName);
			TabPage1.Controls.Add(LogInLabel2);
			TabPage1.Controls.Add(LogInLabel1);
			TabPage1.Location = new System.Drawing.Point(4, 36);
			TabPage1.Name = "TabPage1";
			TabPage1.Padding = new System.Windows.Forms.Padding(3);
			TabPage1.Size = new System.Drawing.Size(435, 427);
			TabPage1.TabIndex = 0;
			TabPage1.Text = "Person Search";
			LogInLabel16.AutoSize = true;
			LogInLabel16.BackColor = System.Drawing.Color.Transparent;
			LogInLabel16.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel16.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel16.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel16.Location = new System.Drawing.Point(212, 48);
			LogInLabel16.Name = "LogInLabel16";
			LogInLabel16.Size = new System.Drawing.Size(55, 15);
			LogInLabel16.TabIndex = 13;
			LogInLabel16.Text = "Progress:";
			personProgress.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			personProgress.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			personProgress.FontColour = System.Drawing.Color.FromArgb(50, 50, 50);
			personProgress.Location = new System.Drawing.Point(274, 44);
			personProgress.Maximum = 100;
			personProgress.Name = "personProgress";
			personProgress.ProgressColour = System.Drawing.Color.FromArgb(0, 160, 199);
			personProgress.SecondColour = System.Drawing.Color.FromArgb(0, 145, 184);
			personProgress.Size = new System.Drawing.Size(153, 25);
			personProgress.TabIndex = 12;
			personProgress.Text = "personProgress";
			personProgress.TwoColour = true;
			personProgress.Value = 0;
			personSearchResults.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			personSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			personSearchResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			personSearchResults.ForeColor = System.Drawing.SystemColors.Info;
			personSearchResults.FormattingEnabled = true;
			personSearchResults.HorizontalScrollbar = true;
			personSearchResults.ItemHeight = 17;
			personSearchResults.Location = new System.Drawing.Point(9, 112);
			personSearchResults.Name = "personSearchResults";
			personSearchResults.Size = new System.Drawing.Size(418, 289);
			personSearchResults.TabIndex = 11;
			nameSearch.BackColor = System.Drawing.Color.Transparent;
			nameSearch.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			nameSearch.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			nameSearch.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			nameSearch.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			nameSearch.Location = new System.Drawing.Point(9, 76);
			nameSearch.Name = "nameSearch";
			nameSearch.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			nameSearch.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			nameSearch.Size = new System.Drawing.Size(418, 30);
			nameSearch.TabIndex = 8;
			nameSearch.Text = "Search";
			location.BackColor = System.Drawing.Color.Transparent;
			location.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			location.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			location.Location = new System.Drawing.Point(274, 6);
			location.MaxLength = 32767;
			location.Multiline = false;
			location.Name = "location";
			location.ReadOnly = false;
			location.Size = new System.Drawing.Size(153, 29);
			location.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			location.TabIndex = 5;
			location.Text = "Zip Code, City, or State";
			location.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			location.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			location.UseSystemPasswordChar = false;
			LogInLabel3.AutoSize = true;
			LogInLabel3.BackColor = System.Drawing.Color.Transparent;
			LogInLabel3.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel3.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel3.Location = new System.Drawing.Point(212, 13);
			LogInLabel3.Name = "LogInLabel3";
			LogInLabel3.Size = new System.Drawing.Size(56, 15);
			LogInLabel3.TabIndex = 4;
			LogInLabel3.Text = "Location:";
			lastName.BackColor = System.Drawing.Color.Transparent;
			lastName.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			lastName.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			lastName.Location = new System.Drawing.Point(83, 41);
			lastName.MaxLength = 32767;
			lastName.Multiline = false;
			lastName.Name = "lastName";
			lastName.ReadOnly = false;
			lastName.Size = new System.Drawing.Size(117, 29);
			lastName.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			lastName.TabIndex = 3;
			lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			lastName.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			lastName.UseSystemPasswordChar = false;
			firstName.BackColor = System.Drawing.Color.Transparent;
			firstName.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			firstName.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			firstName.Location = new System.Drawing.Point(83, 6);
			firstName.MaxLength = 32767;
			firstName.Multiline = false;
			firstName.Name = "firstName";
			firstName.ReadOnly = false;
			firstName.Size = new System.Drawing.Size(117, 29);
			firstName.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			firstName.TabIndex = 2;
			firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			firstName.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			firstName.UseSystemPasswordChar = false;
			LogInLabel2.AutoSize = true;
			LogInLabel2.BackColor = System.Drawing.Color.Transparent;
			LogInLabel2.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel2.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel2.Location = new System.Drawing.Point(6, 48);
			LogInLabel2.Name = "LogInLabel2";
			LogInLabel2.Size = new System.Drawing.Size(66, 15);
			LogInLabel2.TabIndex = 1;
			LogInLabel2.Text = "Last Name:";
			LogInLabel1.AutoSize = true;
			LogInLabel1.BackColor = System.Drawing.Color.Transparent;
			LogInLabel1.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel1.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel1.Location = new System.Drawing.Point(6, 14);
			LogInLabel1.Name = "LogInLabel1";
			LogInLabel1.Size = new System.Drawing.Size(67, 15);
			LogInLabel1.TabIndex = 0;
			LogInLabel1.Text = "First Name:";
			TabPage2.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			TabPage2.Controls.Add(LogInLabel17);
			TabPage2.Controls.Add(emailProgress);
			TabPage2.Controls.Add(emailSearchResults);
			TabPage2.Controls.Add(emailSearch);
			TabPage2.Controls.Add(email);
			TabPage2.Controls.Add(LogInLabel4);
			TabPage2.Location = new System.Drawing.Point(4, 36);
			TabPage2.Name = "TabPage2";
			TabPage2.Padding = new System.Windows.Forms.Padding(3);
			TabPage2.Size = new System.Drawing.Size(435, 427);
			TabPage2.TabIndex = 1;
			TabPage2.Text = "Email Search";
			LogInLabel17.AutoSize = true;
			LogInLabel17.BackColor = System.Drawing.Color.Transparent;
			LogInLabel17.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel17.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel17.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel17.Location = new System.Drawing.Point(6, 45);
			LogInLabel17.Name = "LogInLabel17";
			LogInLabel17.Size = new System.Drawing.Size(55, 15);
			LogInLabel17.TabIndex = 14;
			LogInLabel17.Text = "Progress:";
			emailProgress.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			emailProgress.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			emailProgress.FontColour = System.Drawing.Color.FromArgb(50, 50, 50);
			emailProgress.Location = new System.Drawing.Point(67, 41);
			emailProgress.Maximum = 100;
			emailProgress.Name = "emailProgress";
			emailProgress.ProgressColour = System.Drawing.Color.FromArgb(0, 160, 199);
			emailProgress.SecondColour = System.Drawing.Color.FromArgb(0, 145, 184);
			emailProgress.Size = new System.Drawing.Size(360, 25);
			emailProgress.TabIndex = 13;
			emailProgress.Text = "emailProgress";
			emailProgress.TwoColour = true;
			emailProgress.Value = 0;
			emailSearchResults.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			emailSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			emailSearchResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			emailSearchResults.ForeColor = System.Drawing.SystemColors.Info;
			emailSearchResults.FormattingEnabled = true;
			emailSearchResults.HorizontalScrollbar = true;
			emailSearchResults.ItemHeight = 17;
			emailSearchResults.Location = new System.Drawing.Point(9, 111);
			emailSearchResults.Name = "emailSearchResults";
			emailSearchResults.Size = new System.Drawing.Size(418, 306);
			emailSearchResults.TabIndex = 12;
			emailSearch.BackColor = System.Drawing.Color.Transparent;
			emailSearch.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			emailSearch.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			emailSearch.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			emailSearch.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			emailSearch.Location = new System.Drawing.Point(9, 76);
			emailSearch.Name = "emailSearch";
			emailSearch.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			emailSearch.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			emailSearch.Size = new System.Drawing.Size(418, 30);
			emailSearch.TabIndex = 2;
			emailSearch.Text = "Search";
			email.BackColor = System.Drawing.Color.Transparent;
			email.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			email.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			email.Location = new System.Drawing.Point(67, 6);
			email.MaxLength = 32767;
			email.Multiline = false;
			email.Name = "email";
			email.ReadOnly = false;
			email.Size = new System.Drawing.Size(360, 29);
			email.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			email.TabIndex = 1;
			email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			email.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			email.UseSystemPasswordChar = false;
			LogInLabel4.AutoSize = true;
			LogInLabel4.BackColor = System.Drawing.Color.Transparent;
			LogInLabel4.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel4.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel4.Location = new System.Drawing.Point(6, 13);
			LogInLabel4.Name = "LogInLabel4";
			LogInLabel4.Size = new System.Drawing.Size(39, 15);
			LogInLabel4.TabIndex = 0;
			LogInLabel4.Text = "Email:";
			TabPage3.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			TabPage3.Controls.Add(LogInLabel18);
			TabPage3.Controls.Add(usernameProgress);
			TabPage3.Controls.Add(usernameSearchResults);
			TabPage3.Controls.Add(userSearch);
			TabPage3.Controls.Add(usernameSearch);
			TabPage3.Controls.Add(LogInLabel5);
			TabPage3.Location = new System.Drawing.Point(4, 36);
			TabPage3.Name = "TabPage3";
			TabPage3.Size = new System.Drawing.Size(435, 427);
			TabPage3.TabIndex = 2;
			TabPage3.Text = "Username Search";
			LogInLabel18.AutoSize = true;
			LogInLabel18.BackColor = System.Drawing.Color.Transparent;
			LogInLabel18.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel18.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel18.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel18.Location = new System.Drawing.Point(6, 46);
			LogInLabel18.Name = "LogInLabel18";
			LogInLabel18.Size = new System.Drawing.Size(55, 15);
			LogInLabel18.TabIndex = 16;
			LogInLabel18.Text = "Progress:";
			usernameProgress.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			usernameProgress.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			usernameProgress.FontColour = System.Drawing.Color.FromArgb(50, 50, 50);
			usernameProgress.Location = new System.Drawing.Point(105, 41);
			usernameProgress.Maximum = 100;
			usernameProgress.Name = "usernameProgress";
			usernameProgress.ProgressColour = System.Drawing.Color.FromArgb(0, 160, 199);
			usernameProgress.SecondColour = System.Drawing.Color.FromArgb(0, 145, 184);
			usernameProgress.Size = new System.Drawing.Size(322, 25);
			usernameProgress.TabIndex = 15;
			usernameProgress.Text = "LogInProgressBar1";
			usernameProgress.TwoColour = true;
			usernameProgress.Value = 0;
			usernameSearchResults.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			usernameSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			usernameSearchResults.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			usernameSearchResults.ForeColor = System.Drawing.SystemColors.Info;
			usernameSearchResults.FormattingEnabled = true;
			usernameSearchResults.HorizontalScrollbar = true;
			usernameSearchResults.ItemHeight = 17;
			usernameSearchResults.Location = new System.Drawing.Point(9, 111);
			usernameSearchResults.Name = "usernameSearchResults";
			usernameSearchResults.Size = new System.Drawing.Size(418, 306);
			usernameSearchResults.TabIndex = 13;
			userSearch.BackColor = System.Drawing.Color.Transparent;
			userSearch.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			userSearch.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			userSearch.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			userSearch.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			userSearch.Location = new System.Drawing.Point(9, 76);
			userSearch.Name = "userSearch";
			userSearch.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			userSearch.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			userSearch.Size = new System.Drawing.Size(418, 30);
			userSearch.TabIndex = 6;
			userSearch.Text = "Search";
			usernameSearch.BackColor = System.Drawing.Color.Transparent;
			usernameSearch.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			usernameSearch.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			usernameSearch.Location = new System.Drawing.Point(105, 6);
			usernameSearch.MaxLength = 32767;
			usernameSearch.Multiline = false;
			usernameSearch.Name = "usernameSearch";
			usernameSearch.ReadOnly = false;
			usernameSearch.Size = new System.Drawing.Size(322, 29);
			usernameSearch.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			usernameSearch.TabIndex = 5;
			usernameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			usernameSearch.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			usernameSearch.UseSystemPasswordChar = false;
			LogInLabel5.AutoSize = true;
			LogInLabel5.BackColor = System.Drawing.Color.Transparent;
			LogInLabel5.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel5.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel5.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel5.Location = new System.Drawing.Point(6, 14);
			LogInLabel5.Name = "LogInLabel5";
			LogInLabel5.Size = new System.Drawing.Size(93, 15);
			LogInLabel5.TabIndex = 4;
			LogInLabel5.Text = "Enter Username:";
			TabPage4.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
			TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			TabPage4.Controls.Add(LogInGroupBox2);
			TabPage4.Controls.Add(LogInGroupBox1);
			TabPage4.Location = new System.Drawing.Point(4, 36);
			TabPage4.Name = "TabPage4";
			TabPage4.Size = new System.Drawing.Size(435, 427);
			TabPage4.TabIndex = 3;
			TabPage4.Text = "Extra Tools";
			LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			LogInGroupBox2.Controls.Add(exportButton);
			LogInGroupBox2.Controls.Add(otherInfo);
			LogInGroupBox2.Controls.Add(LogInLabel15);
			LogInGroupBox2.Controls.Add(emailTemplate);
			LogInGroupBox2.Controls.Add(LogInLabel14);
			LogInGroupBox2.Controls.Add(addressTemplate);
			LogInGroupBox2.Controls.Add(LogInLabel13);
			LogInGroupBox2.Controls.Add(phoneTemplate);
			LogInGroupBox2.Controls.Add(LogInLabel12);
			LogInGroupBox2.Controls.Add(ageTemplate);
			LogInGroupBox2.Controls.Add(LogInLabel11);
			LogInGroupBox2.Controls.Add(nameTemplate);
			LogInGroupBox2.Controls.Add(LogInLabel10);
			LogInGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
			LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(42, 42, 42);
			LogInGroupBox2.Location = new System.Drawing.Point(2, 181);
			LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(47, 47, 47);
			LogInGroupBox2.Name = "LogInGroupBox2";
			LogInGroupBox2.Size = new System.Drawing.Size(432, 241);
			LogInGroupBox2.TabIndex = 1;
			LogInGroupBox2.Text = "Dox Export";
			LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			exportButton.BackColor = System.Drawing.Color.Transparent;
			exportButton.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			exportButton.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			exportButton.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			exportButton.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			exportButton.Location = new System.Drawing.Point(9, 208);
			exportButton.Name = "exportButton";
			exportButton.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			exportButton.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			exportButton.Size = new System.Drawing.Size(416, 30);
			exportButton.TabIndex = 12;
			exportButton.Text = "Export";
			otherInfo.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			otherInfo.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			otherInfo.Location = new System.Drawing.Point(198, 71);
			otherInfo.Name = "otherInfo";
			otherInfo.Size = new System.Drawing.Size(227, 133);
			otherInfo.TabIndex = 11;
			otherInfo.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel15.AutoSize = true;
			LogInLabel15.BackColor = System.Drawing.Color.Transparent;
			LogInLabel15.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel15.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel15.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel15.Location = new System.Drawing.Point(195, 42);
			LogInLabel15.Name = "LogInLabel15";
			LogInLabel15.Size = new System.Drawing.Size(64, 15);
			LogInLabel15.TabIndex = 10;
			LogInLabel15.Text = "Other Info:";
			emailTemplate.BackColor = System.Drawing.Color.Transparent;
			emailTemplate.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			emailTemplate.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			emailTemplate.Location = new System.Drawing.Point(58, 175);
			emailTemplate.MaxLength = 32767;
			emailTemplate.Multiline = false;
			emailTemplate.Name = "emailTemplate";
			emailTemplate.ReadOnly = false;
			emailTemplate.Size = new System.Drawing.Size(131, 29);
			emailTemplate.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			emailTemplate.TabIndex = 9;
			emailTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			emailTemplate.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			emailTemplate.UseSystemPasswordChar = false;
			LogInLabel14.AutoSize = true;
			LogInLabel14.BackColor = System.Drawing.Color.Transparent;
			LogInLabel14.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel14.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel14.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel14.Location = new System.Drawing.Point(6, 183);
			LogInLabel14.Name = "LogInLabel14";
			LogInLabel14.Size = new System.Drawing.Size(39, 15);
			LogInLabel14.TabIndex = 8;
			LogInLabel14.Text = "Email:";
			addressTemplate.BackColor = System.Drawing.Color.Transparent;
			addressTemplate.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			addressTemplate.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			addressTemplate.Location = new System.Drawing.Point(58, 140);
			addressTemplate.MaxLength = 32767;
			addressTemplate.Multiline = false;
			addressTemplate.Name = "addressTemplate";
			addressTemplate.ReadOnly = false;
			addressTemplate.Size = new System.Drawing.Size(131, 29);
			addressTemplate.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			addressTemplate.TabIndex = 7;
			addressTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			addressTemplate.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			addressTemplate.UseSystemPasswordChar = false;
			LogInLabel13.AutoSize = true;
			LogInLabel13.BackColor = System.Drawing.Color.Transparent;
			LogInLabel13.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel13.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel13.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel13.Location = new System.Drawing.Point(6, 147);
			LogInLabel13.Name = "LogInLabel13";
			LogInLabel13.Size = new System.Drawing.Size(52, 15);
			LogInLabel13.TabIndex = 6;
			LogInLabel13.Text = "Address:";
			phoneTemplate.BackColor = System.Drawing.Color.Transparent;
			phoneTemplate.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			phoneTemplate.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			phoneTemplate.Location = new System.Drawing.Point(58, 105);
			phoneTemplate.MaxLength = 32767;
			phoneTemplate.Multiline = false;
			phoneTemplate.Name = "phoneTemplate";
			phoneTemplate.ReadOnly = false;
			phoneTemplate.Size = new System.Drawing.Size(131, 29);
			phoneTemplate.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			phoneTemplate.TabIndex = 5;
			phoneTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			phoneTemplate.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			phoneTemplate.UseSystemPasswordChar = false;
			LogInLabel12.AutoSize = true;
			LogInLabel12.BackColor = System.Drawing.Color.Transparent;
			LogInLabel12.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel12.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel12.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel12.Location = new System.Drawing.Point(6, 112);
			LogInLabel12.Name = "LogInLabel12";
			LogInLabel12.Size = new System.Drawing.Size(44, 15);
			LogInLabel12.TabIndex = 4;
			LogInLabel12.Text = "Phone:";
			ageTemplate.BackColor = System.Drawing.Color.Transparent;
			ageTemplate.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			ageTemplate.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			ageTemplate.Location = new System.Drawing.Point(58, 70);
			ageTemplate.MaxLength = 32767;
			ageTemplate.Multiline = false;
			ageTemplate.Name = "ageTemplate";
			ageTemplate.ReadOnly = false;
			ageTemplate.Size = new System.Drawing.Size(131, 29);
			ageTemplate.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			ageTemplate.TabIndex = 3;
			ageTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			ageTemplate.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			ageTemplate.UseSystemPasswordChar = false;
			LogInLabel11.AutoSize = true;
			LogInLabel11.BackColor = System.Drawing.Color.Transparent;
			LogInLabel11.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel11.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel11.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel11.Location = new System.Drawing.Point(6, 77);
			LogInLabel11.Name = "LogInLabel11";
			LogInLabel11.Size = new System.Drawing.Size(31, 15);
			LogInLabel11.TabIndex = 2;
			LogInLabel11.Text = "Age:";
			nameTemplate.BackColor = System.Drawing.Color.Transparent;
			nameTemplate.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			nameTemplate.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			nameTemplate.Location = new System.Drawing.Point(58, 35);
			nameTemplate.MaxLength = 32767;
			nameTemplate.Multiline = false;
			nameTemplate.Name = "nameTemplate";
			nameTemplate.ReadOnly = false;
			nameTemplate.Size = new System.Drawing.Size(131, 29);
			nameTemplate.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			nameTemplate.TabIndex = 1;
			nameTemplate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			nameTemplate.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			nameTemplate.UseSystemPasswordChar = false;
			LogInLabel10.AutoSize = true;
			LogInLabel10.BackColor = System.Drawing.Color.Transparent;
			LogInLabel10.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel10.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel10.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel10.Location = new System.Drawing.Point(6, 42);
			LogInLabel10.Name = "LogInLabel10";
			LogInLabel10.Size = new System.Drawing.Size(42, 15);
			LogInLabel10.TabIndex = 0;
			LogInLabel10.Text = "Name:";
			LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			LogInGroupBox1.Controls.Add(mapButton);
			LogInGroupBox1.Controls.Add(zipCode);
			LogInGroupBox1.Controls.Add(LogInLabel9);
			LogInGroupBox1.Controls.Add(latLong);
			LogInGroupBox1.Controls.Add(LogInLabel8);
			LogInGroupBox1.Controls.Add(cityState);
			LogInGroupBox1.Controls.Add(LogInLabel7);
			LogInGroupBox1.Controls.Add(ipSearchButton);
			LogInGroupBox1.Controls.Add(ipText);
			LogInGroupBox1.Controls.Add(LogInLabel6);
			LogInGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
			LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(42, 42, 42);
			LogInGroupBox1.Location = new System.Drawing.Point(2, 0);
			LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(47, 47, 47);
			LogInGroupBox1.Name = "LogInGroupBox1";
			LogInGroupBox1.Size = new System.Drawing.Size(432, 181);
			LogInGroupBox1.TabIndex = 0;
			LogInGroupBox1.Text = "IP Tracker";
			LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			mapButton.BackColor = System.Drawing.Color.Transparent;
			mapButton.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			mapButton.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			mapButton.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			mapButton.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			mapButton.Location = new System.Drawing.Point(333, 109);
			mapButton.Name = "mapButton";
			mapButton.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			mapButton.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			mapButton.Size = new System.Drawing.Size(94, 29);
			mapButton.TabIndex = 10;
			mapButton.Text = "Map";
			zipCode.BackColor = System.Drawing.Color.Transparent;
			zipCode.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			zipCode.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			zipCode.Location = new System.Drawing.Point(107, 144);
			zipCode.MaxLength = 32767;
			zipCode.Multiline = false;
			zipCode.Name = "zipCode";
			zipCode.ReadOnly = false;
			zipCode.Size = new System.Drawing.Size(221, 29);
			zipCode.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			zipCode.TabIndex = 9;
			zipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			zipCode.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			zipCode.UseSystemPasswordChar = false;
			LogInLabel9.AutoSize = true;
			LogInLabel9.BackColor = System.Drawing.Color.Transparent;
			LogInLabel9.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel9.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel9.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel9.Location = new System.Drawing.Point(6, 151);
			LogInLabel9.Name = "LogInLabel9";
			LogInLabel9.Size = new System.Drawing.Size(58, 15);
			LogInLabel9.TabIndex = 8;
			LogInLabel9.Text = "Zip Code:";
			latLong.BackColor = System.Drawing.Color.Transparent;
			latLong.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			latLong.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			latLong.Location = new System.Drawing.Point(107, 109);
			latLong.MaxLength = 32767;
			latLong.Multiline = false;
			latLong.Name = "latLong";
			latLong.ReadOnly = false;
			latLong.Size = new System.Drawing.Size(221, 29);
			latLong.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			latLong.TabIndex = 7;
			latLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			latLong.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			latLong.UseSystemPasswordChar = false;
			LogInLabel8.AutoSize = true;
			LogInLabel8.BackColor = System.Drawing.Color.Transparent;
			LogInLabel8.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel8.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel8.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel8.Location = new System.Drawing.Point(3, 116);
			LogInLabel8.Name = "LogInLabel8";
			LogInLabel8.Size = new System.Drawing.Size(102, 15);
			LogInLabel8.TabIndex = 6;
			LogInLabel8.Text = "Approx. Lat/Long:";
			cityState.BackColor = System.Drawing.Color.Transparent;
			cityState.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			cityState.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			cityState.Location = new System.Drawing.Point(107, 74);
			cityState.MaxLength = 32767;
			cityState.Multiline = false;
			cityState.Name = "cityState";
			cityState.ReadOnly = false;
			cityState.Size = new System.Drawing.Size(221, 29);
			cityState.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			cityState.TabIndex = 5;
			cityState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			cityState.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			cityState.UseSystemPasswordChar = false;
			LogInLabel7.AutoSize = true;
			LogInLabel7.BackColor = System.Drawing.Color.Transparent;
			LogInLabel7.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel7.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel7.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel7.Location = new System.Drawing.Point(3, 81);
			LogInLabel7.Name = "LogInLabel7";
			LogInLabel7.Size = new System.Drawing.Size(62, 15);
			LogInLabel7.TabIndex = 3;
			LogInLabel7.Text = "City/State:";
			ipSearchButton.BackColor = System.Drawing.Color.Transparent;
			ipSearchButton.BaseColour = System.Drawing.Color.FromArgb(42, 42, 42);
			ipSearchButton.BorderColour = System.Drawing.Color.FromArgb(25, 25, 25);
			ipSearchButton.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			ipSearchButton.HoverColour = System.Drawing.Color.FromArgb(52, 52, 52);
			ipSearchButton.Location = new System.Drawing.Point(333, 36);
			ipSearchButton.Name = "ipSearchButton";
			ipSearchButton.PressedColour = System.Drawing.Color.FromArgb(47, 47, 47);
			ipSearchButton.ProgressColour = System.Drawing.Color.FromArgb(0, 191, 255);
			ipSearchButton.Size = new System.Drawing.Size(94, 29);
			ipSearchButton.TabIndex = 2;
			ipSearchButton.Text = "Search";
			ipText.BackColor = System.Drawing.Color.Transparent;
			ipText.BackgroundColour = System.Drawing.Color.FromArgb(42, 42, 42);
			ipText.BorderColour = System.Drawing.Color.FromArgb(35, 35, 35);
			ipText.Location = new System.Drawing.Point(107, 36);
			ipText.MaxLength = 32767;
			ipText.Multiline = false;
			ipText.Name = "ipText";
			ipText.ReadOnly = false;
			ipText.Size = new System.Drawing.Size(221, 29);
			ipText.Style = Dox_Tool_V2.LogInNormalTextBox.Styles.NotRounded;
			ipText.TabIndex = 1;
			ipText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			ipText.TextColour = System.Drawing.Color.FromArgb(255, 255, 255);
			ipText.UseSystemPasswordChar = false;
			LogInLabel6.AutoSize = true;
			LogInLabel6.BackColor = System.Drawing.Color.Transparent;
			LogInLabel6.Font = new System.Drawing.Font("Segoe UI", 9f);
			LogInLabel6.FontColour = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel6.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			LogInLabel6.Location = new System.Drawing.Point(3, 43);
			LogInLabel6.Name = "LogInLabel6";
			LogInLabel6.Size = new System.Drawing.Size(95, 15);
			LogInLabel6.TabIndex = 0;
			LogInLabel6.Text = "Enter IP Address:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(447, 504);
			base.Controls.Add(LogInThemeContainer1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Dox Tool By Drizzy V2";
			base.TransparencyKey = System.Drawing.Color.Fuchsia;
			LogInThemeContainer1.ResumeLayout(false);
			LogInTabControl1.ResumeLayout(false);
			TabPage1.ResumeLayout(false);
			TabPage1.PerformLayout();
			TabPage2.ResumeLayout(false);
			TabPage2.PerformLayout();
			TabPage3.ResumeLayout(false);
			TabPage3.PerformLayout();
			TabPage4.ResumeLayout(false);
			LogInGroupBox2.ResumeLayout(false);
			LogInGroupBox2.PerformLayout();
			LogInGroupBox1.ResumeLayout(false);
			LogInGroupBox1.PerformLayout();
			ResumeLayout(false);
		}
	}
}
