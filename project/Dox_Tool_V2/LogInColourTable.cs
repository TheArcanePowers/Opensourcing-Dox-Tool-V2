using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	public class LogInColourTable : ProfessionalColorTable
	{
		private Color _BackColour;

		private Color _BorderColour;

		private Color _SelectedColour;

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
		public Color BackColour
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

		public override Color ButtonSelectedBorder => _BackColour;

		public override Color CheckBackground => _BackColour;

		public override Color CheckPressedBackground => _BackColour;

		public override Color CheckSelectedBackground => _BackColour;

		public override Color ImageMarginGradientBegin => _BackColour;

		public override Color ImageMarginGradientEnd => _BackColour;

		public override Color ImageMarginGradientMiddle => _BackColour;

		public override Color MenuBorder => _BorderColour;

		public override Color MenuItemBorder => _BackColour;

		public override Color MenuItemSelected => _SelectedColour;

		public override Color SeparatorDark => _BorderColour;

		public override Color ToolStripDropDownBackground => _BackColour;

		public LogInColourTable()
		{
			_BackColour = Color.FromArgb(42, 42, 42);
			_BorderColour = Color.FromArgb(35, 35, 35);
			_SelectedColour = Color.FromArgb(47, 47, 47);
		}
	}
}
