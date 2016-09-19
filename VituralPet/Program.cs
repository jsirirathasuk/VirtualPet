using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VituralPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.WriteLine("Hi there! Weclome to the awesome world of the Internet!");
            Console.WriteLine("There are many adventures that await you but first");
            Console.WriteLine("Expand the window to see the sweet visuals.");
            Console.WriteLine("Hit the \"enter\" key to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n\n");
            Console.WriteLine("Please choose a virtual pet to travel with you!");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("             Doge");
            Console.WriteLine();
            Pet thisDoge = new Pet();
            thisDoge.Doge();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Nyan Cat");
            Console.WriteLine();
            Pet thisNyan = new Pet();
            thisNyan.Nyan();
            Console.WriteLine("\n");
            Console.WriteLine("Doge or Nyan Cat?");
            string chosenOne = Console.ReadLine();
            
                if (chosenOne.ToLower() == "doge")
                {
                    Console.Clear();
                }

                else if (chosenOne.ToLower() == "nyan cat")
                {
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine("You ente the wrong option, YOU SHALL NOT PASS!");
                    Environment.Exit(0);
                }
             
            if (chosenOne.ToLower() == "doge")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("                 Doge");
                Console.WriteLine("\n\n");
                thisDoge.Doge();
                Console.WriteLine("\n\n");
                Console.WriteLine("Since you have a pet now, you better take care of it!");
                Console.WriteLine("Max stats are 20, stay away from the 0!");
                thisDoge.Option();
                thisDoge.Food();
                thisDoge.Water();
                thisDoge.Poo();
                thisDoge.Ball();
                thisDoge.Bed();
                int userNumber = int.Parse(Console.ReadLine());
                Console.Clear();
                
                
                do
                {
                    if (userNumber == 1)
                    {
                        
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.FoodStats();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisDoge.WDoge();
                        thisDoge.L();
                        
                           

                    }
                    
                    else if (userNumber == 2)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.WaterStats();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisDoge.WDoge();
                        thisDoge.L();

                    }
                    else if (userNumber == 3)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.WasteStats();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisDoge.WDoge();
                        thisDoge.L();
                    }
                    else if (userNumber == 4)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.PlayStats();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisDoge.WDoge();
                        thisDoge.L();
                    }
                    else if (userNumber == 5)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.SleepStats();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisDoge.WDoge();
                        thisDoge.L();
                    }
                    else if(userNumber>5 || userNumber<0)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                 Doge");
                        Console.WriteLine("\n\n");
                        thisDoge.Doge();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisDoge.Option();
                        thisDoge.Food();
                        thisDoge.Water();
                        thisDoge.Poo();
                        thisDoge.Ball();
                        thisDoge.Bed();
                        Console.WriteLine("That wasn't an option, pick a number between 1 to 5!");
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }

                } while (true);
              


            }

            else if (chosenOne.ToLower() == "nyan cat")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("                Nyan Cat");
                Console.WriteLine("\n\n");
                thisNyan.Nyan();
                Console.WriteLine("\n\n");
                Console.WriteLine("Since you have a pet now, you better take care of it!");
                Console.WriteLine("Max stats are 20, stay away from the 0!");
                thisNyan.Option();
                thisNyan.Food();
                thisNyan.Water();
                thisNyan.Poo();
                thisNyan.Ball();
                thisNyan.Bed();
                int userNumber = int.Parse(Console.ReadLine());
                Console.Clear();

                do
                {
                    if (userNumber == 1)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.FoodStats();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisNyan.WNyan();
                        thisNyan.L();
                    }
                    else if (userNumber == 2)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.WaterStats();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisNyan.WNyan();
                        thisNyan.L();
                    }
                    else if (userNumber == 3)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.WasteStats();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisNyan.WNyan();
                        thisNyan.L();
                    }
                    else if (userNumber == 4)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.PlayStats();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisNyan.WNyan();
                        thisNyan.L();
                    }
                    else if (userNumber == 5)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.SleepStats();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                        thisNyan.WNyan();
                        thisNyan.L();
                    }
                    else if (userNumber > 5 || userNumber < 0)
                    {
                        Console.WriteLine("\n\n");
                        Console.WriteLine("                Nyan Cat");
                        Console.WriteLine("\n\n");
                        thisNyan.Nyan();
                        Console.WriteLine("\n\n");
                        Console.WriteLine("Since you have a pet now, you better take care of it!");
                        Console.WriteLine("Max stats are 20, stay away from the 0!");
                        thisNyan.Option();
                        thisNyan.Food();
                        thisNyan.Water();
                        thisNyan.Poo();
                        thisNyan.Ball();
                        thisNyan.Bed();
                        Console.WriteLine("That wasn't an option, pick a number between 1 to 5!");
                        userNumber = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }

                } while (true);

            }

          
            

            

          
























        }
    }
}
