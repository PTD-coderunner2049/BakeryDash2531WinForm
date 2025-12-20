using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Data;
using System.Linq;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {

        public DataTable GetProd()
        {
            using (var db = new BakeryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(Guid));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Note", typeof(string));
                dt.Columns.Add("AvailableDate", typeof(DateTime));
                dt.Columns.Add("DiscontinueDate", typeof(DateTime));
                dt.Columns.Add("ProdCategoryId", typeof(Guid));
                dt.Columns.Add("Pricing", typeof(decimal));
                dt.Columns.Add("Name", typeof(string));

                var List = db.Products.Select(p => new
                {
                    p.Id,
                    p.Description,
                    p.Note,
                    p.AvailableDate,
                    p.DiscontinueDate,
                    p.ProdCategoryId,
                    p.Pricing,
                    p.Name,
                }).ToList();

                foreach (var p in List)
                {
                    dt.Rows.Add(
                        p.Id,
                        p.Description,
                        p.Note,
                        p.AvailableDate,
                        p.DiscontinueDate,
                        p.ProdCategoryId,
                        p.Pricing,
                        p.Name
                    );
                }
                return dt;
            }
        }
        public DataTable GetProd(Guid cateId)
        {
            using (var db = new BakeryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(Guid));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("quantityInStock", typeof(int));

                var list = db.Products.Where(p => p.ProdCategoryId == cateId).ToList();
                foreach (var p in list)
                {
                    dt.Rows.Add(
                        p.Id,
                        p.Name,
                        p.quantityInStock);
                }
                return dt;
            }
        }
        public DataTable GetProdCate()
        {
            using (var db = new BakeryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(Guid));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("EngName", typeof(string));

                var List = db.ProdCategories.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.EngName,
                }).ToList();

                foreach (var p in List)
                {
                    dt.Rows.Add(
                        p.Id,
                        p.Name,
                        p.EngName
                    );
                }
                return dt;
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

        public bool RemoveProd(Guid id)
        {
            using (var db = new BakeryDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    var visuals = db.ProductVisuals.Where(v => v.ProductId == id);
                    db.ProductVisuals.RemoveRange(visuals);

                    db.Products.Remove(product);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
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
