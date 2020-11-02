using System;

namespace sanzimanproje
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomaticCar automaticCar = new AutomaticCar("Volvo" , "Otomobil" , 180, "Otomatik Vites");
            automaticCar.Properties();
            automaticCar.Gear();
            automaticCar.Using();

            Console.WriteLine(" ");

            HardManuelCar hardManuelCar = new HardManuelCar("Scania", "Tır", 130, "Destekli Tır Vitesi");
            hardManuelCar.Properties();

            
            hardManuelCar.Gear();
            hardManuelCar.Using();
       
        

           
            Console.ReadLine();
        }
    }
}
