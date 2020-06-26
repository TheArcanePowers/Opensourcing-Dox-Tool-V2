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
	public class LogInOnOffSwitch : Control
	{
		public enum Toggles
		{
			Toggled,
			NotToggled
		}

		public delegate void ToggledChangedEventHandler();

		private Toggles _Toggled;

		private int MouseXLoc;

		private int ToggleLocation;

		private Color _BaseColour;

		private Color _BorderColour;

		private Color _TextColour;

		private Color _NonToggledTextColour;

		private Color _ToggledColour;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ToggledChangedEventHandler ToggledChangedEvent;

		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return _BaseColour;
			}
			set
			{
				_BaseColour = value;
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
		public Color NonToggledTextColourderColour
		{
			get
			{
				return _NonToggledTextColour;
			}
			set
			{
				_NonToggledTextColour = value;
			}
		}

		[Category("Colours")]
		public Color ToggledColour
		{
			get
			{
				return _ToggledColour;
			}
			set
			{
				_ToggledColour = value;
			}
		}

		public Toggles Toggled
		{
			get
			{
				return _Toggled;
			}
			set
			{
				_Toggled = value;
				Invalidate();
			}
		}

		public event ToggledChangedEventHandler ToggledChanged
		{
			[CompilerGenerated]
			add
			{
				ToggledChangedEventHandler toggledChangedEventHandler = ToggledChangedEvent;
				ToggledChangedEventHandler toggledChangedEventHandler2;
				do
				{
					toggledChangedEventHandler2 = toggledChangedEventHandler;
					ToggledChangedEventHandler value2 = (ToggledChangedEventHandler)Delegate.Combine(toggledChangedEventHandler2, value);
					toggledChangedEventHandler = Interlocked.CompareExchange(ref ToggledChangedEvent, value2, toggledChangedEventHandler2);
				}
				while ((object)toggledChangedEventHandler != toggledChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ToggledChangedEventHandler toggledChangedEventHandler = ToggledChangedEvent;
				ToggledChangedEventHandler toggledChangedEventHandler2;
				do
				{
					toggledChangedEventHandler2 = toggledChangedEventHandler;
					ToggledChangedEventHandler value2 = (ToggledChangedEventHandler)Delegate.Remove(toggledChangedEventHandler2, value);
					toggledChangedEventHandler = Interlocked.CompareExchange(ref ToggledChangedEvent, value2, toggledChangedEventHandler2);
				}
				while ((object)toggledChangedEventHandler != toggledChangedEventHandler2);
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			MouseXLoc = e.Location.X;
			Invalidate();
			if (e.X < checked(base.Width - 40) && e.X > 40)
			{
				Cursor = Cursors.IBeam;
			}
			else
			{
				Cursor = Cursors.Arrow;
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (MouseXLoc > checked(base.Width - 39))
			{
				_Toggled = Toggles.Toggled;
				ToggledValue();
			}
			else if (MouseXLoc < 39)
			{
				_Toggled = Toggles.NotToggled;
				ToggledValue();
			}
			Invalidate();
		}

		private void ToggledValue()
		{
			checked
			{
				if (_Toggled != 0)
				{
					if (ToggleLocation < 100)
					{
						ToggleLocation += 10;
					}
				}
				else if (ToggleLocation > 0)
				{
					ToggleLocation -= 10;
				}
				Invalidate();
			}
		}

		public LogInOnOffSwitch()
		{
			_Toggled = Toggles.NotToggled;
			ToggleLocation = 0;
			_BaseColour = Color.FromArgb(42, 42, 42);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_TextColour = Color.FromArgb(255, 255, 255);
			_NonToggledTextColour = Color.FromArgb(155, 155, 155);
			_ToggledColour = Color.FromArgb(23, 119, 151);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.Clear(base.Parent.FindForm().BackColor);
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(0, 0, 39, base.Height));
			checked
			{
				graphics2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(base.Width - 40, 0, base.Width, base.Height));
				graphics2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(38, 9, base.Width - 40, 5));
				Point[] points = new Point[13]
				{
					new Point(0, 0),
					new Point(39, 0),
					new Point(39, 9),
					new Point(base.Width - 40, 9),
					new Point(base.Width - 40, 0),
					new Point(base.Width - 2, 0),
					new Point(base.Width - 2, base.Height - 1),
					new Point(base.Width - 40, base.Height - 1),
					new Point(base.Width - 40, 14),
					new Point(39, 14),
					new Point(39, base.Height - 1),
					new Point(0, base.Height - 1),
					default(Point)
				};
				graphics2.DrawLines(new Pen(_BorderColour, 2f), points);
				if (_Toggled == Toggles.Toggled)
				{
					graphics2.FillRectangle(new SolidBrush(_ToggledColour), new Rectangle((int)Math.Round((double)base.Width / 2.0), 10, (int)Math.Round((double)base.Width / 2.0 - 38.0), 3));
					graphics2.FillRectangle(new SolidBrush(_ToggledColour), new Rectangle(base.Width - 39, 2, 36, base.Height - 5));
				}
				if (_Toggled == Toggles.Toggled)
				{
					graphics2.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(_TextColour), new Rectangle(2, -1, (int)Math.Round((double)(base.Width - 20) + 6.666666666666667), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Far,
						LineAlignment = StringAlignment.Center
					});
					graphics2.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(_NonToggledTextColour), new Rectangle(7, -1, (int)Math.Round((double)(base.Width - 20) + 6.666666666666667), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					});
				}
				else if (_Toggled == Toggles.NotToggled)
				{
					graphics2.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(_TextColour), new Rectangle(7, -1, (int)Math.Round((double)(base.Width - 20) + 6.666666666666667), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					});
					graphics2.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(_NonToggledTextColour), new Rectangle(2, -1, (int)Math.Round((double)(base.Width - 20) + 6.666666666666667), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Far,
						LineAlignment = StringAlignment.Center
					});
				}
				graphics2.DrawLine(new Pen(_BorderColour, 2f), new Point((int)Math.Round((double)base.Width / 2.0), 0), new Point((int)Math.Round((double)base.Width / 2.0), base.Height));
				graphics2 = null;
			}
		}
	}
}
