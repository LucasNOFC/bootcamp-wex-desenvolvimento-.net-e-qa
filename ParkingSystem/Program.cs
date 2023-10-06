using ParkingSystem.Entities;
using ParkingSystem.Services;
using System;

namespace course
{
    public class ParkingSystem
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            Parking functions = new Parking();
            
            int opt = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Wellcome to the Parking System:");
                Console.WriteLine("1 - Register Car");
                Console.WriteLine("2 - Remove Car");
                Console.WriteLine("3 - See Cars");
                Console.WriteLine("Any - Exit");
                Console.Write("What option you chose:");

                opt = int.Parse(Console.ReadLine());

                switch(opt)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Type the Model:");
                        string carModel = Console.ReadLine();
                        Console.Write("Type the Car Sign:");
                        string carSign = Console.ReadLine();
                        Car car = new Car(carModel, carSign);

                        functions.RegisterCar(cars, carModel, carSign);
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Type the Car Sign:");
                        carSign = Console.ReadLine();

                        functions.RemoveCar(cars, carSign);
                        break;

                    case 3:
                        Console.Clear();
                        functions.ShowCars(cars);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Out");
                        break;
                }
            } while (opt > 0 || opt < 4);
        }
    }
}