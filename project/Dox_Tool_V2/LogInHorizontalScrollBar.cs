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
	[DefaultEvent("Scroll")]
	public class LogInHorizontalScrollBar : Control
	{
		public delegate void ScrollEventHandler(object sender);

		private int ThumbMovement;

		private Rectangle LSA;

		private Rectangle RSA;

		private Rectangle Shaft;

		private Rectangle Thumb;

		private bool ShowThumb;

		private bool ThumbPressed;

		private int _ThumbSize;

		private int _Minimum;

		private int _Maximum;

		private int _Value;

		private int _SmallChange;

		private int _ButtonSize;

		private int _LargeChange;

		private Color _ThumbBorder;

		private Color _LineColour;

		private Color _ArrowColour;

		private Color _BaseColour;

		private Color _ThumbColour;

		private Color _ThumbSecondBorder;

		private Color _FirstBorder;

		private Color _SecondBorder;

		private bool ThumbDown;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ScrollEventHandler ScrollEvent;

		[Category("Colours")]
		public Color ThumbBorder
		{
			get
			{
				return _ThumbBorder;
			}
			set
			{
				_ThumbBorder = value;
			}
		}

		[Category("Colours")]
		public Color LineColour
		{
			get
			{
				return _LineColour;
			}
			set
			{
				_LineColour = value;
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
		public Color ThumbColour
		{
			get
			{
				return _ThumbColour;
			}
			set
			{
				_ThumbColour = value;
			}
		}

		[Category("Colours")]
		public Color ThumbSecondBorder
		{
			get
			{
				return _ThumbSecondBorder;
			}
			set
			{
				_ThumbSecondBorder = value;
			}
		}

		[Category("Colours")]
		public Color FirstBorder
		{
			get
			{
				return _FirstBorder;
			}
			set
			{
				_FirstBorder = value;
			}
		}

		[Category("Colours")]
		public Color SecondBorder
		{
			get
			{
				return _SecondBorder;
			}
			set
			{
				_SecondBorder = value;
			}
		}

		public int Minimum
		{
			get
			{
				return _Minimum;
			}
			set
			{
				_Minimum = value;
				if (value > _Value)
				{
					_Value = value;
				}
				if (value > _Maximum)
				{
					_Maximum = value;
				}
				InvalidateLayout();
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
				if (value < _Value)
				{
					_Value = value;
				}
				if (value < _Minimum)
				{
					_Minimum = value;
				}
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
					if (value < _Minimum)
					{
						_Value = _Minimum;
					}
					else if (value > _Maximum)
					{
						_Value = _Maximum;
					}
					else
					{
						_Value = value;
					}
					InvalidatePosition();
					ScrollEvent?.Invoke(this);
				}
			}
		}

		public int SmallChange
		{
			get
			{
				return _SmallChange;
			}
			set
			{
				if (value >= 1 && value <= 0 - ((_SmallChange == value) ? 1 : 0))
				{
				}
			}
		}

		public int LargeChange
		{
			get
			{
				return _LargeChange;
			}
			set
			{
				if (value >= 1)
				{
					_LargeChange = value;
				}
			}
		}

		public int ButtonSize
		{
			get
			{
				return _ButtonSize;
			}
			set
			{
				if (value < 16)
				{
					_ButtonSize = 16;
				}
				else
				{
					_ButtonSize = value;
				}
			}
		}

		public event ScrollEventHandler Scroll
		{
			[CompilerGenerated]
			add
			{
				ScrollEventHandler scrollEventHandler = ScrollEvent;
				ScrollEventHandler scrollEventHandler2;
				do
				{
					scrollEventHandler2 = scrollEventHandler;
					ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Combine(scrollEventHandler2, value);
					scrollEventHandler = Interlocked.CompareExchange(ref ScrollEvent, value2, scrollEventHandler2);
				}
				while ((object)scrollEventHandler != scrollEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				ScrollEventHandler scrollEventHandler = ScrollEvent;
				ScrollEventHandler scrollEventHandler2;
				do
				{
					scrollEventHandler2 = scrollEventHandler;
					ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Remove(scrollEventHandler2, value);
					scrollEventHandler = Interlocked.CompareExchange(ref ScrollEvent, value2, scrollEventHandler2);
				}
				while ((object)scrollEventHandler != scrollEventHandler2);
			}
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			InvalidateLayout();
		}

		private void InvalidateLayout()
		{
			LSA = new Rectangle(0, 1, 0, base.Height);
			checked
			{
				Shaft = new Rectangle(LSA.Right + 1, 0, base.Width - 3, base.Height);
				ShowThumb = (_Maximum - _Minimum != 0);
				Thumb = new Rectangle(0, 1, _ThumbSize, base.Height - 3);
				ScrollEvent?.Invoke(this);
				InvalidatePosition();
			}
		}

		private void InvalidatePosition()
		{
			Thumb.X = checked((int)Math.Round((double)(_Value - _Minimum) / (double)(_Maximum - _Minimum) * (double)(Shaft.Width - _ThumbSize) + 1.0));
			Invalidate();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || !ShowThumb)
			{
				return;
			}
			checked
			{
				if (LSA.Contains(e.Location))
				{
					ThumbMovement = _Value - _SmallChange;
				}
				else if (RSA.Contains(e.Location))
				{
					ThumbMovement = _Value + _SmallChange;
				}
				else
				{
					if (Thumb.Contains(e.Location))
					{
						ThumbDown = true;
						return;
					}
					if (e.X < Thumb.X)
					{
						ThumbMovement = _Value - _LargeChange;
					}
					else
					{
						ThumbMovement = _Value + _LargeChange;
					}
				}
				Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum);
				InvalidatePosition();
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			checked
			{
				if (ThumbDown && ShowThumb)
				{
					int num = e.X - LSA.Width - unchecked(_ThumbSize / 2);
					int num2 = Shaft.Width - _ThumbSize;
					ThumbMovement = (int)Math.Round((double)num / (double)num2 * (double)(_Maximum - _Minimum)) + _Minimum;
					Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum);
					InvalidatePosition();
				}
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			ThumbDown = false;
		}

		public LogInHorizontalScrollBar()
		{
			_ThumbSize = 24;
			_Minimum = 0;
			_Maximum = 100;
			_Value = 0;
			_SmallChange = 1;
			_ButtonSize = 16;
			_LargeChange = 10;
			_ThumbBorder = Color.FromArgb(35, 35, 35);
			_LineColour = Color.FromArgb(23, 119, 151);
			_ArrowColour = Color.FromArgb(37, 37, 37);
			_BaseColour = Color.FromArgb(47, 47, 47);
			_ThumbColour = Color.FromArgb(55, 55, 55);
			_ThumbSecondBorder = Color.FromArgb(65, 65, 65);
			_FirstBorder = Color.FromArgb(55, 55, 55);
			_SecondBorder = Color.FromArgb(35, 35, 35);
			ThumbDown = false;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.Height = 18;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(Color.FromArgb(47, 47, 47));
			checked
			{
				Point[] points = new Point[10]
				{
					new Point(5, (int)Math.Round((double)base.Height / 2.0)),
					new Point(13, (int)Math.Round((double)base.Height / 4.0)),
					new Point(13, (int)Math.Round((double)base.Height / 2.0 - 2.0)),
					new Point(base.Width - 13, (int)Math.Round((double)base.Height / 2.0 - 2.0)),
					new Point(base.Width - 13, (int)Math.Round((double)base.Height / 4.0)),
					new Point(base.Width - 5, (int)Math.Round((double)base.Height / 2.0)),
					new Point(base.Width - 13, (int)Math.Round((double)base.Height - (double)base.Height / 4.0 - 1.0)),
					new Point(base.Width - 13, (int)Math.Round((double)base.Height / 2.0 + 2.0)),
					new Point(13, (int)Math.Round((double)base.Height / 2.0 + 2.0)),
					new Point(13, (int)Math.Round((double)base.Height - (double)base.Height / 4.0 - 1.0))
				};
				graphics2.FillPolygon(new SolidBrush(_ArrowColour), points);
				graphics2.FillRectangle(new SolidBrush(_ThumbColour), Thumb);
				graphics2.DrawRectangle(new Pen(_ThumbBorder), Thumb);
				graphics2.DrawRectangle(new Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2);
				graphics2.DrawLine(new Pen(_LineColour, 2f), new Point(Thumb.X + 4, (int)Math.Round((double)Thumb.Height / 2.0 + 1.0)), new Point(Thumb.Right - 4, (int)Math.Round((double)Thumb.Height / 2.0 + 1.0)));
				graphics2.DrawRectangle(new Pen(_FirstBorder), 0, 0, base.Width - 1, base.Height - 1);
				graphics2.DrawRectangle(new Pen(_SecondBorder), 1, 1, base.Width - 3, base.Height - 3);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
