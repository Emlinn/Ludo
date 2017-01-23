/*
 * Höfundur : Emil Ragnarsson
 * 
 * 9.2.2014
 * 
 * Lysing a forriti : Þessi forritskoði gerir notanda kleift að spila ludo a moti tölvunni. Leikurinn fer eftir
 * helstu almennum reglum ludos.  Til þess að na peði a borði þarf að fa 6 a tening.  Eftir það kastar maður til 
 * að komast alla leið heim.  Eftir að fyrsta peðið er komið heim þa þarf að kasta aftur 6 til að na öðru peði ut
 * og svo koll af kolli.  Leikurinn er text based eins og er en hægt auðveldlega að utfæra hann með grafisku viðmoti.
 * 
 * Þyðing : Notast var við Xamarin sem þyðir forritið og keyrir beint ut outputið af forritinu.
 * */


using System;
using Gtk;
namespace Ludo {

public partial class MainWindow: Gtk.Window
{
		// Global breyta fyrir tening, nauðsynlegt að hafa þetta her svo að hægt se að kasta tening með stuttu millibili
		Random rand = new Random();

		// Breyta sem heldur utan um staðsetningu peða a borðinu fyrir User
		int redpos = 0; 
		int redpos2 = 0;
		int redpos3 = 0;
		int redpos4 = 0;

		// Byrjunar breyta fyrir peð. 54 reitir i borði en 60 til þess að draga fra fyrsta 6 sem maður fær 
		int redped1 = 60;
		int redped2 = 60;
		int redped3 = 60;
		int redped4 = 60;
		
		int bluepos = 13; 
		int bluepos2 = 13;
		int bluepos3 = 13;
		int bluepos4 = 13;

		int blueped1 = 73;
		int blueped2 = 73;
		int blueped3 = 73;
		int blueped4 = 73;

		int yellowpos = 26; 
		int yellowpos2 = 26;
		int yellowpos3 = 26;
		int yellowpos4 = 26;

		int yellowped1 = 86;
		int yellowped2 = 86;
		int yellowped3 = 86;
		int yellowped4 = 86;

		int greenpos = 39; 
		int greenpos2 = 39;
		int greenpos3 = 39;
		int greenpos4 = 39;

