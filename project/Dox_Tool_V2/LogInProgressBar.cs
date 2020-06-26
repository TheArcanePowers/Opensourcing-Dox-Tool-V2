using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInProgressBar : Control
	{
		private Color _ProgressColour;

		private Color _BorderColour;

		private Color _BaseColour;

		private Color _FontColour;

		private Color _SecondColour;

		private int _Value;

		private int _Maximum;

		private bool _TwoColour;

		public Color SecondColour
		{
			get
			{
				return _SecondColour;
			}
			set
			{
				_SecondColour = value;
			}
		}

		[Category("Control")]
		public bool TwoColour
		{
			get
			{
				return _TwoColour;
			}
			set
			{
				_TwoColour = value;
			}
		}

		[Category("Control")]
		public int Maximum
		{
			get
			{
				return _Maximum;
			}
			set
			{
				if (value < _Value)
				{
					_Value = value;
				}
				_Maximum = value;
				Invalidate();
			}
		}

		[Category("Control")]
		public int Value
		{
			get
			{
				if (_Value == 0)
				{
					return 0;
				}
				return _Value;
			}
			set
			{
				int num = value;
				if (num > _Maximum)
				{
					value = _Maximum;
					Invalidate();
				}
				_Value = value;
				Invalidate();
			}
		}

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

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 25;
		}

		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Height = 25;
		}

		public void Increment(int Amount)
		{
			checked
			{
				Value += Amount;
			}
		}

		public LogInProgressBar()
		{
			_ProgressColour = Color.FromArgb(0, 160, 199);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BaseColour = Color.FromArgb(42, 42, 42);
			_FontColour = Color.FromArgb(50, 50, 50);
			_SecondColour = Color.FromArgb(0, 145, 184);
			_Value = 0;
			_Maximum = 100;
			_TwoColour = true;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(BackColor);
			checked
			{
				int num = (int)Math.Round((double)_Value / (double)_Maximum * (double)base.Width);
				int value = Value;
				if (value == 0)
				{
					graphics2.FillRectangle(new SolidBrush(_BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					graphics2.DrawRectangle(new Pen(_BorderColour, 3f), rect);
				}
				else if (value == _Maximum)
				{
					graphics2.FillRectangle(new SolidBrush(_BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					if (_TwoColour)
					{
						graphics.SetClip(new Rectangle(0, -10, (int)Math.Round((double)(base.Width * _Value) / (double)_Maximum - 1.0), base.Height - 5));
						double num2 = (double)((base.Width - 1) * _Maximum) / (double)_Value;
						for (double num3 = 0.0; num3 <= num2; num3 += 25.0)
						{
							graphics.DrawLine(new Pen(new SolidBrush(_SecondColour), 7f), new Point((int)Math.Round(num3), 0), new Point((int)Math.Round(num3 - 15.0), base.Height));
						}
						graphics.ResetClip();
					}
					graphics2.DrawRectangle(new Pen(_BorderColour, 3f), rect);
				}
				else
				{
					graphics2.FillRectangle(new SolidBrush(_BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					if (_TwoColour)
					{
						graphics2.SetClip(new Rectangle(0, 0, (int)Math.Round((double)(base.Width * _Value) / (double)_Maximum - 1.0), base.Height - 1));
						double num4 = (double)((base.Width - 1) * _Maximum) / (double)_Value;
						for (double num5 = 0.0; num5 <= num4; num5 += 25.0)
						{
							graphics2.DrawLine(new Pen(new SolidBrush(_SecondColour), 7f), new Point((int)Math.Round(num5), 0), new Point((int)Math.Round(num5 - 10.0), base.Height));
						}
						graphics2.ResetClip();
					}
					graphics2.DrawRectangle(new Pen(_BorderColour, 3f), rect);
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
