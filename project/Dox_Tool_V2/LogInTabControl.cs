using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInTabControl : TabControl
	{
		private Color _TextColour;

		private Color _BackTabColour;

		private Color _BaseColour;

		private Color _ActiveColour;

		private Color _BorderColour;

		private Color _UpLineColour;

		private Color _HorizLineColour;

		private StringFormat CenterSF;

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
		public Color UpLineColour
		{
			get
			{
				return _UpLineColour;
			}
			set
			{
				_UpLineColour = value;
			}
		}

		[Category("Colours")]
		public Color HorizontalLineColour
		{
			get
			{
				return _HorizLineColour;
			}
			set
			{
				_HorizLineColour = value;
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
		public Color BackTabColour
		{
			get
			{
				return _BackTabColour;
			}
			set
			{
				_BackTabColour = value;
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
		public Color ActiveColour
		{
			get
			{
				return _ActiveColour;
			}
			set
			{
				_ActiveColour = value;
			}
		}

		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
		}

		public LogInTabControl()
		{
			_TextColour = Color.FromArgb(255, 255, 255);
			_BackTabColour = Color.FromArgb(54, 54, 54);
			_BaseColour = Color.FromArgb(35, 35, 35);
			_ActiveColour = Color.FromArgb(47, 47, 47);
			_BorderColour = Color.FromArgb(30, 30, 30);
			_UpLineColour = Color.FromArgb(0, 160, 199);
			_HorizLineColour = Color.FromArgb(23, 119, 151);
			CenterSF = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			Font = new Font("Segoe UI", 10f);
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 32);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.Clear(_BaseColour);
			try
			{
				base.SelectedTab.BackColor = _BackTabColour;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				base.SelectedTab.BorderStyle = BorderStyle.FixedSingle;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			graphics2.DrawRectangle(new Pen(_BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
			checked
			{
				int num = base.TabCount - 1;
				for (int i = 0; i <= num; i++)
				{
					Rectangle rectangle = new Rectangle(new Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
					Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
					if (i == base.SelectedIndex)
					{
						graphics2.FillRectangle(new SolidBrush(_BaseColour), rectangle2);
						graphics2.FillRectangle(new SolidBrush(_ActiveColour), new Rectangle(rectangle.X + 1, rectangle.Y - 3, rectangle.Width, rectangle.Height + 5));
						graphics2.DrawString(base.TabPages[i].Text, Font, new SolidBrush(_TextColour), new Rectangle(rectangle.X + 7, rectangle.Y, rectangle.Width - 3, rectangle.Height), CenterSF);
						graphics2.DrawLine(new Pen(_HorizLineColour, 2f), new Point(rectangle.X + 3, (int)Math.Round((double)rectangle.Height / 2.0 + 2.0)), new Point(rectangle.X + 9, (int)Math.Round((double)rectangle.Height / 2.0 + 2.0)));
						graphics2.DrawLine(new Pen(_UpLineColour, 2f), new Point(rectangle.X + 3, rectangle.Y - 3), new Point(rectangle.X + 3, rectangle.Height + 5));
					}
					else
					{
						graphics2.DrawString(base.TabPages[i].Text, Font, new SolidBrush(_TextColour), rectangle2, CenterSF);
					}
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
