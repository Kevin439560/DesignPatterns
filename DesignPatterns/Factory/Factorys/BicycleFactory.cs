using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Factorys {
    internal class BicycleFactory : IVehicleFactory {
        public BicycleFactory() {
        }
        public IVehicle CreateVehicle(string model, string brand, double value) {

            Bicycle newBicycle = new(model, brand, value);

            return newBicycle;

        }

    }

}
