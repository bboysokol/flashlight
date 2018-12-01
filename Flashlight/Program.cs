using Flashlight.Flashlight;
using System;

namespace Flashlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it's a flashlight simulator. Enjoy it!");
            FlashLight flashLight = new FlashLight();
            for (;;)
            {
                Log.Info("\n1. Turn on/off flashlight \n2. Add new battery\n3. Remove battery\n4. Put new light bulb\n5. Remove light bulb\n6. Exit\n ");

                int.TryParse(Console.ReadLine(), out int menuPick);
                switch (menuPick)
                {
                    case 0: Log.Info("You have to enter a number(1-6)!");break;
                    case 1: flashLight.TurnOnOff(); break;
                    case 2: flashLight.AddBattery(); break;
                    case 3: flashLight.RemoveBattery(); break;
                    case 4: flashLight.PutLightBulb(); break;
                    case 5: flashLight.RemoveLightBulb(); break;
                    case 6: System.Environment.Exit(1); break;
                    default: Log.Info("Choose the right option!"); break;
                }
            }
        }
    }
}
