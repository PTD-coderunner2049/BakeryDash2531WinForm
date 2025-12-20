using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Data;
using System.Linq;
namespace SolbergBakery2531.DAL
{
    public partial class CRUD
    {
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
        public bool InsertProdVisual(byte[] visualBytes, Guid prodId)
        {
            using (var db = new BakeryDbContext())
            {
                if (!db.Products.Any(p => p.Id == prodId)) return false;

                var newVisual = new ProductVisual
                {
                    Id =Guid.NewGuid(),
                    VisualinByte = visualBytes,
                    ProductId = prodId
                };

                db.ProductVisuals.Add(newVisual);
                return db.SaveChanges() > 0;
            }
        }
        public bool RemoveProdVisual(Guid visualId)
        {
            using (var db = new BakeryDbContext())
            {
                var visual = db.ProductVisuals.FirstOrDefault(v => v.Id == visualId);
                if (visual != null)
                {
                    db.ProductVisuals.Remove(visual);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
