using System;
using System.Collections;
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
	public class LogInRadioButton : Control
	{
		public delegate void CheckedChangedEventHandler(object sender);

		private bool _Checked;

		private DrawHelpers.MouseState State;

		private Color _HoverColour;

		private Color _CheckedColour;

		private Color _BorderColour;

		private Color _BackColour;

		private Color _TextColour;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CheckedChangedEventHandler CheckedChangedEvent;

		[Category("Colours")]
		public Color HighlightColour
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
				InvalidateControls();
				CheckedChangedEvent?.Invoke(this);
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

		protected override void OnClick(EventArgs e)
		{
			if (!_Checked)
			{
				Checked = true;
			}
			base.OnClick(e);
		}

		private void InvalidateControls()
		{
			if (base.IsHandleCreated && _Checked)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = base.Parent.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control control = (Control)enumerator.Current;
						if (control != this && control is LogInRadioButton)
						{
							((LogInRadioButton)control).Checked = false;
							Invalidate();
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			InvalidateControls();
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

		public LogInRadioButton()
		{
			State = DrawHelpers.MouseState.None;
			_HoverColour = Color.FromArgb(50, 49, 51);
			_CheckedColour = Color.FromArgb(173, 173, 174);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BackColour = Color.FromArgb(54, 54, 54);
			_TextColour = Color.FromArgb(255, 255, 255);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			Cursor = Cursors.Hand;
			base.Size = new Size(100, 22);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				Rectangle rect = new Rectangle(1, 1, base.Height - 2, base.Height - 2);
				Rectangle rect2 = new Rectangle(6, 6, base.Height - 12, base.Height - 12);
				Graphics graphics2 = graphics;
				graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				graphics2.SmoothingMode = SmoothingMode.HighQuality;
				graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics2.Clear(_BackColour);
				graphics2.FillEllipse(new SolidBrush(_BackColour), rect);
				graphics2.DrawEllipse(new Pen(_BorderColour, 2f), rect);
				if (Checked)
				{
					DrawHelpers.MouseState state = State;
					if (state == DrawHelpers.MouseState.Over)
					{
						graphics2.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(2, 2, base.Height - 4, base.Height - 4));
					}
					graphics2.FillEllipse(new SolidBrush(_CheckedColour), rect2);
				}
				else
				{
					DrawHelpers.MouseState state2 = State;
					if (state2 == DrawHelpers.MouseState.Over)
					{
						graphics2.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(2, 2, base.Height - 4, base.Height - 4));
					}
				}
				graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(24, 3, base.Width, base.Height), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Near
				});
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
