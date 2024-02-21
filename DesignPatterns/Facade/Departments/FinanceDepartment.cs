
namespace DesignPatterns.Facade.Departments {
    class FinanceDepartment : IDepartment {

        private string Description { get; }

        public FinanceDepartment(string desc) {

            Description = desc;

        }

        public string ShowInfo() {

            return Description;

        }
    
        public void Amount() {

            Console.WriteLine("The amount of the company");
        }


    }
}
