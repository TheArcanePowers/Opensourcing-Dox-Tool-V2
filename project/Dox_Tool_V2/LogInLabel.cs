using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInLabel : Label
	{
		private Color _FontColour;

		[Category("Colours")]
		public Color FontColour
		{
			get
			{
				return _FontColour;
			}
			set
			{
				_FontColour = value;
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public LogInLabel()
		{
			_FontColour = Color.FromArgb(255, 255, 255);
			SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
			Font = new Font("Segoe UI", 9f);
			ForeColor = _FontColour;
			BackColor = Color.Transparent;
			Text = Text;
		}
	}
}
