using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInNormalTextBox : Control
	{
		public enum Styles
		{
			Rounded,
			NotRounded
		}

		private DrawHelpers.MouseState State;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TB")]
		private TextBox _TB;

		private Color _BaseColour;

		private Color _TextColour;

		private Color _BorderColour;

		private Styles _Style;

		private HorizontalAlignment _TextAlign;

		private int _MaxLength;

		private bool _ReadOnly;

		private bool _UseSystemPasswordChar;

		private bool _Multiline;

		[field: AccessedThroughProperty("TB")]
		private virtual TextBox TB
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[Category("Options")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return _TextAlign;
			}
			set
			{
				_TextAlign = value;
				if (TB != null)
				{
					TB.TextAlign = value;
				}
			}
		}

		[Category("Options")]
		public int MaxLength
		{
			get
			{
				return _MaxLength;
			}
			set
			{
				_MaxLength = value;
				if (TB != null)
				{
					TB.MaxLength = value;
				}
			}
		}

		[Category("Options")]
		public bool ReadOnly
		{
			get
			{
				return _ReadOnly;
			}
			set
			{
				_ReadOnly = value;
				if (TB != null)
				{
					TB.ReadOnly = value;
				}
			}
		}

		[Category("Options")]
		public bool UseSystemPasswordChar
		{
			get
			{
				return _UseSystemPasswordChar;
			}
			set
			{
				_UseSystemPasswordChar = value;
				if (TB != null)
				{
					TB.UseSystemPasswordChar = value;
				}
			}
		}

		[Category("Options")]
		public bool Multiline
		{
			get
			{
				return _Multiline;
			}
			set
			{
				_Multiline = value;
				checked
				{
					if (TB != null)
					{
						TB.Multiline = value;
						if (value)
						{
							TB.Height = base.Height - 11;
						}
						else
						{
							base.Height = TB.Height + 11;
						}
					}
				}
			}
		}

		[Category("Options")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				if (TB != null)
				{
					TB.Text = value;
				}
			}
		}

		[Category("Options")]
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				checked
				{
					if (TB != null)
					{
						TB.Font = value;
						TB.Location = new Point(3, 5);
						TB.Width = base.Width - 6;
						if (!_Multiline)
						{
							base.Height = TB.Height + 11;
						}
					}
				}
			}
		}

		public Styles Style
		{
			get
			{
				return _Style;
			}
			set
			{
				_Style = value;
			}
		}

		[Category("Colours")]
		public Color BackgroundColour
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

		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(TB))
			{
				base.Controls.Add(TB);
			}
		}

		private void OnBaseTextChanged(object s, EventArgs e)
		{
			Text = TB.Text;
		}

		private void OnBaseKeyDown(object s, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				TB.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				TB.Copy();
				e.SuppressKeyPress = true;
			}
		}

		protected override void OnResize(EventArgs e)
		{
			TB.Location = new Point(5, 5);
			checked
			{
				TB.Width = base.Width - 10;
				if (_Multiline)
				{
					TB.Height = base.Height - 11;
				}
				else
				{
					base.Height = TB.Height + 11;
				}
				base.OnResize(e);
			}
		}

		public void SelectAll()
		{
			TB.Focus();
			TB.SelectAll();
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
			TB.Focus();
			Invalidate();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			State = DrawHelpers.MouseState.None;
			Invalidate();
		}

		public LogInNormalTextBox()
		{
			State = DrawHelpers.MouseState.None;
			_BaseColour = Color.FromArgb(42, 42, 42);
			_TextColour = Color.FromArgb(255, 255, 255);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_Style = Styles.NotRounded;
			_TextAlign = HorizontalAlignment.Left;
			_MaxLength = 32767;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			BackColor = Color.Transparent;
			TB = new TextBox();
			TB.Height = 190;
			TB.Font = new Font("Segoe UI", 10f);
			TB.Text = Text;
			TB.BackColor = Color.FromArgb(42, 42, 42);
			TB.ForeColor = Color.FromArgb(255, 255, 255);
			TB.MaxLength = _MaxLength;
			TB.Multiline = false;
			TB.ReadOnly = _ReadOnly;
			TB.UseSystemPasswordChar = _UseSystemPasswordChar;
			TB.BorderStyle = BorderStyle.None;
			TB.Location = new Point(5, 5);
			TB.Width = checked(base.Width - 35);
			TB.TextChanged += OnBaseTextChanged;
			TB.KeyDown += OnBaseKeyDown;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(BackColor);
			TB.BackColor = Color.FromArgb(42, 42, 42);
			TB.ForeColor = Color.FromArgb(255, 255, 255);
			switch (_Style)
			{
			case Styles.Rounded:
			{
				GraphicsPath graphicsPath = DrawHelpers.RoundRectangle(rectangle, 6);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(42, 42, 42)), graphicsPath);
				graphics2.DrawPath(new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)), 2f), graphicsPath);
				graphicsPath.Dispose();
				break;
			}
			case Styles.NotRounded:
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), checked(new Rectangle(0, 0, base.Width - 1, base.Height - 1)));
				graphics2.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)), 2f), new Rectangle(0, 0, base.Width, base.Height));
				break;
			}
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics2 = null;
		}
	}
}
