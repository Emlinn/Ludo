using System;
using Gtk;

namespace Ludo
{
	public class Teningur
	{

		private int rollreturn;
		public Teningur ()

		{

		}

		public int roll() {
			rollreturn = new Random ().Next (1, 7);
			return rollreturn;
		}

	}
}

