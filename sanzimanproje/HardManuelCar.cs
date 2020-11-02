using System;
using System.Collections.Generic;
using System.Text;

namespace sanzimanproje
{
    public class HardManuelCar : Car
    {
        public HardManuelCar(string v, string v1, int v2, string v3) 
        {
            Name = v;
            Model = v1;
            MaxSpeed = v2;
            GearType = v3;
        }

        public override void Gear()
        {
            Console.Write("Destekli Tır Vitesi : ");
        }
        public override void Using()
        {
            Console.WriteLine("Çok Zor Kullanım.");
        }
    }
}
