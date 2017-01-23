using System;

namespace Ludo
{
	public partial class BlueWindow : Gtk.Window
	{
		public BlueWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

