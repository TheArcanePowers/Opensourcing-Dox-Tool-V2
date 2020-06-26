using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInStatusBar : Control
	{
		public enum LinesCount
		{
			One = 1,
			Two
		}

		public enum Alignments
		{
			Left,
			Center,
			Right
		}

		private Color _BaseColour;

		private Color _BorderColour;

		private Color _TextColour;

		private Color _RectColour;

		private bool _ShowLine;

		private LinesCount _LinesToShow;

		private Alignments _Alignment;

		private bool _ShowBorder;

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

		[Category("Control")]
		public Alignments Alignment
		{
			get
			{
				return _Alignment;
			}
			set
			{
				_Alignment = value;
			}
		}

		[Category("Control")]
		public LinesCount LinesToShow
		{
			get
			{
				return _LinesToShow;
			}
			set
			{
				_LinesToShow = value;
			}
		}

		public bool ShowBorder
		{
			get
			{
				return _ShowBorder;
			}
			set
			{
				_ShowBorder = value;
			}
		}

		[Category("Colours")]
		public Color RectangleColor
		{
			get
			{
				return _RectColour;
			}
			set
			{
				_RectColour = value;
			}
		}

		public bool ShowLine
		{
			get
			{
				return _ShowLine;
			}
			set
			{
				_ShowLine = value;
			}
		}

		protected override void CreateHandle()
		{
			base.CreateHandle();
			Dock = DockStyle.Bottom;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public LogInStatusBar()
		{
			_BaseColour = Color.FromArgb(42, 42, 42);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_TextColour = Color.White;
			_RectColour = Color.FromArgb(21, 117, 149);
			_ShowLine = true;
			_LinesToShow = LinesCount.One;
			_Alignment = Alignments.Left;
			_ShowBorder = true;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 9f);
			ForeColor = Color.White;
			base.Size = new Size(base.Width, 20);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.Clear(BaseColour);
			graphics2.FillRectangle(new SolidBrush(BaseColour), rect);
			checked
			{
				if (_ShowLine)
				{
					switch (_LinesToShow)
					{
					case LinesCount.One:
						if (_Alignment == Alignments.Left)
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(22, 2, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Near,
								LineAlignment = StringAlignment.Near
							});
						}
						else if (_Alignment == Alignments.Center)
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(0, 0, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Center,
								LineAlignment = StringAlignment.Center
							});
						}
						else
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(0, 0, base.Width - 5, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Far,
								LineAlignment = StringAlignment.Center
							});
						}
						graphics2.FillRectangle(new SolidBrush(_RectColour), new Rectangle(5, 9, 14, 3));
						break;
					case LinesCount.Two:
						if (_Alignment == Alignments.Left)
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(22, 2, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Near,
								LineAlignment = StringAlignment.Near
							});
						}
						else if (_Alignment == Alignments.Center)
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(0, 0, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Center,
								LineAlignment = StringAlignment.Center
							});
						}
						else
						{
							graphics2.DrawString(Text, Font, new SolidBrush(_TextColour), new Rectangle(0, 0, base.Width - 22, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Far,
								LineAlignment = StringAlignment.Center
							});
						}
						graphics2.FillRectangle(new SolidBrush(_RectColour), new Rectangle(5, 9, 14, 3));
						graphics2.FillRectangle(new SolidBrush(_RectColour), new Rectangle(base.Width - 20, 9, 14, 3));
						break;
					}
				}
				else
				{
					graphics2.DrawString(Text, Font, Brushes.White, new Rectangle(5, 2, base.Width, base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Near
					});
				}
				if (_ShowBorder)
				{
					graphics2.DrawLine(new Pen(_BorderColour, 2f), new Point(0, 0), new Point(base.Width, 0));
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
