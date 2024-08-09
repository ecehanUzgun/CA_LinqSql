using CA_LinqSql.Abstracts.Interfaces;
using CA_LinqSql.models;

namespace CA_LinqSql.Concretes.Services
{
    internal class EmployeeService : IEmployeeRepository
    {
        private readonly NorthwindContext _db;
        public EmployeeService()
        {
            _db = new NorthwindContext();
        }
        public void GetCountryEmployeeCount()
        {
            //select Country,COUNT(*) from Employees group by Country
            #region Linq to Sql
            //var query = from e in _db.Employees
            //            group e by e.Country into g
            //            select new
            //            {
            //                Country = g.Key,
            //                Count = g.Count()
            //            };
            //foreach (var e in query.ToList())
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine(query.ToList().Count());
            #endregion

            #region Linq to Entity
            var format = _db.Employees.GroupBy(e => e.Country).
                    Select(e => new
                    {
                        Country = e.Key,
                        Count = e.Count()
                    });
            foreach (var e in format.ToList())
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(format.ToList().Count()); 
            #endregion

        }
    }
}
