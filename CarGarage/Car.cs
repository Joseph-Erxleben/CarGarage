using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        public void SetMake(string make)
        {
            Make = make;
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public bool IsSpeeding()
        {
            bool isSpeeding;

            if(Speed>70)
            {
                isSpeeding = true;
            }

            else
            {
                isSpeeding = false;
            }

            return isSpeeding;
        }

        public void Accelerate()
        {
            if (Make == null)
            {
                Make = "";
            }

            if (Make.Equals("Ferrari"))
            {
                Speed = Speed + 20;
            }

            else
            {
                Speed = Speed + 10;
            }

            if (Speed > 100)
            {
                Speed = 100;
            }
        }

        public void Brake()
        {
            if (AutoBrakeActive == true)
            {
                Speed = Speed / 2;
            }

            else
            {
                Speed = Speed - 7;
            }

            if (Speed < 0)
            {
                Speed = 0;
            }
        }
    }

}
