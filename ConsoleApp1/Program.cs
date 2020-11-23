using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //powiadomienie, że chcemy jego imię
                Console.WriteLine("Who are you stranger?");
                //pobierz imię
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("I will call you Noname, them");
                    name = "Noname";
                }

                else if (name.ToLower() == "stranger")
                {
                    Console.WriteLine("Ha! I knew it!");


                }

                Console.WriteLine($"Hello my dear, { name} ");
                Console.WriteLine("Where are you from, " + name + "?");
                string place = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(place))
                {
                    Console.WriteLine("You are not very talkative");
                    place = ("Neverland");
                }

                Console.WriteLine($"Let's begin the adventure {name} from {place}!");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                string[] level = {
                  "##########",
                  "#     #  #",
                  "#     #  #",
                  "#     #  #",
                  "#     #  #",
                  "#     #  #",
                  "#        #",
                  "#     #  #",
                  "##########",
    };
                string[] scroll = {
             "  _______________________",
             "=(__    ___      __     _)=",
             "  |                     |",
             "  |                     |",
             "  |                     |    ",
             "  |__    ___   __    ___|KCK",
             "=(_______________________)=",
    };

                Console.Clear();
                Console.WriteLine("Press any key to reveal the map");


                /* if (lineIndex < scroll.Length) {
                 Console.WriteLine(scroll[lineIndex++]);
                 }
                 if (lineIndex < scroll.Length) {
                 Console.WriteLine(scroll[lineIndex++]);
                 }
                 if (lineIndex < scroll.Length) {
                 Console.WriteLine(scroll[lineIndex++]);
                 }*/

                //while (lineIndex < scroll.Length/2){Console.WriteLine(scroll[lineIndex++]);}
                int scrollHalf = scroll.Length / 2;

                for (int i = 0; i < scrollHalf; i++)
                {
                    Console.WriteLine(scroll[i]);

                }
                int nextMapRowPosition = Console.CursorTop;

                foreach (string row in level)
                {
                    Console.SetCursorPosition(0, nextMapRowPosition);
                    Console.WriteLine($"  |     {row}      |");
                    for (int i = scrollHalf; i < scroll.Length; i++)
                    {
                        Console.WriteLine(scroll[i]);
                    }
                    nextMapRowPosition++;
                    Console.ReadKey(true);

                    /*
                        if (lineIndex < scroll.Length) {
                        Console.WriteLine(scroll[lineIndex++]);}
                        if (lineIndex < scroll.Length) {
                        Console.WriteLine(scroll[lineIndex++]);
                        }
                        if (lineIndex < scroll.Length) {
                        Console.WriteLine(scroll[lineIndex++]);
                        }
                        if (lineIndex < scroll.Length) {
                        Console.WriteLine(scroll[lineIndex++]);
                        }
                      */
                    // lineIndex = scroll.Length/2;
                    //while (lineIndex < scroll.Length){Console.WriteLine(scroll[lineIndex++]);}
                }
            }
        }
    } 
