using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Validation
    {
        public static int ValidationCheck { get; set; }

        public static string AttemptValidation()
        {
            string checker = null;

            for (int i = 0; i < 6; i++)
            {
                checker = ReadNext();
                //checker = ReadNext().ToLower();
                //char first = checker[0];
                //char upper = char.ToUpper(first);
                //checker = upper + checker.Substring(1);
                string message = "Sorry I didn't understand that, could you please type a valid pizza ";

                switch (ValidationCheck)
                {
                    case 0:
                        return checker;

                    case 1:
                        if (checker == "New" || checker == "Returning" || checker == "Password123")
                        {
                            goto case 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't understand that, could you please typing New or Returning");
                        }
                        break;

                    case 2:
                        for (int a = 0; a < Pizza.Size.Count; a++)
                        {
                            if (checker == Pizza.Size[a])
                            {
                                goto case 0;
                            }
                        }
                        Console.WriteLine(message + "size.");
                        break;

                    case 3:
                        for (int a = 0; a < Pizza.Crust.Count; a++)
                        {
                            if (checker == Pizza.Crust[a])
                            {
                                goto case 0;
                            }
                        }
                        Console.WriteLine(message + "crust.");
                        break;

                    case 4:
                        for (int a = 0; a < Pizza.Toppings.Count; a++)
                        {
                            if (Pizza.TempToppings.Contains(checker) || checker == "")
                            {
                                if (checker == Pizza.Toppings[a] || checker == "")
                                {
                                    goto case 0;
                                }
                            }
                        }
                        Console.WriteLine(message + "topping.");
                        break;

                    case 5:
                        for (int a = 1; a < 13; a++)
                        {
                            if (checker == Convert.ToString(a))
                            {
                                goto case 0;
                            }
                        }
                        Console.WriteLine("Please enter a valid quantity.");
                        break;

                    case 6:
                        for (int a = 0; a < Location.Locations.Count; a++)
                        {
                            if (checker == Location.Locations[a])
                            {
                                goto case 0;
                            }
                        }
                        Console.WriteLine("Please enter a valid location");
                        break;

                    case 7:
                        if (checker == "Yes" || checker == "No")
                        {
                            goto case 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't understand that, could you please typing Yes or No");
                        }
                        break;

                    case 10:
                        if (checker == "Yes")
                        {
                            goto case 0;
                        }

                        else if (checker == "No")
                        {
                            Environment.Exit(0);
                        }
                        break;
                }

                if (i == 4)
                {
                    Console.WriteLine("\nYou may only try one more time or you will be forced to exit.");
                }
            }

            Environment.Exit(0);
            return null;
        }

        public bool TestValidation(List<string> actual, List<string> input)
        {
            bool checker = false;
            int checkNum = 0;

            foreach (var size in actual)
            {
                foreach (var item in input)
                {
                    if (size == item)
                    {
                        checkNum++;
                    }
                }
            }

            if (checkNum == input.Count)
            {
                checker = true;
            }

            return checker;
        }

        public static string ReadNext()
        {
            return Console.ReadLine();
        }
    }
}
