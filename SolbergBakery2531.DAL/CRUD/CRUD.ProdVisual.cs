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
        public DataTable GetProdVisual(Guid productId)
        {
            using (var db = new BakeryDbContext())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(Guid));
                dt.Columns.Add("VisualinByte", typeof(byte[]));
                dt.Columns.Add("ProductId", typeof(Guid));

                var List = db.ProductVisuals
                    .Where(p => p.ProductId == productId)
                    .Select(p => new
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
        //        var visuals = db.ProductVisuals.Where(v => v.ProductId == id);
        public List<ProductVisual> GetProductVisualsByProductId(Guid productId)
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProductVisuals
                    .Where(pv => pv.ProductId == productId)
                    .ToList();
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
        public bool RemoveProdVisualsByProductId(Guid productId)
        {
            using (var db = new BakeryDbContext())
            {
                var visuals = db.ProductVisuals.Where(v => v.ProductId == productId).ToList();
                if (visuals.Any())
                {
                    db.ProductVisuals.RemoveRange(visuals);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
