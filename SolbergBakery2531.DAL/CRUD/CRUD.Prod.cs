using SolbergBakery2531.DAL.Data;
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
        public DataTable GetProdVisual()
        {
            using (var db = new BakeryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(Guid));
                dt.Columns.Add("VisualinByte", typeof(byte[]));
                dt.Columns.Add("ProductId", typeof(Guid));

                var List = db.ProductVisuals.Select(p => new
                {
                    p.Id,
                    p.VisualinByte,
                    p.ProductId,
            }).ToList();

                foreach (var p in List)
                {
                    dt.Rows.Add(
                        p.Id,
                        p.VisualinByte,
                        p.ProductId
                    );
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

        public bool SaveProd(Guid id, string name, string des, string note, decimal price, DateTime aDate, DateTime dDate)
        {
            throw new NotImplementedException();
        }
        public bool InsertProdVisual(Guid Id, byte[] visual, Guid prodId)
        {
            throw new NotImplementedException();
        }
        public bool RemoveProd(Guid id)
        {
            throw new NotImplementedException();
        }
        public bool RemoveProdVisual(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
