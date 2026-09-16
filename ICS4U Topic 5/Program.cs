using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS4U_Topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        public static void Menu()
        {
            bool exit = false;


            string menuInput = "";

            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Compass Bearings");
                Console.WriteLine("2. Parking Garage Cost");
                Console.WriteLine("3. Hurricane");


                Console.WriteLine();
                Console.Write("Enter your choice: ");
                menuInput = Console.ReadLine();

                if (menuInput == "0")
                {
                    exit = true;
                }
                else if (menuInput == "1")
                {
                    Console.Clear();
                    CompassBearings();
                    Console.Clear();
                }
                else if (menuInput == "2")
                {
                    Console.Clear();
                    ParkingGarage();
                    Console.Clear();
                }
                else if (menuInput == "3")
                {
                    Console.Clear();
                    Hurricane();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }
        }

        public static void CompassBearings()
        { 
            bool invalidBearing = true;
            double bearing = 0.0;

            

            while (invalidBearing)
            {
                Console.WriteLine("Compass Bearings : ");
                Console.WriteLine();

                Console.WriteLine("Enter Bearing (in degrees): ");

                if (!Double.TryParse(Console.ReadLine(), out bearing))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    if (bearing < 0)
                    {
                        bearing = bearing * -1;
                    }

                    bearing = bearing % 360;

                    

                    if ((bearing > 315 && bearing <= 360) || (bearing < 45 && bearing >= 0)) // North
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling North.");

                        Console.WriteLine("Press any key to exit");

                        Console.ReadKey();
                    }
                    else if (bearing > 45 && bearing < 135) // East
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling East.");

                        Console.WriteLine("Press any key to exit");

                        Console.ReadKey();
                    }
                    else if (bearing > 135 && bearing < 225) // South
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling South.");

                        Console.WriteLine("Press any key to exit");

                        Console.ReadKey();
                    }
                    else if (bearing > 225 && bearing < 315) // West
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling West.");

                        Console.WriteLine("Press any key to exit");

                        Console.ReadKey();
                    }
                    else if (bearing == 45) // Northeast
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling Northeast");

                        Console.WriteLine("Press any key to exit");


                        Console.ReadKey();
                    
                    }
                    else if (bearing == 135) // Southeast
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling Southeast");

                        Console.WriteLine("Press any key to exit");


                        Console.ReadKey();

                    }
                    else if (bearing == 225) // Southwest
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling Southwest");
                        Console.WriteLine("Press any key to exit");


                        Console.ReadKey();

                    }
                    else if (bearing == 45) // Northwest
                    {
                        Console.Clear();

                        Console.WriteLine("You are travelling Northwest");
                        Console.WriteLine("Press any key to exit");


                        Console.ReadKey();

                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Error");
                        Console.WriteLine("Press any key to exit");


                        Console.ReadKey();

                    }


                    invalidBearing = false;
                }

            }
            


            
        }

        public static void ParkingGarage()
        {
            bool finish = false;

            double time = 0;

            double price = 4.00;
            double priceAditional = 2.00;
            double priceMax = 20.00;

            double moneyOwed = 0.0;


            while (!finish)
            {
                Console.Clear();
                Console.WriteLine("Parking Garage");
                Console.WriteLine();
                Console.WriteLine("Input time parked (minutes) : ");

                if (double.TryParse(Console.ReadLine(), out time))
                {
                    time = time / 60;

                    time = Math.Ceiling(time);

                    if (time <= 1)
                    {
                        moneyOwed = price;
                    }
                    else if (time > 1)
                    {
                        moneyOwed = (price) + (time - 1) * priceAditional;
                    }

                    if (moneyOwed >= 20)
                    {
                        moneyOwed = priceMax;

                        Console.WriteLine($"You owe the maximum amount of money, ${moneyOwed}.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"You owe ${moneyOwed}.");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                
                }

                finish = true;

            }
        }

        public static void Hurricane() 
        {
            bool finish = false;
            int category = 0;

            while (!finish)
            {
                Console.Clear();
                Console.WriteLine("Hurricane");
                Console.WriteLine();
                Console.WriteLine("Input category : ");

                


                if (Int32.TryParse(Console.ReadLine(), out category) && category <= 5 && category > 0)
                {
                    switch (category)
                    {
                        case 1:
                            Console.WriteLine("Category 1: 74-95 mph or 64-82 kt or 119-153 km/hr");
                            break;
                        case 2:
                            Console.WriteLine("Category 2: 96-110 mph or 83-95 kt or 154-177 km/hr");
                            break;
                        case 3:
                            Console.WriteLine("Category 3: 111-130 mph or 96-113 kt or 178-209 km/hr");
                            break;
                        case 4:
                            Console.WriteLine("Category 4: 131-155 mph or 114-135 kt or 210-149 km/hr");
                            break;
                        case 5:
                            Console.WriteLine("Category 5: greater than 155 mph or 135 kt or 249 km/hr");
                            break;
                    }

                    Console.WriteLine();

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    finish = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error - Input Category 1-5");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();



                }

            }

        }
    }
}
