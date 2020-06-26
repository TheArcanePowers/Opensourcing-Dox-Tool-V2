using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInThemeContainer : ContainerControl
	{
		private bool _AllowClose;

		private bool _AllowMinimize;

		private bool _AllowMaximize;

		private int _FontSize;

		private readonly Font _Font;

		private bool _ShowIcon;

		private DrawHelpers.MouseState State;

		private int MouseXLoc;

		private int MouseYLoc;

		private bool CaptureMovement;

		private const int MoveHeight = 35;

		private Point MouseP;

		private Color _FontColour;

		private Color _BaseColour;

		private Color _ContainerColour;

		private Color _BorderColour;

		private Color _HoverColour;

		[Category("Control")]
		public int FontSize
		{
			get
			{
				return _FontSize;
			}
			set
			{
				_FontSize = value;
			}
		}

		[Category("Control")]
		public bool AllowMinimize
		{
			get
			{
				return _AllowMinimize;
			}
			set
			{
				_AllowMinimize = value;
			}
		}

		[Category("Control")]
		public bool AllowMaximize
		{
			get
			{
				return _AllowMaximize;
			}
			set
			{
				_AllowMaximize = value;
			}
		}

		[Category("Control")]
		public bool ShowIcon
		{
			get
			{
				return _ShowIcon;
			}
			set
			{
				_ShowIcon = value;
			}
		}

		[Category("Control")]
		public bool AllowClose
		{
			get
			{
				return _AllowClose;
			}
			set
			{
				_AllowClose = value;
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
		public Color ContainerColour
		{
			get
			{
				return _ContainerColour;
			}
			set
			{
				_ContainerColour = value;
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

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			CaptureMovement = false;
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

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			MouseXLoc = e.Location.X;
			MouseYLoc = e.Location.Y;
			Invalidate();
			if (CaptureMovement)
			{
				base.Parent.Location = Control.MousePosition - (Size)MouseP;
			}
			if (e.X < checked(base.Width - 90) && e.Y > 35)
			{
				Cursor = Cursors.Arrow;
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
				if (MouseXLoc > base.Width - 39 && MouseXLoc < base.Width - 16 && MouseYLoc < 22)
				{
					if (_AllowClose)
					{
						Environment.Exit(0);
					}
				}
				else if (MouseXLoc > base.Width - 89 && MouseXLoc < base.Width - 66 && MouseYLoc < 22)
				{
					if (_AllowMinimize)
					{
						switch (FindForm().WindowState)
						{
						case FormWindowState.Normal:
							FindForm().WindowState = FormWindowState.Minimized;
							break;
						case FormWindowState.Maximized:
							FindForm().WindowState = FormWindowState.Minimized;
							break;
						}
					}
				}
				else if ((e.Button == MouseButtons.Left) & new Rectangle(0, 0, base.Width - 90, 35).Contains(e.Location))
				{
					CaptureMovement = true;
					MouseP = e.Location;
				}
				else if ((e.Button == MouseButtons.Left) & new Rectangle(base.Width - 90, 22, 75, 13).Contains(e.Location))
				{
					CaptureMovement = true;
					MouseP = e.Location;
				}
				else if ((e.Button == MouseButtons.Left) & new Rectangle(base.Width - 15, 0, 15, 35).Contains(e.Location))
				{
					CaptureMovement = true;
					MouseP = e.Location;
				}
				else
				{
					Focus();
				}
				State = DrawHelpers.MouseState.Down;
				Invalidate();
			}
		}

		public LogInThemeContainer()
		{
			_AllowClose = true;
			_AllowMinimize = true;
			_AllowMaximize = false;
			_FontSize = 12;
			_Font = new Font("Segoe UI", _FontSize);
			_ShowIcon = true;
			State = DrawHelpers.MouseState.None;
			CaptureMovement = false;
			MouseP = new Point(0, 0);
			_FontColour = Color.FromArgb(255, 255, 255);
			_BaseColour = Color.FromArgb(35, 35, 35);
			_ContainerColour = Color.FromArgb(54, 54, 54);
			_BorderColour = Color.FromArgb(60, 60, 60);
			_HoverColour = Color.FromArgb(42, 42, 42);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			BackColor = _BaseColour;
			Dock = DockStyle.Fill;
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			base.ParentForm.AllowTransparency = false;
			base.ParentForm.TransparencyKey = Color.Fuchsia;
			base.ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
			Dock = DockStyle.Fill;
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(0, 0, base.Width, base.Height));
			checked
			{
				graphics2.FillRectangle(new SolidBrush(_ContainerColour), new Rectangle(2, 35, base.Width - 4, base.Height - 37));
				graphics2.DrawRectangle(new Pen(_BorderColour), new Rectangle(0, 0, base.Width, base.Height));
				Point[] points = new Point[4]
				{
					new Point(base.Width - 90, 0),
					new Point(base.Width - 90, 22),
					new Point(base.Width - 15, 22),
					new Point(base.Width - 15, 0)
				};
				graphics2.DrawLines(new Pen(_BorderColour), points);
				graphics2.DrawLine(new Pen(_BorderColour), base.Width - 65, 0, base.Width - 65, 22);
				DrawHelpers.MouseState state = State;
				if (state == DrawHelpers.MouseState.Over)
				{
					if (MouseXLoc > base.Width - 39 && MouseXLoc < base.Width - 16 && MouseYLoc < 22)
					{
						graphics2.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(base.Width - 39, 0, 23, 22));
					}
					else if (MouseXLoc > base.Width - 64 && MouseXLoc < base.Width - 41 && MouseYLoc < 22)
					{
						graphics2.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(base.Width - 64, 0, 23, 22));
					}
					else if (MouseXLoc > base.Width - 89 && MouseXLoc < base.Width - 66 && MouseYLoc < 22)
					{
						graphics2.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(base.Width - 89, 0, 23, 22));
					}
				}
				graphics2.DrawLine(new Pen(_BorderColour), base.Width - 40, 0, base.Width - 40, 22);
				graphics2.DrawLine(new Pen(_FontColour), base.Width - 33, 6, base.Width - 22, 16);
				graphics2.DrawLine(new Pen(_FontColour), base.Width - 33, 16, base.Width - 22, 6);
				graphics2.DrawLine(new Pen(_FontColour), base.Width - 83, 16, base.Width - 72, 16);
				if (_ShowIcon)
				{
					graphics2.DrawIcon(FindForm().Icon, new Rectangle(6, 6, 22, 22));
					graphics2.DrawString(Text, _Font, new SolidBrush(_FontColour), new RectangleF(31f, 0f, base.Width - 110, 35f), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Near
					});
				}
				else
				{
					graphics2.DrawString(Text, _Font, new SolidBrush(_FontColour), new RectangleF(3f, 0f, base.Width - 110, 35f), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Near
					});
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
