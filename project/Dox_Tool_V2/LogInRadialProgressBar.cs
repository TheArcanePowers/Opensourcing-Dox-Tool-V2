using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInRadialProgressBar : Control
	{
		private Color _BorderColour;

		private Color _BaseColour;

		private Color _ProgressColour;

		private int _Value;

		private int _Maximum;

		private int _StartingAngle;

		private int _RotationAngle;

		private readonly Font _Font;

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

		[Category("Control")]
		public int StartingAngle
		{
			get
			{
				return _StartingAngle;
			}
			set
			{
				_StartingAngle = value;
			}
		}

		[Category("Control")]
		public int RotationAngle
		{
			get
			{
				return _RotationAngle;
			}
			set
			{
				_RotationAngle = value;
			}
		}

		public void Increment(int Amount)
		{
			checked
			{
				Value += Amount;
			}
		}

		public LogInRadialProgressBar()
		{
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BaseColour = Color.FromArgb(42, 42, 42);
			_ProgressColour = Color.FromArgb(0, 160, 199);
			_Value = 0;
			_Maximum = 100;
			_StartingAngle = 110;
			_RotationAngle = 255;
			_Font = new Font("Segoe UI", 20f);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.Size = new Size(78, 78);
			BackColor = Color.Transparent;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(BackColor);
			int value = _Value;
			checked
			{
				if (value == 0)
				{
					graphics2.DrawArc(new Pen(new SolidBrush(_BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5);
					graphics2.DrawArc(new Pen(new SolidBrush(_BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle, _RotationAngle);
					graphics2.DrawString(Conversions.ToString(_Value), _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0 - 1.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else if (value == _Maximum)
				{
					graphics2.DrawArc(new Pen(new SolidBrush(_BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5);
					graphics2.DrawArc(new Pen(new SolidBrush(_BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle, _RotationAngle);
					graphics2.DrawArc(new Pen(new SolidBrush(_ProgressColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle, _RotationAngle);
					graphics2.DrawString(Conversions.ToString(_Value), _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0 - 1.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics2.DrawArc(new Pen(new SolidBrush(_BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5);
					graphics2.DrawArc(new Pen(new SolidBrush(_BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle, _RotationAngle);
					graphics2.DrawArc(new Pen(new SolidBrush(_ProgressColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, _StartingAngle, (int)Math.Round((double)_RotationAngle / (double)_Maximum * (double)_Value));
					graphics2.DrawString(Conversions.ToString(_Value), _Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0 - 1.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
