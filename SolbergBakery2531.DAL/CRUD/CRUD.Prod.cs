using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {

        public List<Product> GetProd()
        {
            using (var db = new BakeryDbContext())
            {
                return db.Products.ToList();
            }
            //using (var db = new BakeryDbContext())
            //{
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Id", typeof(Guid));
            //    dt.Columns.Add("Description", typeof(string));
            //    dt.Columns.Add("Note", typeof(string));
            //    dt.Columns.Add("AvailableDate", typeof(DateTime));
            //    dt.Columns.Add("DiscontinueDate", typeof(DateTime));
            //    dt.Columns.Add("ProdCategoryId", typeof(Guid));
            //    dt.Columns.Add("Pricing", typeof(decimal));
            //    dt.Columns.Add("Name", typeof(string));

            //    var List = db.Products.Select(p => new
            //    {
            //        p.Id,
            //        p.Description,
            //        p.Note,
            //        p.AvailableDate,
            //        p.DiscontinueDate,
            //        p.ProdCategoryId,
            //        p.Pricing,
            //        p.Name,
            //    }).ToList();

            //    foreach (var p in List)
            //    {
            //        dt.Rows.Add(
            //            p.Id,
            //            p.Description,
            //            p.Note,
            //            p.AvailableDate,
            //            p.DiscontinueDate,
            //            p.ProdCategoryId,
            //            p.Pricing,
            //            p.Name
            //        );
            //    }
            //    return dt;
            //}
        }
        public List<Product> GetProd(Guid cateId)
        {
            using (var db = new BakeryDbContext())
            {
                return db.Products
                         .Where(p => p.ProdCategoryId == cateId)
                         .ToList();
            }
        }
        public List<ProdCategory> GetProdCate()
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProdCategories.ToList();
            }
        }

        public bool SaveProd(Guid id, string name, string des, string note, decimal price, DateTime aDate, DateTime dDate, Guid cateId)
        {
            using (var db = new BakeryDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == id);

                if (product != null)
                {
                    product.Name = name;
                    product.Description = des;
                    product.Note = note;
                    product.Pricing = price;
                    product.AvailableDate = aDate;
                    product.DiscontinueDate = dDate;
                    product.ProdCategoryId = cateId;
                }
                else
                {
                    var newProd = new Product
                    {
                        Id = id == Guid.Empty ? Guid.NewGuid() : id,
                        Name = name,
                        Description = des,
                        Note = note,
                        Pricing = price,
                        AvailableDate = aDate,
                        DiscontinueDate = dDate,
                        ProdCategoryId = cateId
                    };
                    db.Products.Add(newProd);
                }

                return db.SaveChanges() > 0;
            }
        }
        public Product GetProdSingle(Guid id)
        {
            using (var db = new BakeryDbContext())
            {
                return db.Products.FirstOrDefault(p => p.Id == id);
            }
        }
        public bool RemoveProd(Product prod)
        {
            using (var db = new BakeryDbContext())
            {
                if (prod != null)
                {
                    return false;
                }
                db.Products.Attach(prod);
                db.Products.Remove(prod);
                return db.SaveChanges() > 0;
            }
            //using (var db = new BakeryDbContext())
            //{
            //    var product = db.Products.FirstOrDefault(p => p.Id == id);
            //    if (product != null)
            //    {
            //        var visuals = db.ProductVisuals.Where(v => v.ProductId == id);
            //        db.ProductVisuals.RemoveRange(visuals);

            //        db.Products.Remove(product);
            //        return db.SaveChanges() > 0;
            //    }
            //    return false;
            //}
        }
        public bool UpdateStockLevel(Guid prodId, int newQuantity)
        {
            using (var db = new BakeryDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == prodId);
                if (product != null)
                {
                    product.quantityInStock = newQuantity;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
