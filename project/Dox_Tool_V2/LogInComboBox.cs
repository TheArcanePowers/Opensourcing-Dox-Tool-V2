using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInComboBox : ComboBox
	{
		private int _StartIndex;

		private Color _BorderColour;

		private Color _BaseColour;

		private Color _FontColour;

		private Color _LineColour;

		private Color _SqaureColour;

		private Color _ArrowColour;

		private Color _SqaureHoverColour;

		private DrawHelpers.MouseState State;

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
		public Color SqaureColour
		{
			get
			{
				return _SqaureColour;
			}
			set
			{
				_SqaureColour = value;
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
		public Color SqaureHoverColour
		{
			get
			{
				return _SqaureHoverColour;
			}
			set
			{
				_SqaureHoverColour = value;
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

		public int StartIndex
		{
			get
			{
				return _StartIndex;
			}
			set
			{
				_StartIndex = value;
				try
				{
					base.SelectedIndex = value;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				Invalidate();
			}
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

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			Invalidate();
			OnMouseClick(e);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			Invalidate();
			base.OnMouseUp(e);
		}

		public void ReplaceItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			checked
			{
				Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 1, e.Bounds.Height + 1);
				try
				{
					Graphics graphics = e.Graphics;
					if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
					{
						graphics.FillRectangle(new SolidBrush(_SqaureColour), rect);
						graphics.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), Font, new SolidBrush(_FontColour), 1f, e.Bounds.Top + 2);
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(_BaseColour), rect);
						graphics.DrawString(GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), Font, new SolidBrush(_FontColour), 1f, e.Bounds.Top + 2);
					}
					graphics = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				e.DrawFocusRectangle();
				Invalidate();
			}
		}

		public LogInComboBox()
		{
			base.DrawItem += ReplaceItem;
			_StartIndex = 0;
			_BorderColour = Color.FromArgb(35, 35, 35);
			_BaseColour = Color.FromArgb(42, 42, 42);
			_FontColour = Color.FromArgb(255, 255, 255);
			_LineColour = Color.FromArgb(23, 119, 151);
			_SqaureColour = Color.FromArgb(47, 47, 47);
			_ArrowColour = Color.FromArgb(30, 30, 30);
			_SqaureHoverColour = Color.FromArgb(52, 52, 52);
			State = DrawHelpers.MouseState.None;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			BackColor = Color.Transparent;
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			base.Width = 163;
			Font = new Font("Segoe UI", 10f);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(BackColor);
			checked
			{
				try
				{
					Rectangle rect = new Rectangle(base.Width - 25, 0, base.Width, base.Height);
					graphics2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(0, 0, base.Width - 25, base.Height));
					switch (State)
					{
					case DrawHelpers.MouseState.None:
						graphics2.FillRectangle(new SolidBrush(_SqaureColour), rect);
						break;
					case DrawHelpers.MouseState.Over:
						graphics2.FillRectangle(new SolidBrush(_SqaureHoverColour), rect);
						break;
					}
					graphics2.DrawLine(new Pen(_LineColour, 2f), new Point(base.Width - 26, 1), new Point(base.Width - 26, base.Height - 1));
					try
					{
						graphics2.DrawString(Text, Font, new SolidBrush(_FontColour), new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
						{
							LineAlignment = StringAlignment.Center,
							Alignment = StringAlignment.Near
						});
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					graphics2.DrawRectangle(new Pen(_BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					Point[] points = new Point[3]
					{
						new Point(base.Width - 17, 11),
						new Point(base.Width - 13, 5),
						new Point(base.Width - 9, 11)
					};
					graphics2.FillPolygon(new SolidBrush(_BorderColour), points);
					graphics2.DrawPolygon(new Pen(_ArrowColour), points);
					Point[] points2 = new Point[3]
					{
						new Point(base.Width - 17, 15),
						new Point(base.Width - 13, 21),
						new Point(base.Width - 9, 15)
					};
					graphics2.FillPolygon(new SolidBrush(_BorderColour), points2);
					graphics2.DrawPolygon(new Pen(_ArrowColour), points2);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
