using CA_LinqSql.Abstracts.Interfaces;
using CA_LinqSql.models;
using System.Linq;

namespace CA_LinqSql.Concretes.Services
{
    internal class ProductService : IProductRepository
    {
        private readonly NorthwindContext _db;
        public ProductService()
        {
            _db = new NorthwindContext();
        }
        public void GetAvgProductPrice()
        {
            //select CategoryID,AVG(UnitPrice) from Products group by CategoryID 
            #region linq to Sql
            //var query = from p in _db.Products
            //            group p by p.CategoryId
            //                into g
            //            select new
            //            {
            //                Category = g.Key,
            //                Average = g.Average(p => p.UnitPrice)
            //            };
            //foreach (var item in query.ToList())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(query.ToList().Count());
            #endregion

            #region linq to entity
            var format = _db.Products.GroupBy(p => p.CategoryId).Select(p => new
            {
                Category = p.Key,
                Average = p.Average(p => p.CategoryId)
            }).ToList();
            foreach (var item in format)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(format.ToList().Count()); 
            #endregion
        }

        public void GetStockCategorySum()
        {
            //select CategoryID, SUM(UnitsInStock * UnitPrice) from Products group by CategoryID having SUM(UnitsInStock* UnitPrice)> 10000
            var format = _db.Products.GroupBy(c => c.CategoryId).Select(c => new
            {
                Category = c.Key,
                Sum = c.Sum(c => c.UnitsInStock*c.UnitPrice)
            }).ToList();
            foreach(var item in format)
            { 
                Console.WriteLine(item); 
            }
            Console.WriteLine(format.Count());
        }
    }
}
