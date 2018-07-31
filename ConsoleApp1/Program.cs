using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MyDbContext();
            var data = db.SalesLT_Products
                .Where(d => d.Size != null).Take(10).ToList();

            var data2 = (from product in db.SalesLT_Products
                        where product.Size != null
                        select product)
                        .Take(10);
                       
                   
            foreach (var item in data)
            {
                Console.WriteLine($"{item.ProductId},{item.Name}");
            }
            Console.WriteLine("==========================================");
            foreach (var item in data2)
            {
                Console.WriteLine($"{item.ProductId},{item.Name}");
            }
            // Console.ReadKey();
        }
    }
}
