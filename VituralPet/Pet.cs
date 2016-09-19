using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VituralPet
{
    class Pet
    {
        //fields
        private int hunger;
        private int thirst;
        private int waste;
        private int play;
        private int sleep;
              
        //properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }
        public int Fun
        {
            get { return this.play; }
            set { this.play = value; }
        }
        public int Tired
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }

        //constructors
        public Pet()
        {
            hunger = 10;
            thirst = 10;
            waste = 10;
            play = 10;
            sleep = 10;
        }


        public void Food()
        {            
            Console.WriteLine("Hunger = " + hunger);
                      
        }
        public void Water()
        {
            Console.WriteLine("Thirst = " + thirst);
        }
        public void Poo()
        {
            Console.WriteLine("Waste = " + waste);

        }
        public void Ball()
        {
            Console.WriteLine("Boredom = " + play);
        }

        public void Bed()
        {
            Console.WriteLine("Sleepiness = " + sleep);

        }
      
        public void Option()
        {
            
            Console.WriteLine("Pick an action.");
            Console.WriteLine("\"1\" to feed your pet Chiptole.");
            Console.WriteLine("\"2\" to give your pet a Pumpkin Spiece Latte.");
            Console.WriteLine("\"3\" will take your pet to the Memeroom.");
            Console.WriteLine("\"4\" to play ball with your pet. #BallIsLife");
            Console.WriteLine("\"5\" will make your pet rest.");
            Console.WriteLine();
        }
      

        //Pet display
        public void Doge()
        {
            Console.WriteLine("                   ▄              ▄");
            Console.WriteLine("                  ▌▒█           ▄▀▒▌   cheesecakes");
            Console.WriteLine("                  ▌▒▒█        ▄▀▒▒▒▐");
            Console.WriteLine("     such ascii  ▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐");
            Console.WriteLine("               ▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐       wow");
            Console.WriteLine("             ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌");
            Console.WriteLine("  many line ▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌  rubber duck");
            Console.WriteLine("            ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐");
            Console.WriteLine("           ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌");
            Console.WriteLine("           ▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌     red squiggly line");
            Console.WriteLine("          ▌▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐");
            Console.WriteLine("codeEVIL  ▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌");
            Console.WriteLine("          ▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐");
            Console.WriteLine("           ▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌    dog#");
            Console.WriteLine("           ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐");
            Console.WriteLine("  sirahn++  ▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌");
            Console.WriteLine("              ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀  Doge while loop");
            Console.WriteLine("                ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀");
            Console.WriteLine("                    ▒▒▒▒▒▒▒▒▒▒▀▀");
        }

        

        public void SecondDoge()
        {
            
            Console.WriteLine("                   ▄              ▄");
            Console.WriteLine("                  ▌▒█           ▄▀▒▌   gg");
            Console.WriteLine("                  ▌▒▒█        ▄▀▒▒▒▐");
            Console.WriteLine("     much happy  ▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐");
            Console.WriteLine("               ▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐       W");
            Console.WriteLine("     MLG     ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌");
            Console.WriteLine("            ▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌  we the best");
            Console.WriteLine("   360      ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐");
            Console.WriteLine("     no    ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌");
            Console.WriteLine("  scope    ▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌ 1337");
            Console.WriteLine("          ▌▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐");
            Console.WriteLine("   MVP    ▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌");
            Console.WriteLine("          ▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐");
            Console.WriteLine("           ▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌    dog#");
            Console.WriteLine("           ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐");
            Console.WriteLine(" another 1  ▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌");
            Console.WriteLine("              ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀");
            Console.WriteLine("                ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀");
            Console.WriteLine("                    ▒▒▒▒▒▒▒▒▒▒▀▀");
        }


    

        

        public void Nyan()
        {
            Console.WriteLine("             █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█ ");
            Console.WriteLine("            █░▒▒▒▒▒▒▒▓▒▒▓▒▒▒▒▒▒▒░█ ");
            Console.WriteLine("            █░▒▒▓▒▒▒▒▒▒▒▒▒▄▄▒▓▒▒░█ ▄▄ ");
            Console.WriteLine("       ▄▀▀▄▄█░▒▒▒▒▒▒▓▒▒▒▒█░░▀▄▄▄▄▄▀░░█ ");
            Console.WriteLine("       █░░░░█░▒▒▒▒▒▒▒▒▒▒▒█░░░░░░░░░░░█ ");
            Console.WriteLine("        ▀▀▄▄█░▒▒▒▒▓▒▒▒▓▒█░░░█▒░░░░█▒░░█ ");
            Console.WriteLine("           █░▒▓▒▒▒▒▓▒▒▒█░░░░░░░▀░░░░░█ ");
            Console.WriteLine("          ▄▄█░▒▒▒▓▒▒▒▒▒▒▒█░░█▄▄█▄▄█░░█ ");
            Console.WriteLine("         █░░░█▄▄▄▄▄▄▄▄▄▄█░█▄▄▄▄▄▄▄▄▄█ ");
            Console.WriteLine("         █▄▄█  █▄▄█      █▄▄█   █▄▄█");
       


        }

        public void Meme()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("          ████████     ██████");
            Console.WriteLine("         █░░░░░░░░██ ██░░░░░░█");
            Console.WriteLine("        █░░░░░░░░░░░█░░░░░░░░░█");
            Console.WriteLine("       █░░░░░░░███░░░█░░░░░░░░░█");
            Console.WriteLine("       █░░░░███░░░███░█░░░████░█");
            Console.WriteLine("      █░░░██░░░░░░░░███░██░░░░██");
            Console.WriteLine("     █░░░░░░░░░░░░░░░░░█░░░░░░░░███");
            Console.WriteLine("    █░░░░░░░░░░░░░██████░░░░░████░░█");
            Console.WriteLine("    █░░░░░░░░░█████░░░████░░██░░██░░█");
            Console.WriteLine("   ██░░░░░░░███░░░░░░░░░░█░░░░░░░░███");
            Console.WriteLine("  █░░░░░░░░░░░░░░█████████░░█████████");
            Console.WriteLine(" █░░░░░░░░░░█████_████___████_█████___█");
            Console.WriteLine(" █░░░░░░░░░░█______█_███__█_____███_█___█");
            Console.WriteLine("█░░░░░░░░░░░░█___████_████____██_██████");
            Console.WriteLine("░░░░░░░░░░░░░█████████░░░████████░░░█");
            Console.WriteLine("░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░░░░░░█");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░██░░░░█░░░░░░██");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░██░░░░░░░███████");
            Console.WriteLine("░░░░░░░░░░░░░░░░██░░░░░░░░░░█░░░░░█");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("░░░░░░░░░░░█████████░░░░░░░░░░░░░░██");
            Console.WriteLine("░░░░░░░░░░█▒▒▒▒▒▒▒▒███████████████▒▒█");
            Console.WriteLine("░░░░░░░░░█▒▒███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█  when you aren't thet bestest there was..");
            Console.WriteLine("░░░░░░░░░█▒▒▒▒▒▒▒▒▒█████████████████");
            Console.WriteLine("░░░░░░░░░░████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░██████████████████");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.WriteLine("▓██░░░░░░░░░░░░░░░░░░░░░░░░██");
            Console.WriteLine("▓▓▓███░░░░░░░░░░░░░░░░░░░░█");
            Console.WriteLine("▓▓▓▓▓▓███░░░░░░░░░░░░░░░██");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓███████████████▓▓█");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█");
         
        }

        //public void Tick()
        //{
        //    for (int i=0; i<=10; i++)
        //    {
        //        Console.WriteLine("\n\n");
        //        Console.WriteLine("You Are the best there ever was!");
        //        System.Threading.Thread.Sleep(500);
        //        SecondDoge();
        //    }
        //}
       

      
        //Method
        public void FoodStats()
        {
            hunger+=1;
            thirst-=1;
            waste -= 1;
            play += 0;
            sleep +=0;
        }
        public void WaterStats()
        {
            hunger += 0;
            thirst +=1;
            waste -= 1;
            play += 0;
            sleep += 0;
        }
        public void WasteStats()
        {
            hunger -= 1;
            thirst -=  1;
            waste += 3;
            play -= 1;
            sleep -= 1;
        }
        public void PlayStats()
        {
            hunger -= 1;
            thirst -= 1;
            waste += 0;
            play += 1;
            sleep -= 2;
        }
        public void SleepStats()
        {
            
            hunger -= 1;
            thirst -= 1;
            waste -= 1;
            play -= 1;
            sleep += 3;
        }

        public void WDoge()
        {
            if (hunger == 20)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                SecondDoge();
                Environment.Exit(0);

            }
            else if (thirst == 20)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                SecondDoge();
                Environment.Exit(0);

            }
            else if (waste == 20)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                SecondDoge();
                Environment.Exit(0);
            }
            else if (play == 20)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                SecondDoge();
                Environment.Exit(0);

            }
            else if (sleep == 20)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                SecondDoge();
                Environment.Exit(0);

            }



        }

        public void WNyan()
        {
            if (hunger == 20)
            {
               
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                Nyan();
                Environment.Exit(0);

            }
            else if (thirst == 20)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                Nyan();
                Environment.Exit(0);

            }
            else if (waste == 20)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                Nyan();
                Environment.Exit(0);

            }
            else if (play == 20)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                Nyan();
                Environment.Exit(0);

            }
            else if (sleep == 20)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("CONGRATS! YOU ARE THE BEST THERE EVER WAS! TAKE THIS W!");
                Nyan();
                Environment.Exit(0);

            }

        }

        public void L()
        {
            if (hunger == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU DON'T HAVE ENOUGH BADGES TO TRAIN ME!");
                Console.WriteLine("Your pet ran away because you hit a 0. Take this L!");
                Meme();
                Environment.Exit(0);


            }
            else if (thirst == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU DON'T HAVE ENOUGH BADGES TO TRAIN ME!");
                Console.WriteLine("Your pet ran away because you hit a 0. Take this L!");
                Meme();
                Environment.Exit(0);


            }
            else if (waste == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU DON'T HAVE ENOUGH BADGES TO TRAIN ME!");
                Console.WriteLine("Your pet ran away because you hit a 0. Take this L!");
                Meme();
                Environment.Exit(0);


            }
            else if (play == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU DON'T HAVE ENOUGH BADGES TO TRAIN ME!");
                Console.WriteLine("Your pet ran away because you hit a 0. Take this L!");
                Meme();
                Environment.Exit(0);


            }
            else if (sleep == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                Console.WriteLine("YOU DON'T HAVE ENOUGH BADGES TO TRAIN ME!");
                Console.WriteLine("Your pet ran away because you hit a 0. Take this L!");
                Meme();
                Environment.Exit(0);


            }
        }




        }
}
