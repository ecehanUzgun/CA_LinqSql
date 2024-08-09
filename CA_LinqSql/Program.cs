using CA_LinqSql.Concretes.Services;
using CA_LinqSql.models;

namespace CA_LinqSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            //productService.GetAvgProductPrice();
            productService.GetStockCategorySum();

            EmployeeService employeeService = new EmployeeService();
            //employeeService.GetCountryEmployeeCount();

        }
    }
}
