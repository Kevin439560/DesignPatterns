using DesignPatterns.Facade.Departments;
using DesignPatterns.Factory.Entities;
using DesignPatterns.Factory.Factorys;

namespace DesingPatterns {
    class Program { 
    
        static void Main(string[] args) {


            FacaDepartment facade = new ();
            facade.ShowInfo();





            /*
             //// FACTORY ////
            BicycleFactory BF = new();
            CarFactory CF = new ();
            MotorcycleFactory MF = new ();

            Bicycle b1 = (Bicycle)BF.CreateVehicle("Velox", "Caloi", 1200.00);
            Car b2 = (Car)CF.CreateVehicle("Focus", "Ford", 120000.00);
            Motorcycle b3 = (Motorcycle)MF.CreateVehicle("160", "Honda", 30000.00);
            b1.ShowInfo(); 
            b2.ShowInfo();
            b3.ShowInfo();
            
            */
        }
    }

}

