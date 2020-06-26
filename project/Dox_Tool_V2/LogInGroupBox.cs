using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInGroupBox : ContainerControl
	{
		private Color _MainColour;

		private Color _HeaderColour;

		private Color _TextColour;

		private Color _BorderColour;

		[Category("Colours")]
		public Color BorderColour
		{
			get
			{
				return _BorderColour;
			}
			set
			{
				_BorderColour = value;
			}
		}

		[Category("Colours")]
		public Color TextColour
		{
			get
			{
				return _TextColour;
			}
			set
			{
				_TextColour = value;
			}
		}

		[Category("Colours")]
		public Color HeaderColour
		{
			get
			{
				return _HeaderColour;
			}
			set
			{
				_HeaderColour = value;
			}
		}

		[Category("Colours")]
		public Color MainColour
		{
			get
			{
				return _MainColour;
			}
			set
			{
				_MainColour = value;
			}
		}

		public LogInGroupBox()
		{
			_MainColour = Color.FromArgb(47, 47, 47);
			_HeaderColour = Color.FromArgb(42, 42, 42);
			_TextColour = Color.FromArgb(255, 255, 255);
			_BorderColour = Color.FromArgb(35, 35, 35);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.Size = new Size(160, 110);
			Font = new Font("Segoe UI", 10f, FontStyle.Bold);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(Color.FromArgb(54, 54, 54));
			graphics2.FillRectangle(new SolidBrush(_MainColour), new Rectangle(0, 28, base.Width, base.Height));
			checked
			{
				graphics2.FillRectangle(new SolidBrush(_HeaderColour), new Rectangle(0, 0, (int)Math.Round(graphics2.MeasureString(Text, Font).Width + 7f), 28));
				graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Point(5, 5));
				Point[] points = new Point[7]
				{
					new Point(0, 0),
					new Point((int)Math.Round(graphics2.MeasureString(Text, Font).Width + 7f), 0),
					new Point((int)Math.Round(graphics2.MeasureString(Text, Font).Width + 7f), 28),
					new Point(base.Width - 1, 28),
					new Point(base.Width - 1, base.Height - 1),
					new Point(1, base.Height - 1),
					new Point(1, 1)
				};
				graphics2.DrawLines(new Pen(_BorderColour), points);
				graphics2.DrawLine(new Pen(_BorderColour, 2f), new Point(0, 28), new Point((int)Math.Round(graphics2.MeasureString(Text, Font).Width + 7f), 28));
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
