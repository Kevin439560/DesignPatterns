
namespace DesignPatterns.Facade.Departments {
    class ITDepartment : IDepartment{

        private string Description { get; }

        public ITDepartment(string desc) {
            
            Description = desc;

        }

        public string ShowInfo() {

            return Description;

        }

        public void ProvideSupport() {

            Console.WriteLine("The department will provide support");

        }


    }
}
