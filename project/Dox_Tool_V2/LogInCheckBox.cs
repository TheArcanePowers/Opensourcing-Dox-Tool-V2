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
	[DefaultEvent("CheckedChanged")]
	public class LogInCheckBox : Control
	{
		public delegate void CheckedChangedEventHandler(object sender);

		private bool _Checked;

		private DrawHelpers.MouseState State;

		private Color _CheckedColour;

		private Color _BorderColour;

		private Color _BackColour;

		private Color _TextColour;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckedChangedEventHandler CheckedChangedEvent;

		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return _BackColour;
			}
			set
			{
				_BackColour = value;
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
		public Color CheckedColour
		{
			get
			{
				return _CheckedColour;
			}
			set
			{
				_CheckedColour = value;
			}
		}

		[Category("Colours")]
		public Color FontColour
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

		public bool Checked
		{
			get
			{
				return _Checked;
			}
			set
			{
				_Checked = value;
				Invalidate();
			}
		}

		public event CheckedChangedEventHandler CheckedChanged
		{
			[CompilerGenerated]
			add
			{
				CheckedChangedEventHandler checkedChangedEventHandler = CheckedChangedEvent;
				CheckedChangedEventHandler checkedChangedEventHandler2;
				do
				{
					checkedChangedEventHandler2 = checkedChangedEventHandler;
					CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Combine(checkedChangedEventHandler2, value);
					checkedChangedEventHandler = Interlocked.CompareExchange(ref CheckedChangedEvent, value2, checkedChangedEventHandler2);
				}
				while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				CheckedChangedEventHandler checkedChangedEventHandler = CheckedChangedEvent;
				CheckedChangedEventHandler checkedChangedEventHandler2;
				do
				{
					checkedChangedEventHandler2 = checkedChangedEventHandler;
					CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Remove(checkedChangedEventHandler2, value);
					checkedChangedEventHandler = Interlocked.CompareExchange(ref CheckedChangedEvent, value2, checkedChangedEventHandler2);
				}
				while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		protected override void OnClick(EventArgs e)
		{
			_Checked = !_Checked;
			CheckedChangedEvent?.Invoke(this);
			base.OnClick(e);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 22;
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

		public LogInCheckBox()
		{
			State = DrawHelpers.MouseState.None;
			_CheckedColour = Color.FromArgb(173, 173, 174);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BackColour = Color.FromArgb(42, 42, 42);
			_TextColour = Color.FromArgb(255, 255, 255);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			Cursor = Cursors.Hand;
			base.Size = new Size(100, 22);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, 20, 20);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(Color.FromArgb(54, 54, 54));
			graphics2.FillRectangle(new SolidBrush(_BackColour), rect);
			graphics2.DrawRectangle(new Pen(_BorderColour), new Rectangle(1, 1, 18, 18));
			DrawHelpers.MouseState state = State;
			if (state == DrawHelpers.MouseState.Over)
			{
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(50, 49, 51)), rect);
				graphics2.DrawRectangle(new Pen(_BorderColour), new Rectangle(1, 1, 18, 18));
			}
			if (Checked)
			{
				Point[] points = new Point[6]
				{
					new Point(4, 11),
					new Point(6, 8),
					new Point(9, 12),
					new Point(15, 3),
					new Point(17, 6),
					new Point(9, 16)
				};
				graphics2.FillPolygon(new SolidBrush(_CheckedColour), points);
			}
			graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(24, 1, base.Width, checked(base.Height - 2)), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Center
			});
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics2 = null;
		}
	}
}
