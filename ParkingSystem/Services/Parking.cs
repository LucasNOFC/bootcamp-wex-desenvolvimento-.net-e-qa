using ParkingSystem.Entities;

namespace ParkingSystem.Services
{
    class Parking
    {

        public void RegisterCar(List<Car> Car, string carModel, string carSign)
        {
            Car registerCar = new(carModel, carSign);
            Car.Add(registerCar);
        }

        public void RemoveCar(List<Car> Car, string carSign)
        {
            int posCar = Car.FindIndex(x => x.CarSign == carSign);

            if (posCar > -1)
            {
            Car.RemoveAt(posCar);
            }

        }

        public void ShowCars(List<Car> Cars)
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"The Model of car is:{car.Model}\n" +
                                  $"The Sign of car is: {car.CarSign}");
            }
        }


        public double PayService(double price, int hours)
        {
            return price * hours;
        }

        
    }


}
