using System;

namespace Ludo
{
	public partial class YellowWindow : Gtk.Window
	{
		public YellowWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton4Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

