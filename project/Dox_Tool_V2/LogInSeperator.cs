using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInSeperator : Control
	{
		public enum Style
		{
			Horizontal,
			Verticle
		}

		private Color _SeperatorColour;

		private Style _Alignment;

		private float _Thickness;

		[Category("Control")]
		public float Thickness
		{
			get
			{
				return _Thickness;
			}
			set
			{
				_Thickness = value;
			}
		}

		[Category("Control")]
		public Style Alignment
		{
			get
			{
				return _Alignment;
			}
			set
			{
				_Alignment = value;
			}
		}

		[Category("Colours")]
		public Color SeperatorColour
		{
			get
			{
				return _SeperatorColour;
			}
			set
			{
				_SeperatorColour = value;
			}
		}

		public LogInSeperator()
		{
			_SeperatorColour = Color.FromArgb(35, 35, 35);
			_Alignment = Style.Horizontal;
			_Thickness = 1f;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			BackColor = Color.Transparent;
			base.Size = new Size(20, 20);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
				Graphics graphics2 = graphics;
				graphics2.SmoothingMode = SmoothingMode.HighQuality;
				graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
				switch (_Alignment)
				{
				case Style.Horizontal:
					graphics2.DrawLine(new Pen(_SeperatorColour, _Thickness), new Point(0, (int)Math.Round((double)base.Height / 2.0)), new Point(base.Width, (int)Math.Round((double)base.Height / 2.0)));
					break;
				case Style.Verticle:
					graphics2.DrawLine(new Pen(_SeperatorColour, _Thickness), new Point((int)Math.Round((double)base.Width / 2.0), 0), new Point((int)Math.Round((double)base.Width / 2.0), base.Height));
					break;
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
