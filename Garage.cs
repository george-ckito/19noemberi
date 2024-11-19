using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19noemberi
{
    internal class Garage
    {
        public List<Car> Cars = new List<Car>();
        public static int count = 0;
        public Garage()
        {
            count++;
        }
        public Garage(params Car[] cars)
        {
            Cars.AddRange(cars);
        }
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void ShowCars()
        {
            foreach (Car car in Cars)
            {
                car.ShowInfo();
                Console.WriteLine();
            }
        }
        public Car GetFastest()
        {
            Car fastest = Cars[0];
            foreach (Car car in Cars)
            {
                if (car.MaxSpeed > fastest.MaxSpeed)
                {
                    fastest = car;
                }
            }
            fastest.ShowInfo();
            return fastest;
        }
        public Car GetExpensive()
        {
            Car expensive = Cars[0];
            foreach (Car car in Cars)
            {
                if (car.Price > expensive.Price)
                {
                    expensive = car;
                }
            }
            expensive.ShowInfo();
            return expensive;
        }
        public Car GetCheapest()
        {
            Car cheapest = Cars[0];
            foreach (Car car in Cars)
            {
                if (car.Price < cheapest.Price)
                {
                    cheapest = car;
                }
            }
            cheapest.ShowInfo();
            return cheapest;
        }
        public Car GetNewest()
        {
            Car bestCondition = Cars[0];
            foreach (Car car in Cars)
            {
                if (car.Condition > bestCondition.Condition)
                {
                    bestCondition = car;
                }
            }
            bestCondition.ShowInfo();
            return bestCondition;
        }
        
        public Car GetTesla()
        {
            foreach(Car car in Cars)
            {
                if (car.Model == "Tesla")
                {
                    car.ShowInfo();
                    return car;
                }
            }
            return null;
        }

    }
}
