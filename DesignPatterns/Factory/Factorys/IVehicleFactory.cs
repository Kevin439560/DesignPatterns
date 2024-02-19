using DesignPatterns.Factory.Entities;

namespace DesignPatterns.Factory.Factorys {
    internal interface IVehicleFactory {

        public IVehicle CreateVehicle(string model, string brand, double value);


    }
}
