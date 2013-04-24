/*
    8ball
    Copyright (C) 2010 nilsding
    Copyright (C) 2013 pixeldesu

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace ball
{
	class MainClass
	{
		public static readonly List<string> answers = new List<string> {
			"Never",
							"Of course",
							"After a while",
							"Bad chance",
							"Not even I know that one",
							"Why do you ask me?",
							"Yes",
							"No",
							"Ask someone else",
							"The answer is the one I told you above",
							"Impossible",
							"My mind says that it is not true",
							"Probably",
							"Ask something else",
							"Ask Paul the Octopus",
							"Not at all",
							"Eventually",
							"Maybe",
							"Ask later",
							"Come on, that's a stupid question",
							"I don't think so"
		};
		
		public static void Main (string[] args)
		{
			string you = ball.Properties.Settings.Default.You;
			string answerer = ball.Properties.Settings.Default.Answerer;
			string version = "1.1";

			if (you == "") {
				you = "You";
			}
			;

			if (answerer == "") {
				answerer = "8ball";
			}

			Console.Title = "8ball | © 2013 pixeldesu";
			Console.ForegroundColor = ConsoleColor.Yellow;			
			Console.Write ("8ball");								
			Console.ForegroundColor = ConsoleColor.White;			
			Console.Write (" {0}", version);
#if DEBUG
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write (" DEBUG VERSION");
			Console.ForegroundColor = ConsoleColor.White;
#endif
			Console.WriteLine ("");
			Console.Write ("© 2010 nilsding | © 2013 pixeldesu");
			Console.WriteLine ("");									
			Console.Write ("Enter '");								
			Console.ForegroundColor = ConsoleColor.Red;				
			Console.Write ("!exit");									
			Console.ForegroundColor = ConsoleColor.White;			
			Console.WriteLine ("' to exit 8ball.");
			Console.Write ("Enter '");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write ("!help");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine ("' to get a list of some commands.");				
			Console.WriteLine ("");
			try {
				do {					
					Console.WriteLine ("");
					Console.ForegroundColor = ConsoleColor.Green;       // You can change the color for "You: " here 
					Console.Write ("{0}: ", you);								// and here you can change the "You: " text. 
					Console.ForegroundColor = ConsoleColor.White;        
		            	
					string Lime;
					Lime = Console.ReadLine (); // Limes are nice, I still prefer bananas though.

					if (Lime == null) {
					} else
					if ("!exit".Equals (Lime, StringComparison.InvariantCultureIgnoreCase)) {											
						Console.WriteLine (""); 							
						Console.WriteLine ("Press any key to continue...");
						Console.ForegroundColor = ConsoleColor.Black; 	
						Console.ReadKey ();
						Console.ForegroundColor = ConsoleColor.White;					 
						return;
					}
					if ("!change name".Equals (
							Lime,
							StringComparison.InvariantCultureIgnoreCase
					)) {
						Console.WriteLine ("So you want to change your name?");
						Console.Write ("New name: ");
						string you_new = Console.ReadLine ();
						if (you_new.Trim () == "") {
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.Write ("Warning");
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write (": Leaving your name blank will change it back to \"You\"!");
							Console.ForegroundColor = ConsoleColor.Black; 	
							Console.WriteLine ("");
						}
						you = you_new;
						if (you.Trim () == "") {
							you = "You";
						}
						;
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.Green;        
						Console.Write ("Success:");								
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write (" Your name was successfully changed to '{0}'!", you);
						Console.WriteLine ("");
						Console.WriteLine ("Press any key to continue...");
						Console.ForegroundColor = ConsoleColor.Black; 	
						Console.ReadKey ();
						Console.ForegroundColor = ConsoleColor.White;
					} else if ("!change 8ball".Equals (Lime,
							StringComparison.InvariantCultureIgnoreCase
					)) {
						Console.WriteLine ("So you want to change 8balls name?");
						Console.Write ("New name: ");
						string answerer_new = Console.ReadLine ();
						if (answerer_new == "") {
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.Write ("Warning");
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write (": Leaving 8balls name empty will change it back to \"8ball\"!");
							Console.ForegroundColor = ConsoleColor.Black; 	
							Console.WriteLine ("");
						}
						answerer = answerer_new;
						if (answerer == "") {
							answerer = "8ball";
						}
						;
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write ("Success:");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write (
								" 8balls name was successfully changed to '{0}'!",
								answerer
						);
						Console.WriteLine ("");
						Console.WriteLine ("Press any key to continue...");
						Console.ForegroundColor = ConsoleColor.Black; 	
						Console.ReadKey ();
						Console.ForegroundColor = ConsoleColor.White;
					} else if ("!help".Equals (
							Lime,
							StringComparison.InvariantCultureIgnoreCase
					)) {
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("In 8ball 1.1 a lot of changes were made to 8ball!");
						Console.Write ("!change name  ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("| with this command you can change your name shown in 8ball");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write ("!change 8ball ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("| with this command you can change 8balls name");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write ("!clear        ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("| clears the console");
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("Another important change is the feature of writing commands the way you want,\nbecause they're now case insensitive!");
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Press any key to continue...");
						Console.ForegroundColor = ConsoleColor.Black; 	
						Console.ReadKey ();
						Console.ForegroundColor = ConsoleColor.White;
					} else if ("!clear".Equals (
							Lime,
							StringComparison.InvariantCultureIgnoreCase
					)) {
						Console.Clear ();
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write ("8ball");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write (" {0}", version);
#if DEBUG
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write (" DEBUG VERSION");
						Console.ForegroundColor = ConsoleColor.White;
#endif
						Console.WriteLine ("");
						Console.Write ("© 2010 nilsding | © 2013 pixeldesu");
						Console.WriteLine ("");
						Console.Write ("Enter '");
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write ("exit");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("' to exit 8ball.");
						Console.WriteLine ("");
					} else if ("!about".Equals (
							Lime,
							StringComparison.InvariantCultureIgnoreCase
					)) {
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("");
						Console.WriteLine ("Main programming");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("nilsding | http://twitter.com/nilsding"); 	// Please keep this line.
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Additional features and fixes (2013)");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("pixeldesu | http://github.com/pixeldesu"); 	// Please keep this line.
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("nilsding | http://nilsding.org"); 	// Please fuck around with this line as much as you can.
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Source code available at:");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("GitHub | http://github.com/pixeldesu/8ball");
						Console.WriteLine ("");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Content of the original 8ball.txt");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine ("cyanrazorCel and tmsxgamer"); // Keep this line.
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("");
						Console.WriteLine ("Press any key to continue...");
						Console.ForegroundColor = ConsoleColor.Black;
						Console.ReadKey ();
						Console.ForegroundColor = ConsoleColor.White;
					} else if (string.IsNullOrEmpty (Lime)) {
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write ("8ball: ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine ("Speechless, huh?");				// You're allowed to change this line.
					} else {
						Random random = new Random ();
						string RandomText = answers [random.Next (answers.Count)];
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write ("{0}: ", answerer);
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine (RandomText);

					}
					
					
				} while (true);
			    
			} catch (Exception ex) {
				Console.Write ("I'm sorry, but what you did caused an error: ");
				Console.ForegroundColor = ConsoleColor.Red;	
				Console.WriteLine (ex.Message);
				Console.ForegroundColor = ConsoleColor.White;
				#if DEBUG
				Console.WriteLine ("Here, have a stack trace.");
				Console.WriteLine (ex.StackTrace);
				#endif
				Console.WriteLine ();
				Console.WriteLine ("Press any key to continue...");
				Console.ForegroundColor = ConsoleColor.Black; 	
				Console.ReadKey ();
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	} 
}