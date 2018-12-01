using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Flashlight.Flashlight
{
    class FlashLight
    {
        private List<Battery> batteryList = new List<Battery>();
        private int numberOfBatteries;
        private LightBulb lightBulb;
        private Boolean state = false;
        public FlashLight(){}

        public void TurnOnOff()
        {
            if (!IsOn())
            {
                if (CanLight())
                {
                    TakePowerFromBattery();
                    this.state = true;
                    Log.Info("Your flashlight is on now!");
                }
            }
            else if(IsOn())
            {
                this.state = false;
                Log.Info("Your flashlight is off now!");
            }
        }

        public Boolean CanLight()
        {
            if (LightBulbExist())
            {
                if(batteryList.Count >= 2 && StateOfBatteries())
                {
                    return true;
                }else Log.Info("Some battery haven't required power or flashlight haven't required pieces of battery");
            }else Log.Info("Flash light don't have a light bulb");
            return false;
        }
        public Boolean IsOn()
        {
            return state;
        }
        public void AddBattery()
        {
            if (batteryList.Count < 4 && !IsOn())
            {
                batteryList.Add(new Battery());
                numberOfBatteries++;
                Log.Info("You added new battery to your flashlight");
            }
            else Log.Info("Battery socket is full or your flashlight working now");
        }
        public void RemoveBattery()
        {
            if (batteryList.Count > 0 && !IsOn())
            {
                batteryList.RemoveAt(0);
                numberOfBatteries--;
                Log.Info("You removed battery from your flashlight");
            }
            else Log.Info("Battery socket is empty or your flashlight working now");
        }
        public Boolean StateOfBatteries()
        {
            foreach(Battery battery in batteryList)
            {
                if (battery.IsEmpty()) return false;  
            }
            return true;
        }
        public void TakePowerFromBattery()
        {
            foreach (Battery battery in batteryList)
            {
                battery.RemovePower(lightBulb.GetBrightness());
            }
        }
        public void PutLightBulb()
        {
            if (!LightBulbExist())
            {
                this.lightBulb = new LightBulb();
                Log.Info("You put light bulb to your flashlight with brightness " + lightBulb.GetBrightness());
            }
            else Log.Info("You need remove old lightbulb before...");
        }
        public Boolean LightBulbExist()
        {
            return this.lightBulb != null;
        }
        public void RemoveLightBulb()
        {
            if (LightBulbExist() && !IsOn())
            {
                this.lightBulb = null;
                Log.Info("You removed light bulb from your flashlight");
            }
            else Log.Info("You don't have light bulb or your flashlight is still on");
        }

    }
}
