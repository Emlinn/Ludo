
// This file has been generated by the GUI designer. Do not modify.
namespace Ludo
{
	public partial class BlueWindow
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label6;
		private global::Gtk.Label label5;
		private global::Gtk.Button button3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Ludo.BlueWindow
			this.Name = "Ludo.BlueWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("BlueWindow");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Ludo.BlueWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Þvi miður");
			this.vbox2.Add (this.label6);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label6]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Blar vann");
			this.vbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label5]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("Hætta");
			this.vbox2.Add (this.button3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button3]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 343;
			this.DefaultHeight = 202;
			this.Show ();
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}
