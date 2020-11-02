using System;
using System.Collections.Generic;
using System.Text;

namespace sanzimanproje
{
    public abstract class Car : ICar
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public int MaxSpeed { get; set; }

        public string GearType { get; set; }

        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Gas()
        {
            throw new NotImplementedException();
        }
        public virtual void Gear()
        {
            Console.Write("Manuel Vitesli Araba: ");
        }

        public virtual void Using()
        {
            Console.WriteLine("Zor Kullanım.");
        }
        public void Properties()
        {
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Model: {0}",Model);
            Console.WriteLine("Max Speed: {0}",MaxSpeed);
            Console.WriteLine("Gear Type: {0}",GearType);
        }

    }
}
