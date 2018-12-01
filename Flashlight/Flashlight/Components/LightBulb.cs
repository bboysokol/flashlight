using System;
using System.Collections.Generic;
using System.Text;

namespace Flashlight.Flashlight
{
    class LightBulb
    {
        private readonly int brightness;
        public LightBulb()
        {
            Random generator = new Random();
            brightness = generator.Next(1, 11);
        }
        public int GetBrightness()
        {
            return brightness;
        }
    } 
}
