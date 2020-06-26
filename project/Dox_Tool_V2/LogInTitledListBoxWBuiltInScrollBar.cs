#define DEBUG
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInTitledListBoxWBuiltInScrollBar : Control
	{
		public class LogInListBoxItem
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string _Text;

			public string Text
			{
				get;
				set;
			}

			public override string ToString()
			{
				return Text;
			}
		}

		private List<LogInListBoxItem> _Items;

		private readonly List<LogInListBoxItem> _SelectedItems;

		private bool _MultiSelect;

		private int ItemHeight;

		private readonly LogInVerticalScrollBar VerticalScrollbar;

		private Color _BaseColour;

		private Color _SelectedItemColour;

		private Color _NonSelectedItemColour;

		private Color _TitleAreaColour;

		private Color _BorderColour;

		private Color _TextColour;

		private int _SelectedHeight;

		[Category("Colours")]
		public Color TitleAreaColour
		{
			get
			{
				return _TitleAreaColour;
			}
			set
			{
				_TitleAreaColour = value;
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
		public int SelectedHeight
		{
			get
			{
				return _SelectedHeight;
			}
			set
			{
				if (value < 1)
				{
					_SelectedHeight = base.Height;
				}
				else
				{
					_SelectedHeight = value;
				}
				InvalidateScroll();
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
		public Color SelectedItemColour
		{
			get
			{
				return _SelectedItemColour;
			}
			set
			{
				_SelectedItemColour = value;
			}
		}

		[Category("Colours")]
		public Color NonSelectedItemColour
		{
			get
			{
				return _NonSelectedItemColour;
			}
			set
			{
				_NonSelectedItemColour = value;
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

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public LogInListBoxItem[] Items
		{
			get
			{
				return _Items.ToArray();
			}
			set
			{
				_Items = new List<LogInListBoxItem>(value);
				Invalidate();
				InvalidateScroll();
			}
		}

		public LogInListBoxItem[] SelectedItems => _SelectedItems.ToArray();

		public bool MultiSelect
		{
			get
			{
				return _MultiSelect;
			}
			set
			{
				_MultiSelect = value;
				if (_SelectedItems.Count > 1)
				{
					_SelectedItems.RemoveRange(1, checked(_SelectedItems.Count - 1));
				}
				Invalidate();
			}
		}

		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				ItemHeight = checked((int)Math.Round(Graphics.FromHwnd(base.Handle).MeasureString("@", Font).Height));
				if (VerticalScrollbar != null)
				{
					VerticalScrollbar._SmallChange = 1;
					VerticalScrollbar._LargeChange = 1;
				}
				base.Font = value;
				InvalidateLayout();
			}
		}

		private void HandleScroll(object sender)
		{
			Invalidate();
		}

		private void InvalidateScroll()
		{
			Debug.Print(Conversions.ToString(base.Height));
			checked
			{
				if ((double)(int)Math.Round(Math.Round((double)(_Items.Count * ItemHeight) / (double)_SelectedHeight)) < (double)(_Items.Count * ItemHeight) / (double)_SelectedHeight)
				{
					VerticalScrollbar._Maximum = (int)Math.Round(Math.Ceiling((double)(_Items.Count * ItemHeight) / (double)_SelectedHeight));
				}
				else if ((int)Math.Round(Math.Round((double)(_Items.Count * ItemHeight) / (double)_SelectedHeight)) == 0)
				{
					VerticalScrollbar._Maximum = 1;
				}
				else
				{
					VerticalScrollbar._Maximum = (int)Math.Round(Math.Round((double)(_Items.Count * ItemHeight) / (double)_SelectedHeight));
				}
				Invalidate();
			}
		}

		private void InvalidateLayout()
		{
			checked
			{
				VerticalScrollbar.Location = new Point(base.Width - VerticalScrollbar.Width - 2, 2);
				VerticalScrollbar.Size = new Size(18, base.Height - 4);
				Invalidate();
			}
		}

		public void AddItem(string Items)
		{
			LogInListBoxItem logInListBoxItem = new LogInListBoxItem();
			logInListBoxItem.Text = Items;
			_Items.Add(logInListBoxItem);
			Invalidate();
			InvalidateScroll();
		}

		public void AddItems(string[] Items)
		{
			foreach (string text in Items)
			{
				LogInListBoxItem logInListBoxItem = new LogInListBoxItem();
				logInListBoxItem.Text = text;
				_Items.Add(logInListBoxItem);
			}
			Invalidate();
			InvalidateScroll();
		}

		public void RemoveItemAt(int index)
		{
			_Items.RemoveAt(index);
			Invalidate();
			InvalidateScroll();
		}

		public void RemoveItem(LogInListBoxItem item)
		{
			_Items.Remove(item);
			Invalidate();
			InvalidateScroll();
		}

		public void RemoveItems(LogInListBoxItem[] items)
		{
			foreach (LogInListBoxItem item in items)
			{
				_Items.Remove(item);
			}
			Invalidate();
			InvalidateScroll();
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			_SelectedHeight = base.Height;
			InvalidateScroll();
			InvalidateLayout();
			base.OnSizeChanged(e);
		}

		private void Vertical_MouseDown(object sender, MouseEventArgs e)
		{
			Focus();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			Focus();
			if (e.Button == MouseButtons.Left)
			{
				int num = checked(VerticalScrollbar.Value * (VerticalScrollbar.Maximum + (base.Height - ItemHeight)));
				int num2 = checked(e.Y + num) / ItemHeight;
				if (num2 > checked(_Items.Count - 1))
				{
					num2 = -1;
				}
				if (num2 != -1)
				{
					if (Control.ModifierKeys == Keys.Control && _MultiSelect)
					{
						if (_SelectedItems.Contains(_Items[num2]))
						{
							_SelectedItems.Remove(_Items[num2]);
						}
						else
						{
							_SelectedItems.Add(_Items[num2]);
						}
					}
					else
					{
						_SelectedItems.Clear();
						_SelectedItems.Add(_Items[num2]);
					}
					Debug.Print(_SelectedItems[0].Text);
				}
				Invalidate();
			}
			base.OnMouseDown(e);
		}

		protected override void OnMouseWheel(MouseEventArgs e)
		{
			checked
			{
				int num = -(unchecked(checked(e.Delta * SystemInformation.MouseWheelScrollLines) / 120) * 1);
				int value = Math.Max(Math.Min(VerticalScrollbar.Value + num, VerticalScrollbar.Maximum), VerticalScrollbar.Minimum);
				VerticalScrollbar.Value = value;
				base.OnMouseWheel(e);
			}
		}

		public LogInTitledListBoxWBuiltInScrollBar()
		{
			_Items = new List<LogInListBoxItem>();
			_SelectedItems = new List<LogInListBoxItem>();
			_MultiSelect = true;
			ItemHeight = 24;
			_BaseColour = Color.FromArgb(55, 55, 55);
			_SelectedItemColour = Color.FromArgb(50, 50, 50);
			_NonSelectedItemColour = Color.FromArgb(47, 47, 47);
			_TitleAreaColour = Color.FromArgb(42, 42, 42);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_TextColour = Color.FromArgb(255, 255, 255);
			_SelectedHeight = 1;
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			VerticalScrollbar = new LogInVerticalScrollBar();
			VerticalScrollbar.SmallChange = 1;
			VerticalScrollbar.LargeChange = 1;
			VerticalScrollbar.Scroll += HandleScroll;
			VerticalScrollbar.MouseDown += Vertical_MouseDown;
			base.Controls.Add(VerticalScrollbar);
			InvalidateLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(_BaseColour);
			int num = checked(VerticalScrollbar.Value * (VerticalScrollbar.Maximum + (base.Height - ItemHeight)));
			int num2 = (num != 0) ? (num / ItemHeight / VerticalScrollbar.Maximum) : 0;
			checked
			{
				int num3 = Math.Min(num2 + unchecked(base.Height / ItemHeight), _Items.Count - 1);
				int num4 = num2;
				int num5 = _Items.Count - 1;
				for (int i = num4; i <= num5; i++)
				{
					LogInListBoxItem logInListBoxItem = Items[i];
					int num6 = ItemHeight + i * ItemHeight + 1 - num + (int)Math.Round((double)ItemHeight / 2.0 - 8.0);
					if (_SelectedItems.Contains(logInListBoxItem))
					{
						graphics2.FillRectangle(new SolidBrush(_SelectedItemColour), new Rectangle(0, ItemHeight + i * ItemHeight + 1 - num, base.Width - 19, ItemHeight - 1));
					}
					else
					{
						graphics2.FillRectangle(new SolidBrush(_NonSelectedItemColour), new Rectangle(0, ItemHeight + i * ItemHeight + 1 - num, base.Width - 19, ItemHeight - 1));
					}
					graphics2.DrawLine(new Pen(_BorderColour), 0, ItemHeight + i * ItemHeight + 1 - num + ItemHeight - 1, base.Width - 18, ItemHeight + i * ItemHeight + 1 - num + ItemHeight - 1);
					graphics2.DrawString(logInListBoxItem.Text, new Font("Segoe UI", 8f), new SolidBrush(_TextColour), 9f, num6);
					graphics2.ResetClip();
				}
				graphics2.FillRectangle(new SolidBrush(_TitleAreaColour), new Rectangle(0, 0, base.Width, ItemHeight));
				graphics2.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), 1, 1, base.Width - 3, ItemHeight - 2);
				graphics2.DrawString(Text, new Font("Segoe UI", 10f, FontStyle.Bold), new SolidBrush(_TextColour), new Rectangle(0, 0, base.Width, ItemHeight + 2), new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				});
				graphics2.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35), 2f), 1, 0, base.Width - 2, base.Height - 1);
				graphics2.DrawLine(new Pen(_BorderColour), 0, ItemHeight, base.Width, ItemHeight);
				graphics2.DrawLine(new Pen(_BorderColour, 2f), VerticalScrollbar.Location.X - 1, 0, VerticalScrollbar.Location.X - 1, base.Height);
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics2 = null;
			}
		}
	}
}
