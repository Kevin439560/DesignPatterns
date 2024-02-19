using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Factorys {
    internal class MotorcycleFactory : IVehicleFactory {
        public MotorcycleFactory() {
        }

        public IVehicle CreateVehicle(string model, string brand, double value) {

            Motorcycle newMotorCycle = new(model, brand, value);

            return newMotorCycle;

        }

    }

}
