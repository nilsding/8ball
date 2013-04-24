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

namespace ball
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            string you = ball.Properties.Settings.Default.You;
            string answerer = ball.Properties.Settings.Default.Answerer;
            string version = "1.1";

            if (you == "")
            { you = "You"; };

            if (answerer == "")
            { answerer = "8ball"; }

			Console.Title = "8ball | © 2013 pixeldesu";
			Console.ForegroundColor = ConsoleColor.Yellow;			
        	Console.Write("8ball");								
       		Console.ForegroundColor = ConsoleColor.White;			
       		Console.Write(" {0}", version);
#if DEBUG
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(" DEBUG VERSION");
			Console.ForegroundColor = ConsoleColor.White;
#endif
			Console.WriteLine("");
            Console.Write("© 2010 nilsding | © 2013 pixeldesu");
      		Console.WriteLine("");									
      		Console.Write("Enter '");								
       		Console.ForegroundColor = ConsoleColor.Red;				
        	Console.Write("exit");									
        	Console.ForegroundColor = ConsoleColor.White;			
        	Console.WriteLine("' to exit 8ball.");
            Console.Write("Enter '");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("!help");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("' to get a list of some commands.");				
        	Console.WriteLine("");
			try {
				do {					
					if (File.Exists("8ball.txt")) {
						Console.WriteLine("");
						Console.ForegroundColor = ConsoleColor.Green;       // You can change the color for "You: " here 
		           		Console.Write("{0}: ", you);								// and here you can change the "You: " text. 
		            	Console.ForegroundColor = ConsoleColor.White;        
		            	
						string Lime;
						Lime = Console.ReadLine();           				// Yeah Lime. Didn't know why I used Lime. 

                        if (Lime.Equals("!exit", StringComparison.InvariantCultureIgnoreCase))
                        {											
		            		Console.WriteLine(""); 							
					        Console.WriteLine("Press any key to continue...");
							Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
							Console.ReadKey();
							Console.ForegroundColor = ConsoleColor.White;					 
		                return;
						}
                        if (Lime.Equals("!change name", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("So you want to change your name?");
                            Console.Write("New name: ");
                            string you_new = Console.ReadLine();
                            if (you_new == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Warning");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(": Leaving your name empty will change it back to \"You\"!");
                                Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
                                Console.WriteLine("");
                            }
                            you = you_new;
                            if (you == "")
                            { you = "You"; };
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;        
                            Console.Write("Success:");								
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" Your name was successfully changed to '{0}'!", you);
                            Console.WriteLine("");
                            Console.WriteLine("Press any key to continue...");
                            Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                        }


                        else if (Lime.Equals("!change 8ball", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("So you want to change 8balls name?");
                            Console.Write("New name: ");
                            string answerer_new = Console.ReadLine();
                            if (answerer_new == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Warning");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(": Leaving 8balls name empty will change it back to \"8ball\"!");
                                Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
                                Console.WriteLine("");
                            }
                            answerer = answerer_new;
                            if (answerer == "")
                            { answerer = "8ball"; };
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Success:");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" 8balls name was successfully changed to '{0}'!", answerer);
                            Console.WriteLine("");
                            Console.WriteLine("Press any key to continue...");
                            Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (Lime.Equals("!help", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("In 8ball 1.1 a lot of changes were made to 8ball!");
                            Console.Write("!change name  ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("| with this command you can change your name shown in 8ball");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("!change 8ball ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("| with this command you can change 8balls name");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("!clear        ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("| clears the console");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Another important change is the feature of writing commands the way you want,\nbecause they're now case insensitive!");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Press any key to continue...");
                            Console.ForegroundColor = ConsoleColor.Black; 	// This should hide the pressed key.
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (Lime.Equals("!clear", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("8ball");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" {0}", version);
#if DEBUG
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" DEBUG VERSION");
                            Console.ForegroundColor = ConsoleColor.White;
#endif
                            Console.WriteLine("");
                            Console.Write("© 2010 nilsding | © 2013 pixeldesu");
                            Console.WriteLine("");
                            Console.Write("Enter '");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("exit");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("' to exit 8ball.");
                            Console.WriteLine("");
                        }

                        else if (Lime.Equals("!about", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.WriteLine("Main programming");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("nilsding | http://twitter.com/nilsding"); 	// Please keep this line.
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Addiotional features and fixes (2013)");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("pixeldesu | http://github.com/pixeldesu"); 	// Please keep this line.
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Content of the 8ball.txt");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("cyanrazorCel | http://youtube.com/cyanrazorCel"); // Keep this line too, except you made your own 8ball.txt. If you use some Contents of this 8ball.txt which is is in this version, please keep the copyright to cyanrazorCel.
                            Console.WriteLine("tmsxgamer | http://youtube.com/tmsxgamer"); // Keep this line.
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.WriteLine("Press any key to continue...");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (Lime == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("8ball: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Speechless, huh?");				// You're allowed to change this line.
                        }
                        else
                        {
                            string RandomText = string.Empty;
                            Random ran = new Random();
                            int mx = 0;
                            int cnt = 0;

                            using (StreamReader sr = new StreamReader("8ball.txt"))
                            {

                                while (sr.Peek() >= 0)
                                {
                                    sr.ReadLine();
                                    mx += 1;
                                }

                            }

                            int num = (ran.Next(1, mx - 1));

                            using (StreamReader sr = new StreamReader("8ball.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    cnt += 1;
                                    string line = sr.ReadLine();
                                    if (cnt == num)
                                    {
                                        RandomText = line;
                                        break;
                                    }
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0}: ", answerer);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(RandomText);

                        }
					}
					else { 						
						using (StreamWriter sw = new StreamWriter("8ball.txt")) {
							// This version includes a generator of the 8ball.txt, so you can share the executable only!
							// Thanks to cyanrazorCel and tmsxgamer for their 8ball.txt! http://youtube.com/cyanrazorCel | http://youtube.com/tmsxgamer
							Console.WriteLine("Generating 8ball.txt...");
                            Console.Title = "8ball | Generating answers...";	
							
							sw.WriteLine("Never");
							sw.WriteLine("Of course");
							sw.WriteLine("After a while");
							sw.WriteLine("Bad chance");
							sw.WriteLine("Not even I know that one");
							sw.WriteLine("Why do you ask me?");
							sw.WriteLine("Yes");
							sw.WriteLine("No");
							sw.WriteLine("Ask someone else");
							sw.WriteLine("The answer is the one I told you above");
							sw.WriteLine("Impossible");
							sw.WriteLine("My mind says that it is not true");
							sw.WriteLine("Probably");
							sw.WriteLine("Ask something else");
							sw.WriteLine("Ask Paul the Octopus");
							sw.WriteLine("Not at all");
							sw.WriteLine("Eventually");
							sw.WriteLine("Maybe");
							sw.WriteLine("Ask later");
							sw.WriteLine("Come on, that's a stupid question");
							sw.WriteLine("I don't think so");
							
							Console.WriteLine("Done!");
                            Console.Title = "8ball | © 2013 pixeldesu";	
							Console.WriteLine("");
						}
					}
					
				   } while (true);
			    
			    }
			catch {
			        Console.ForegroundColor = ConsoleColor.Red;	
					if (File.Exists("8ball.txt")) {
        			Console.WriteLine("Some unknown error occured.");				
					}
					else {
					Console.WriteLine("Couldn't create 8ball.txt due to missing administrator privileges.");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Run in an administrator user (XP) or right click the file \"8ball.exe\" and choose \"Run as administrator\" (Vista/7) to fix this problem.");
					}
					Console.ForegroundColor = ConsoleColor.White;
					#if DEBUG
					// Console.Write("Because this is a debug version, tell the programmers what you do that caused the error.");
					#endif
					Console.WriteLine();
					Console.WriteLine("Press any key to continue...");
					Console.ForegroundColor = ConsoleColor.Black; 	
					Console.ReadKey();
					Console.ForegroundColor = ConsoleColor.White;
			      }
			}
	} 
}