using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInNumeric : Control
	{
		private DrawHelpers.MouseState State;

		private int MouseXLoc;

		private int MouseYLoc;

		private long _Value;

		private long _Minimum;

		private long _Maximum;

		private bool BoolValue;

		private Color _BaseColour;

		private Color _ButtonColour;

		private Color _BorderColour;

		private Color _SecondBorderColour;

		private Color _FontColour;

		public long Value
		{
			get
			{
				return _Value;
			}
			set
			{
				if ((value <= _Maximum) & (value >= _Minimum))
				{
					_Value = value;
				}
				Invalidate();
			}
		}

		public long Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value > _Minimum)
				{
					_Maximum = value;
				}
				if (_Value > _Maximum)
				{
					_Value = _Maximum;
				}
				Invalidate();
			}
		}

		public long Minimum
		{
			get
			{
				return _Minimum;
			}
			set
			{
				if (value < _Maximum)
				{
					_Minimum = value;
				}
				if (_Value < _Minimum)
				{
					_Value = Minimum;
				}
				Invalidate();
			}
		}

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
		public Color ButtonColour
		{
			get
			{
				return _ButtonColour;
			}
			set
			{
				_ButtonColour = value;
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
		public Color SecondBorderColour
		{
			get
			{
				return _SecondBorderColour;
			}
			set
			{
				_SecondBorderColour = value;
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

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			MouseXLoc = e.Location.X;
			MouseYLoc = e.Location.Y;
			Invalidate();
			if (e.X < checked(base.Width - 47))
			{
				Cursor = Cursors.IBeam;
			}
			else
			{
				Cursor = Cursors.Hand;
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			checked
			{
				if (MouseXLoc > base.Width - 47 && MouseXLoc < base.Width - 3)
				{
					if (MouseXLoc < base.Width - 23)
					{
						if (Value + 1 <= _Maximum)
						{
							_Value++;
						}
					}
					else if (Value - 1 >= _Minimum)
					{
						_Value--;
					}
				}
				else
				{
					BoolValue = !BoolValue;
					Focus();
				}
				Invalidate();
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			try
			{
				if (BoolValue)
				{
					_Value = Conversions.ToLong(Conversions.ToString(_Value) + e.KeyChar);
				}
				if (_Value > _Maximum)
				{
					_Value = _Maximum;
				}
				Invalidate();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode == Keys.Back)
			{
				Value = 0L;
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 24;
		}

		public LogInNumeric()
		{
			State = DrawHelpers.MouseState.None;
			_Minimum = 0L;
			_Maximum = 9999999L;
			_BaseColour = Color.FromArgb(42, 42, 42);
			_ButtonColour = Color.FromArgb(47, 47, 47);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_SecondBorderColour = Color.FromArgb(0, 191, 255);
			_FontColour = Color.FromArgb(255, 255, 255);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 10f);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			StringFormat stringFormat = new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Center
			};
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.Clear(BackColor);
			graphics2.FillRectangle(new SolidBrush(_BaseColour), rect);
			checked
			{
				graphics2.FillRectangle(new SolidBrush(_ButtonColour), new Rectangle(base.Width - 48, 0, 48, base.Height));
				graphics2.DrawRectangle(new Pen(_BorderColour, 2f), rect);
				graphics2.DrawLine(new Pen(_SecondBorderColour), new Point(base.Width - 48, 1), new Point(base.Width - 48, base.Height - 2));
				graphics2.DrawLine(new Pen(_BorderColour), new Point(base.Width - 24, 1), new Point(base.Width - 24, base.Height - 2));
				graphics2.DrawLine(new Pen(_FontColour), new Point(base.Width - 36, 7), new Point(base.Width - 36, 17));
				graphics2.DrawLine(new Pen(_FontColour), new Point(base.Width - 31, 12), new Point(base.Width - 41, 12));
				graphics2.DrawLine(new Pen(_FontColour), new Point(base.Width - 17, 13), new Point(base.Width - 7, 13));
				graphics2.DrawString(Conversions.ToString(Value), Font, new SolidBrush(_FontColour), new Rectangle(5, 1, base.Width, base.Height), new StringFormat
				{
					LineAlignment = StringAlignment.Center
				});
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
