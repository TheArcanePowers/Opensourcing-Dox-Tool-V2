using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInTrackBar : Control
	{
		public delegate void ValueChangedEventHandler();

		private int _Maximum;

		private int _Value;

		private bool CaptureMovement;

		private Rectangle Bar;

		private Size Track;

		private Color _TextColour;

		private Color _BorderColour;

		private Color _BarBaseColour;

		private Color _StripColour;

		private Color _StripAmountColour;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ValueChangedEventHandler ValueChangedEvent;

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
		public Color BarBaseColour
		{
			get
			{
				return _BarBaseColour;
			}
			set
			{
				_BarBaseColour = value;
			}
		}

		[Category("Colours")]
		public Color StripColour
		{
			get
			{
				return _StripColour;
			}
			set
			{
				_StripColour = value;
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
		public Color StripAmountColour
		{
			get
			{
				return _StripAmountColour;
			}
			set
			{
				_StripAmountColour = value;
			}
		}

		public int Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value > 0)
				{
					_Maximum = value;
				}
				if (value < _Value)
				{
					_Value = value;
				}
				Invalidate();
			}
		}

		public int Value
		{
			get
			{
				return _Value;
			}
			set
			{
				if (value != _Value)
				{
					if (value < 0)
					{
						_Value = 0;
					}
					else if (value > _Maximum)
					{
						_Value = _Maximum;
					}
					else
					{
						_Value = value;
					}
					Invalidate();
					ValueChangedEvent?.Invoke();
				}
			}
		}

		public event ValueChangedEventHandler ValueChanged
		{
			[CompilerGenerated]
			add
			{
				ValueChangedEventHandler valueChangedEventHandler = ValueChangedEvent;
				ValueChangedEventHandler valueChangedEventHandler2;
				do
				{
					valueChangedEventHandler2 = valueChangedEventHandler;
					ValueChangedEventHandler value2 = (ValueChangedEventHandler)Delegate.Combine(valueChangedEventHandler2, value);
					valueChangedEventHandler = Interlocked.CompareExchange(ref ValueChangedEvent, value2, valueChangedEventHandler2);
				}
				while ((object)valueChangedEventHandler != valueChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ValueChangedEventHandler valueChangedEventHandler = ValueChangedEvent;
				ValueChangedEventHandler valueChangedEventHandler2;
				do
				{
					valueChangedEventHandler2 = valueChangedEventHandler;
					ValueChangedEventHandler value2 = (ValueChangedEventHandler)Delegate.Remove(valueChangedEventHandler2, value);
					valueChangedEventHandler = Interlocked.CompareExchange(ref ValueChangedEvent, value2, valueChangedEventHandler2);
				}
				while ((object)valueChangedEventHandler != valueChangedEventHandler2);
			}
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			BackColor = Color.Transparent;
			base.OnHandleCreated(e);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			Rectangle rect = new Rectangle(new Point(e.Location.X, e.Location.Y), new Size(1, 1));
			checked
			{
				Rectangle rectangle = new Rectangle(10, 10, base.Width - 21, base.Height - 21);
				if (new Rectangle(new Point(rectangle.X + (int)Math.Round((double)rectangle.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)Track.Width / 2.0 - 1.0), 0), new Size(Track.Width, base.Height)).IntersectsWith(rect))
				{
					CaptureMovement = true;
				}
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			CaptureMovement = false;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			checked
			{
				if (CaptureMovement)
				{
					Point point = new Point(e.X, e.Y);
					Rectangle rectangle = new Rectangle(10, 10, base.Width - 21, base.Height - 21);
					Value = (int)Math.Round((double)Maximum * ((double)(point.X - rectangle.X) / (double)rectangle.Width));
				}
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			CaptureMovement = false;
		}

		public LogInTrackBar()
		{
			_Maximum = 10;
			_Value = 0;
			CaptureMovement = false;
			Bar = checked(new Rectangle(0, 10, base.Width - 21, base.Height - 21));
			Track = new Size(25, 14);
			_TextColour = Color.FromArgb(255, 255, 255);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BarBaseColour = Color.FromArgb(47, 47, 47);
			_StripColour = Color.FromArgb(42, 42, 42);
			_StripAmountColour = Color.FromArgb(23, 119, 151);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			checked
			{
				Bar = new Rectangle(13, 11, base.Width - 27, base.Height - 21);
				graphics2.Clear(base.Parent.FindForm().BackColor);
				graphics2.SmoothingMode = SmoothingMode.AntiAlias;
				graphics2.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
				graphics2.FillRectangle(new SolidBrush(_StripColour), new Rectangle(3, (int)Math.Round((double)base.Height / 2.0 - 4.0), base.Width - 5, 8));
				graphics2.DrawRectangle(new Pen(_BorderColour, 2f), new Rectangle(4, (int)Math.Round((double)base.Height / 2.0 - 4.0), base.Width - 5, 8));
				graphics2.FillRectangle(new SolidBrush(_StripAmountColour), new Rectangle(4, (int)Math.Round((double)base.Height / 2.0 - 4.0), (int)Math.Round((double)Bar.Width * ((double)Value / (double)Maximum)) + (int)Math.Round((double)Track.Width / 2.0), 8));
				graphics2.FillRectangle(new SolidBrush(_BarBaseColour), Bar.X + (int)Math.Round((double)Bar.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)Track.Width / 2.0), Bar.Y + (int)Math.Round((double)Bar.Height / 2.0) - (int)Math.Round((double)Track.Height / 2.0), Track.Width, Track.Height);
				graphics2.DrawRectangle(new Pen(_BorderColour, 2f), Bar.X + (int)Math.Round((double)Bar.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)Track.Width / 2.0), Bar.Y + (int)Math.Round((double)Bar.Height / 2.0) - (int)Math.Round((double)Track.Height / 2.0), Track.Width, Track.Height);
				graphics2.DrawString(Conversions.ToString(_Value), new Font("Segoe UI", 6.5f, FontStyle.Regular), new SolidBrush(_TextColour), new Rectangle(Bar.X + (int)Math.Round((double)Bar.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)Track.Width / 2.0), Bar.Y + (int)Math.Round((double)Bar.Height / 2.0) - (int)Math.Round((double)Track.Height / 2.0), Track.Width - 1, Track.Height), new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				});
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
