
using System.Text;

namespace DesignPatterns.Facade.Departments {
    class FacaDepartment {

        public FinanceDepartment FinanceDepartment { get; set; }

        public ITDepartment ITDepartment { get; set; }

        public SalesDepartment SalesDepartment { get; set; }

        public FacaDepartment() {

            FinanceDepartment = new("O departamento financeiro cuida da gestao financeira da empresa, sua renda e seus investimentos");
            ITDepartment = new("O departamento de TI cuida do suporte técnico em relacao a tecnologia da empresa");
            SalesDepartment = new("O departamento de vendas gerencia os funcionarios, os rendimentos e os direciona ao departamento financeiro");

        }

        public void ITSuport() {

            ITDepartment.ProvideSupport();

        }

        public void Amount() {

            FinanceDepartment.Amount();

        }

        public void Income() {

            SalesDepartment.Income();

        }

        public void ShowInfo() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Departamento de TI \n\n" +
                ITDepartment.ShowInfo() +
                "\n\n\nDepartamento de Finanças \n\n" +
                FinanceDepartment.ShowInfo() +
                "\n\n\nDepartamento de Vendas \n\n" +
                SalesDepartment.ShowInfo());

            Console.WriteLine(sb); 
        }
    }
}
