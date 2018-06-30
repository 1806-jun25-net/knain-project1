using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Library
{
    public class Validation
    {
        public int ValidationCheck { get; set; }

        public string AttemptValidation()
        {
            string checker = null;

            for (int i = 0; i < 6; i++)
            {
                checker = ReadNext();
                string message = "Sorry I didn't understand that, could you please type a valid pizza ";

                switch (ValidationCheck)
                {
                    case 0:
                        return checker;

                    case 1:
                        if (checker == "New" || checker == "Returning")
                        {
                            goto case 0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't understand that could you please type New or Returning");
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
                            if (checker == Pizza.Toppings[a] || checker == "")
                            {
                                goto case 0;
                            }
                        }
                        Console.WriteLine(message + "topping.");
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

        public virtual string ReadNext()
        {
            return Console.ReadLine();
        }
    }
}
