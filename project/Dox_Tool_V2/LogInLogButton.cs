using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInLogButton : Control
	{
		private DrawHelpers.MouseState State;

		private Color _ArcColour;

		private Color _ArrowColour;

		private Color _ArrowBorderColour;

		private Color _BorderColour;

		private Color _HoverColour;

		private Color _PressedColour;

		private Color _NormalColour;

		[Category("Colours")]
		public Color ArcColour
		{
			get
			{
				return _ArcColour;
			}
			set
			{
				_ArcColour = value;
			}
		}

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
		public Color ArrowColour
		{
			get
			{
				return _ArrowColour;
			}
			set
			{
				_ArrowColour = value;
			}
		}

		[Category("Colours")]
		public Color ArrowBorderColour
		{
			get
			{
				return _ArrowBorderColour;
			}
			set
			{
				_ArrowBorderColour = value;
			}
		}

		[Category("Colours")]
		public Color HoverColour
		{
			get
			{
				return _HoverColour;
			}
			set
			{
				_HoverColour = value;
			}
		}

		[Category("Colours")]
		public Color PressedColour
		{
			get
			{
				return _PressedColour;
			}
			set
			{
				_PressedColour = value;
			}
		}

		[Category("Colours")]
		public Color NormalColour
		{
			get
			{
				return _NormalColour;
			}
			set
			{
				_NormalColour = value;
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			State = DrawHelpers.MouseState.Down;
			Invalidate();
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			State = DrawHelpers.MouseState.Over;
			Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			State = DrawHelpers.MouseState.Over;
			Invalidate();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			State = DrawHelpers.MouseState.None;
			Invalidate();
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Size = new Size(50, 50);
		}

		public LogInLogButton()
		{
			State = DrawHelpers.MouseState.None;
			_ArcColour = Color.FromArgb(43, 43, 43);
			_ArrowColour = Color.FromArgb(235, 233, 234);
			_ArrowBorderColour = Color.FromArgb(170, 170, 170);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_HoverColour = Color.FromArgb(0, 130, 169);
			_PressedColour = Color.FromArgb(0, 145, 184);
			_NormalColour = Color.FromArgb(0, 160, 199);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.Size = new Size(50, 50);
			BackColor = Color.Transparent;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			GraphicsPath graphicsPath = new GraphicsPath();
			GraphicsPath graphicsPath2 = new GraphicsPath();
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(BackColor);
			Point[] points = new Point[7]
			{
				new Point(18, 22),
				new Point(28, 22),
				new Point(28, 18),
				new Point(34, 25),
				new Point(28, 32),
				new Point(28, 28),
				new Point(18, 28)
			};
			checked
			{
				switch (State)
				{
				case DrawHelpers.MouseState.None:
					graphics2.FillEllipse(new SolidBrush(Color.FromArgb(56, 56, 56)), new Rectangle(3, 3, base.Width - 3 - 3, base.Height - 3 - 3));
					graphics2.DrawArc(new Pen(new SolidBrush(_ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(_NormalColour), new Rectangle(5, 5, base.Height - 11, base.Height - 11));
					graphics2.FillPolygon(new SolidBrush(_ArrowColour), points);
					graphics2.DrawPolygon(new Pen(_ArrowBorderColour), points);
					break;
				case DrawHelpers.MouseState.Over:
					graphics2.DrawArc(new Pen(new SolidBrush(_ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(6, 6, base.Height - 13, base.Height - 13));
					graphics2.FillPolygon(new SolidBrush(_ArrowColour), points);
					graphics2.DrawPolygon(new Pen(_ArrowBorderColour), points);
					break;
				case DrawHelpers.MouseState.Down:
					graphics2.DrawArc(new Pen(new SolidBrush(_ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(_PressedColour), new Rectangle(6, 6, base.Height - 13, base.Height - 13));
					graphics2.FillPolygon(new SolidBrush(_ArrowColour), points);
					graphics2.DrawPolygon(new Pen(_ArrowBorderColour), points);
					break;
				}
				graphicsPath.Dispose();
				graphicsPath2.Dispose();
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
