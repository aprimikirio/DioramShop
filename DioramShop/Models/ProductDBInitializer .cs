using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DioramShop.Models
{
    public class ProductDBInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            db.Products.Add(new Product { Name = "Ekert Diorama", Price = 200 });
            db.Products.Add(new Product { Name = "Shops Diorama", Price = 150 });
            db.Products.Add(new Product { Name = "Fire Station Diorama", Price = 450 });

            base.Seed(db);
        }
    }
}