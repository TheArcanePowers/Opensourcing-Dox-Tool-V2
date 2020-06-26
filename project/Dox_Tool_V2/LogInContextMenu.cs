using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInContextMenu : ContextMenuStrip
	{
		private Color _FontColour;

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

		public LogInContextMenu()
		{
			_FontColour = Color.FromArgb(55, 255, 255);
			base.Renderer = new ToolStripProfessionalRenderer(new LogInColourTable());
			base.ShowCheckMargin = false;
			base.ShowImageMargin = false;
			base.ForeColor = Color.FromArgb(255, 255, 255);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			base.OnPaint(e);
		}
	}
}
