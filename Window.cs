using System;

namespace Ludo
{
	public partial class Window : Gtk.Window
	{
		public Window () : 
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

