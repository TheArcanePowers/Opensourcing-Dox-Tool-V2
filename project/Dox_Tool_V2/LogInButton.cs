using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInButton : Control
	{
		private readonly Font _Font;

		private Color _ProgressColour;

		private Color _BorderColour;

		private Color _FontColour;

		private Color _MainColour;

		private Color _HoverColour;

		private Color _PressedColour;

		private DrawHelpers.MouseState State;

		[Category("Colours")]
		public Color ProgressColour
		{
			get
			{
				return _ProgressColour;
			}
			set
			{
				_ProgressColour = value;
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

		[Category("Colours")]
		public Color BaseColour
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

		public LogInButton()
		{
			_Font = new Font("Segoe UI", 9f);
			_ProgressColour = Color.FromArgb(0, 191, 255);
			_BorderColour = Color.FromArgb(25, 25, 25);
			_FontColour = Color.FromArgb(255, 255, 255);
			_MainColour = Color.FromArgb(42, 42, 42);
			_HoverColour = Color.FromArgb(52, 52, 52);
			_PressedColour = Color.FromArgb(47, 47, 47);
			State = default(DrawHelpers.MouseState);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.Size = new Size(75, 30);
			BackColor = Color.Transparent;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics2.Clear(BackColor);
			checked
			{
				switch (State)
				{
				case DrawHelpers.MouseState.None:
					graphics2.FillRectangle(new SolidBrush(_MainColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics2.DrawRectangle(new Pen(_BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					graphics2.DrawString(Text, _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Over:
					graphics2.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics2.DrawRectangle(new Pen(_BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
					graphics2.DrawString(Text, _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Down:
					graphics2.FillRectangle(new SolidBrush(_PressedColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics2.DrawRectangle(new Pen(_BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
					graphics2.DrawString(Text, _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				}
				graphics2 = null;
			}
		}
	}
}
