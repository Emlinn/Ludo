
// This file has been generated by the GUI designer. Do not modify.
namespace Ludo
{
	public partial class GreenWindow
	{
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label8;
		private global::Gtk.Label label7;
		private global::Gtk.Button button5;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Ludo.GreenWindow
			this.Name = "Ludo.GreenWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("GreenWindow");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Ludo.GreenWindow.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Þvi miður");
			this.vbox5.Add (this.label8);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label8]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Grænn vann");
			this.vbox5.Add (this.label7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label7]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.button5 = new global::Gtk.Button ();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString ("Hætta");
			this.vbox5.Add (this.button5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.button5]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox5);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.button5.Clicked += new global::System.EventHandler (this.OnButton5Clicked);
		}
	}
}
