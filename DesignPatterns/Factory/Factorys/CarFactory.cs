using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Factorys {
    internal class CarFactory : IVehicleFactory{
        public CarFactory() {
        }

        public IVehicle CreateVehicle(string model, string brand, double value) {

            Car newCar = new(model, brand, value);

            return newCar;

        }

    }

}
