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
	public class LogInRichTextBox : Control
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TB")]
		private RichTextBox _TB;

		private Color _BaseColour;

		private Color _TextColour;

		private Color _BorderColour;

		[field: AccessedThroughProperty("TB")]
		private virtual RichTextBox TB
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		public override string Text
		{
			get
			{
				return TB.Text;
			}
			set
			{
				TB.Text = value;
				Invalidate();
			}
		}

		public void AppendText(string AppendingText)
		{
			TB.Focus();
			TB.AppendText(AppendingText);
			Invalidate();
		}

		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			TB.BackColor = BackColor;
			Invalidate();
		}

		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			TB.ForeColor = ForeColor;
			Invalidate();
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			TB.Size = checked(new Size(base.Width - 10, base.Height - 11));
		}

		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			TB.Font = Font;
		}

		public void TextChanges()
		{
			TB.Text = Text;
		}

		public LogInRichTextBox()
		{
			base.TextChanged += delegate
			{
				TextChanges();
			};
			TB = new RichTextBox();
			_BaseColour = Color.FromArgb(42, 42, 42);
			_TextColour = Color.FromArgb(255, 255, 255);
			_BorderColour = Color.FromArgb(35, 35, 35);
			RichTextBox tB = TB;
			tB.Multiline = true;
			tB.BackColor = _BaseColour;
			tB.ForeColor = _TextColour;
			tB.Text = string.Empty;
			tB.BorderStyle = BorderStyle.None;
			tB.Location = new Point(5, 5);
			tB.Font = new Font("Segeo UI", 9f);
			tB.Size = checked(new Size(base.Width - 10, base.Height - 10));
			tB = null;
			base.Controls.Add(TB);
			base.Size = new Size(135, 35);
			DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rectangle = checked(new Rectangle(0, 0, base.Width - 1, base.Height - 1));
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(_BaseColour);
			graphics2.DrawRectangle(new Pen(_BorderColour, 2f), base.ClientRectangle);
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics2 = null;
		}

		[CompilerGenerated]
		[DebuggerHidden]
		private void _Lambda_0024__R25_002D1(object a0, EventArgs a1)
		{
			TextChanges();
		}
	}
}
