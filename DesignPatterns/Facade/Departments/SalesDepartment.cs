namespace DesignPatterns.Facade.Departments {
    class SalesDepartment : IDepartment {

        private string Description { get; }

        public SalesDepartment(string desc) {

            Description = desc;

        }

        public string ShowInfo() {

            return Description;

        }

        public void Income() {

            Console.WriteLine("The week income");

        }


    }
}
