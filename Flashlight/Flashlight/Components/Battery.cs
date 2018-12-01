using System;
using System.Collections.Generic;
using System.Text;

namespace Flashlight.Flashlight
{
    class Battery
    {
        private int power;

        public Battery()
        {
            power = 100;
        }

        public Boolean IsEmpty()
        {
            return (power < 15);
        }
        public Boolean RemovePower(int minusPower)
        {
            if (!IsEmpty())
            {
                power -= minusPower;
                return true;
            }
            return false;
        }
    }
}
