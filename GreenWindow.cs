using System;

namespace Ludo
{
	public partial class GreenWindow : Gtk.Window
	{
		public GreenWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