		int greenped1 = 99;
		int greenped2 = 99;
		int greenped3 = 99;
		int greenped4 = 99;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		
			// For lykkja sem keyrir i gegnum allt fyrir alla liti
			for (int i = 0; i < 4; i++) {

				//User (Player)

				if (i == 1) {
					int rollreturn = rand.Next (1, 7);
					lblFinal.Text = rollreturn.ToString ();

					// Breytur fyrir Rauðan
					int redfinal = redped1 - redpos;
					int redfinal2 = redped2 - redpos2;
					int redfinal3 = redped3 - redpos3;
					int redfinal4 = redped4 - redpos4;

					int value = 1;

					// Öll vinnslan er undir þessari switch/case lykkju
					switch (value) {

					// Ef teningur er 6 eða gildi i mark er minna eða jafnt og 54 fara i case 2 annars case 3 sem er break
					case 1:
						if (rollreturn == 6 || redfinal <= 54) {
							goto case 2; 

						} else {
							goto case 3;
						}
						// Case 2 heldur um staðsetningu peða a borðinu og lækkar töluna fyrir hvert turn
					case 2:
						redpos += rollreturn;
						redfinal = redped1 - redpos;
						lblRauðurStat1.Text = redfinal.ToString () + " reitir heim";
						// Ef gildið er 0 eða minna outputta Heim. Hann er kominn i mark
						if (redfinal <= 0) {
							lblRauðurStat1.Text = "Heima";
						}
						// Næstu lykkjur gera það sama og fyrri fyrir öll hin peðin
						if (redfinal <= 0) {
							goto case 4;
						} 
						break;

					case 3:
						break;
					
						// Peð numer 2 User 
					case 4:
						if (rollreturn == 6 || redfinal2 <= 54) {
							goto case 5;
						} else {
							goto case 3;
						}

					case 5:
						redpos2 += rollreturn;
						redfinal2 = redped2 - redpos2;
						lblRauðurStat2.Text = redfinal2.ToString () + " reitir heim";
						if (redfinal2 <= 0) {
							lblRauðurStat2.Text = "Heima";
						}
						if (redfinal2 <= 0) {
							goto case 6;
						}
						break;

						// Peð numer 3 User
					case 6:
						if (rollreturn == 6 || redfinal3 <= 54) {
							goto case 7;
						} else {
							goto case 3;
						}
					case 7:
						redpos3 += rollreturn;
						redfinal3 = redped3 - redpos3;
						lblRauðurStat3.Text = redfinal3.ToString () + " reitir heim";
						if (redfinal3 <= 0) {
							lblRauðurStat3.Text = "Heima";
						}
						if (redfinal3 <= 0) {
							goto case 8;
						}
						break;

						// Peð numer 4 User
					case 8:
						if (rollreturn == 6 || redfinal4 <= 54) {
							goto case 9;
						} else {
							goto case 3;
						}
					case 9:
						redpos4 += rollreturn;
						redfinal4 = redped4 - redpos4;
						lblRauðurStat4.Text = redfinal4.ToString () + " reitir heim";
						if (redfinal4 <= 0) {
							lblRauðurStat4.Text = "Heima";
						}
						break;
					}
				}


				//player 2 Blar

				if (i == 1) {
					int rollreturn = rand.Next (1, 7);
					// Til þess að checka hvað hver player fær mikið i kastinu i console window. Bara fyrir mig
					Console.WriteLine (rollreturn + " Blar fær");

					// Breytur fyrir Blaa
					int bluefinal = blueped1 - bluepos;
					int bluefinal2 = blueped2 - bluepos2;
					int bluefinal3 = blueped3 - bluepos3;
					int bluefinal4 = blueped4 - bluepos4;

					int value = 1;
					switch (value) {

					case 1:
						if (rollreturn == 6 || bluefinal <= 54) {
							goto case 2; 

						} else {
							goto case 3;
						}
					case 2:
						bluepos += rollreturn;
						bluefinal = blueped1 - bluepos;
						lblBlarStat1.Text = bluefinal.ToString () + " reitir heim";
						if (bluefinal <= 0) {
							lblBlarStat1.Text = "Heima";
						}
						if (bluefinal <= 0) {
							goto case 4;
						} 
						break;

					case 3:
						break;

						// Peð numer 2 Blar
					case 4:
						if (rollreturn == 6 || bluefinal2 <= 54) {
							goto case 5;
						} else {
							goto case 3;
						}

					case 5:
						bluepos2 += rollreturn;
						bluefinal2 = blueped2 - bluepos2;
						lblBlarStat2.Text = bluefinal2.ToString () + " reitir heim";
						if (bluefinal2 <= 0) {
							lblBlarStat2.Text = "Heima";
						}
						if (bluefinal2 <= 0) {
							goto case 6;
						}
						break;

						// Peð numer 3 Blar
					case 6:
						if (rollreturn == 6 || bluefinal3 <= 54) {
							goto case 7;
						} else {
							goto case 3;
						}
					case 7:
						bluepos3 += rollreturn;
						bluefinal3 = blueped3 - bluepos3;
						lblBlarStat3.Text = bluefinal3.ToString () + " reitir heim";
						if (bluefinal3 <= 0) {
							lblBlarStat3.Text = "Heima";
						}
						if (bluefinal3 <= 0) {
							goto case 8;
						}
						break;

						// Peð numer 4 Blar
					case 8:
						if (rollreturn == 6 || bluefinal4 <= 54) {
							goto case 9;
						} else {
							goto case 3;
						}
					case 9:
						bluepos4 += rollreturn;
						bluefinal4 = blueped4 - bluepos4;
						lblBlarStat4.Text = bluefinal4.ToString () + " reitir heim";
						if (bluefinal4 <= 0) {
							lblBlarStat4.Text = "Heima";
						}
						break;
					}
				}

				//player 3 Gulur

				if (i == 1) {
					int rollreturn = rand.Next (1, 7);
					// Til þess að checka hvað hver player fær mikið i kastinu i console window. Bara fyrir mig
					Console.WriteLine (rollreturn + " Gulur fær");

					// Breytur fyrir Gulan
					int yellowfinal = yellowped1 - yellowpos;
					int yellowfinal2 = yellowped2 - yellowpos2;
					int yellowfinal3 = yellowped3 - yellowpos3;
					int yellowfinal4 = yellowped4 - yellowpos4;

					int value = 1;
					switch (value) {

					case 1:
						if (rollreturn == 6 || yellowfinal <= 54) {
							goto case 2; 

						} else {
							goto case 3;
						}
					case 2:
						yellowpos += rollreturn;
						yellowfinal = yellowped1 - yellowpos;
						lblGulurStat1.Text = yellowfinal.ToString () + " reitir heim";
						if (yellowfinal <= 0) {
							lblGulurStat1.Text = "Heima";
						}
						if (yellowfinal <= 0) {
							goto case 4;
						} 
						break;

					case 3:
						break;

						// Peð numer 2 Gulur
					case 4:
						if (rollreturn == 6 || yellowfinal2 <= 54) {
							goto case 5;
						} else {
							goto case 3;
						}

					case 5:
						yellowpos2 += rollreturn;
						yellowfinal2 = yellowped2 - yellowpos2;
						lblGulurStat2.Text = yellowfinal2.ToString () + " reitir heim";
						if (yellowfinal2 <= 0) {
							lblGulurStat2.Text = "Heima";
						}
						if (yellowfinal2 <= 0) {
							goto case 6;
						}
						break;

						// Peð numer 3 Gulur
					case 6:
						if (rollreturn == 6 || yellowfinal3 <= 54) {
							goto case 7;
						} else {
							goto case 3;
						}
					case 7:
						yellowpos3 += rollreturn;
						yellowfinal3 = yellowped3 - yellowpos3;
						lblGulurStat3.Text = yellowfinal3.ToString () + " reitir heim";
						if (yellowfinal3 <= 0) {
							lblGulurStat3.Text = "Heima";
						}
						if (yellowfinal3 <= 0) {
							goto case 8;
						}
						break;

						// Peð numer 4 Gulur
					case 8:
						if (rollreturn == 6 || yellowfinal4 <= 54) {
							goto case 9;
						} else {
							goto case 3;
						}
					case 9:
						yellowpos4 += rollreturn;
						yellowfinal4 = yellowped4 - yellowpos4;
						lblGulurStat4.Text = yellowfinal4.ToString () + " reitir heim";
						if (yellowfinal4 <= 0) {
							lblGulurStat4.Text = "Heima";
						}
						break;
					}
				}

				//player 4 Grænn

				if (i == 1) {
					int rollreturn = rand.Next (1, 7);
					// Til þess að checka hvað hver player fær mikið i kastinu i console window. Bara fyrir mig
					Console.WriteLine (rollreturn + " Grænn fær");

					// Breytur fyrir Grænan
					int greenfinal = greenped1 - greenpos;
					int greenfinal2 = greenped2 - greenpos2;
					int greenfinal3 = greenped3 - greenpos3;
					int greenfinal4 = greenped4 - greenpos4;

					int value = 1;
					switch (value) {

					case 1:
						if (rollreturn == 6 || greenfinal <= 54) {
							goto case 2; 

						} else {
							goto case 3;
						}
					case 2:
						greenpos += rollreturn;
						greenfinal = greenped1 - greenpos;
						lblGrænnStat1.Text = greenfinal.ToString () + " reitir heim";
						if (greenfinal <= 0) {
							lblGrænnStat1.Text = "Heima";
						}
						if (greenfinal <= 0) {
							goto case 4;
						} 
						break;

					case 3:
						break;

						// Peð numer 2 Grænn 
					case 4:
						if (rollreturn == 6 || greenfinal2 <= 54) {
							goto case 5;
						} else {
							goto case 3;
						}

					case 5:
						greenpos2 += rollreturn;
						greenfinal2 = greenped2 - greenpos2;
						lblGrænnStat2.Text = greenfinal2.ToString () + " reitir heim";
						if (greenfinal2 <= 0) {
							lblGrænnStat2.Text = "Heima";
						}
						if (greenfinal2 <= 0) {
							goto case 6;
						}
						break;

						// Peð numer 3 Grænn
					case 6:
						if (rollreturn == 6 || greenfinal3 <= 54) {
							goto case 7;
						} else {
							goto case 3;
						}
					case 7:
						greenpos3 += rollreturn;
						greenfinal3 = greenped3 - greenpos3;
						lblGrænnStat3.Text = greenfinal3.ToString () + " reitir heim";
						if (greenfinal3 <= 0) {
							lblGrænnStat3.Text = "Heima";
						}
						if (greenfinal3 <= 0) {
							goto case 8;
						}
						break;

						// Peð numer 4 Grænn
					case 8:
						if (rollreturn == 6 || greenfinal4 <= 54) {
							goto case 9;
						} else {
							goto case 3;
						}
					case 9:
						greenpos4 += rollreturn;
						greenfinal4 = greenped4 - greenpos4;
						lblGrænnStat4.Text = greenfinal4.ToString () + " reitir heim";
						if (greenfinal4 <= 0) {
							lblGrænnStat4.Text = "Heima";
						}
						break;
					}
				}
			}
			// Ef þu vinnur, opnar nyjan glugga sem segir að þu vannst og hættir forritinu.
			if (redped4 - redpos4 <= 0) {
				new Ludo.Window ();
			}

			if (blueped4 - bluepos4 <= 0) {
				new Ludo.BlueWindow ();
			}

			if (greenped4 - greenpos4 <= 0) {
				new Ludo.GreenWindow ();
			}

			if (yellowped4 - yellowpos4 <= 0) {
				new Ludo.YellowWindow ();
			}

		}

	protected void OnEntry1TextInserted (object o, TextInsertedArgs args)
	{

		}
	}
}
