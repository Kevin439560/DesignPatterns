using System.Globalization;

namespace DesignPatterns.Factory.Entities {
    internal class Bicycle : IVehicle {

        public string Model { get; set; }
        public string Brand { get; set; }
        public double Value { get; set; }

        public Bicycle(string model, string brand, double value) {
            Model = model;
            Brand = brand;
            Value = value;
        }

        public void ShowInfo() {
            Console.WriteLine("Model: " +
                Model +
                ", Brand: " +
                Brand +
                ", Value: " +
                Value.ToString("F2",CultureInfo.InvariantCulture)); 

        }
    }
}

