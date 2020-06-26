using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInListBox : Control
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ListB")]
		private ListBox _ListB;

		private string[] _Items;

		private Color _BaseColour;

		private Color _SelectedColour;

		private Color _ListBaseColour;

		private Color _TextColour;

		private Color _BorderColour;

		private virtual ListBox ListB
		{
			[CompilerGenerated]
			get
			{
				return _ListB;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DrawItemEventHandler value2 = Drawitem;
				ListBox listB = _ListB;
				if (listB != null)
				{
					listB.DrawItem -= value2;
				}
				_ListB = value;
				listB = _ListB;
				if (listB != null)
				{
					listB.DrawItem += value2;
				}
			}
		}

		[Category("Control")]
		public string[] Items
		{
			get
			{
				return _Items;
			}
			set
			{
				_Items = value;
				ListB.Items.Clear();
				ListB.Items.AddRange(value);
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
		public Color SelectedColour
		{
			get
			{
				return _SelectedColour;
			}
			set
			{
				_SelectedColour = value;
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
		public Color ListBaseColour
		{
			get
			{
				return _ListBaseColour;
			}
			set
			{
				_ListBaseColour = value;
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

		public string SelectedItem => Conversions.ToString(ListB.SelectedItem);

		public int SelectedIndex => ListB.SelectedIndex;

		public void Clear()
		{
			ListB.Items.Clear();
		}

		public void ClearSelected()
		{
			checked
			{
				int num = ListB.SelectedItems.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					ListB.Items.Remove(RuntimeHelpers.GetObjectValue(ListB.SelectedItems[i]));
				}
			}
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(ListB))
			{
				base.Controls.Add(ListB);
			}
		}

		public void AddRange(object[] items)
		{
			ListB.Items.Remove("");
			ListB.Items.AddRange(items);
		}

		public void AddItem(object item)
		{
			ListB.Items.Remove("");
			ListB.Items.Add(RuntimeHelpers.GetObjectValue(item));
		}

		public void Drawitem(object sender, DrawItemEventArgs e)
		{
			checked
			{
				if (e.Index >= 0)
				{
					e.DrawBackground();
					e.DrawFocusRectangle();
					Graphics graphics = e.Graphics;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
					if (Strings.InStr(e.State.ToString(), "Selected,") > 0)
					{
						graphics.FillRectangle(new SolidBrush(_SelectedColour), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1));
						graphics.DrawString(" " + ListB.Items[e.Index].ToString(), new Font("Segoe UI", 9f, FontStyle.Bold), new SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2);
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(_ListBaseColour), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
						graphics.DrawString(" " + ListB.Items[e.Index].ToString(), new Font("Segoe UI", 8f), new SolidBrush(_TextColour), e.Bounds.X, e.Bounds.Y + 2);
					}
					graphics.Dispose();
					graphics = null;
				}
			}
		}

		public LogInListBox()
		{
			ListB = new ListBox();
			_Items = new string[1]
			{
				""
			};
			_BaseColour = Color.FromArgb(42, 42, 42);
			_SelectedColour = Color.FromArgb(55, 55, 55);
			_ListBaseColour = Color.FromArgb(47, 47, 47);
			_TextColour = Color.FromArgb(255, 255, 255);
			_BorderColour = Color.FromArgb(35, 35, 35);
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			ListB.DrawMode = DrawMode.OwnerDrawFixed;
			ListB.ScrollAlwaysVisible = false;
			ListB.HorizontalScrollbar = false;
			ListB.BorderStyle = BorderStyle.None;
			ListB.BackColor = _BaseColour;
			ListB.Location = new Point(3, 3);
			ListB.Font = new Font("Segoe UI", 8f);
			ListB.ItemHeight = 20;
			ListB.Items.Clear();
			ListB.IntegralHeight = false;
			base.Size = new Size(130, 100);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.Clear(BackColor);
			checked
			{
				ListB.Size = new Size(base.Width - 6, base.Height - 5);
				graphics2.FillRectangle(new SolidBrush(_BaseColour), rect);
				graphics2.DrawRectangle(new Pen(_BorderColour, 3f), new Rectangle(0, 0, base.Width, base.Height - 1));
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
