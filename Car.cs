using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19noemberi
{
    internal class Car
    {
        public string Model;
        public int MaxSpeed;
        public int Condition;
        public int Price;
        public Car(string model, int maxSpeed, int condition, int price)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Condition = condition;
            Price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Max Speed: " + MaxSpeed);
            Console.WriteLine("Condition: " + Condition);
            Console.WriteLine("Price: " + Price);
        }
        public void daqoqva()
        {
            Console.WriteLine("vrum vrum");
        }
    }
}
