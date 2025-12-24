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

        //public DataTable GetHistxxxxxories(Guid Id)
        //{
        //    using (var db = new BakeryDbContext())
        //    {
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("StartDate", typeof(DateTime));
        //        dt.Columns.Add("EndDate", typeof(DateTime));
        //        dt.Columns.Add("Ongoing", typeof(bool));
        //        dt.Columns.Add("FeedBack", typeof(string));

        //        var HistoryRecords = db.StaffHistories
        //            .Where(h => h.StaffId == Id)
        //            .Select(h => new
        //            {
        //                h.Start,
        //                h.End,
        //                h.Ongoing,
        //                h.HR_Feedback,
        //            })
        //            .ToList();

        //        foreach (var h in HistoryRecords)
        //        {
        //            dt.Rows.Add(
        //                h.Start,
        //                h.End,
        //                h.Ongoing,
        //                h.HR_Feedback
        //            );
        //        }
        //        return dt;
        //    }
        //}
        public List<StaffHistory> GetHistories(Guid staffId)
        //human history
        {
            using (var db = new BakeryDbContext())
            {
                return db.StaffHistories
                         .Where(h => h.StaffId == staffId)
                         .ToList();
            }
        }
        public void Historian(BakeryDbContext db, Guid Id, bool OngoingStatus)
        {
            if (OngoingStatus)
            {
                db.StaffHistories.Add(new StaffHistory
                {
                    StaffId = Id,
                    Start = DateTime.UtcNow,
                    Ongoing = OngoingStatus
                });
            }
            else
            {
                var ongoingHistory = db.StaffHistories.FirstOrDefault(h => h.StaffId == Id && h.Ongoing);
                if (ongoingHistory != null)
                {
                    ongoingHistory.End = DateTime.UtcNow;
                    ongoingHistory.Ongoing = OngoingStatus;
                }
            }
        }
        public bool svHistory(Guid staffId, string hr_feedback)
        {
            try
            {
                using (var db = new BakeryDbContext())
                {
                    // Find the active/ongoing history record so HR cant edit old records by sheer free will OwO
                    var record = db.StaffHistories
                        .Where(h => h.StaffId == staffId && h.Ongoing == true)
                        .OrderByDescending(h => h.Start)
                        .FirstOrDefault();

                    if (record != null)
                    {
                        record.HR_Feedback = hr_feedback;
                        db.SaveChanges();
                        return true;
                    }

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }



        public bool LogStockHistory(Guid productId, int changeQty, decimal importVal, decimal saleVal, string source)
        {
        //prod history
            using (var db = new BakeryDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Id == productId);
                if (product == null) return false;

                var history = new ProductHistory
                {
                    ChangeId = Guid.NewGuid(),
                    ProductId = productId,
                    ChangeQuantity = changeQty,
                    ImportValue = importVal,
                    SaleValue = saleVal,
                    Source = source,
                    ChangeOccur = DateTime.Now
                };
                db.ProductHistories.Add(history);
                return db.SaveChanges() > 0;
            }
        }

        public List<ProductHistory> GetHistoryByProduct(Guid productId)
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProductHistories
                         .Where(h => h.ProductId == productId)
                         .OrderByDescending(h => h.ChangeOccur)
                         .ToList();
            }
        }

        public List<ProductHistory> GetAllHistory()
        {
            using (var db = new BakeryDbContext())
            {
                return db.ProductHistories
                         .OrderByDescending(h => h.ChangeOccur)
                         .ToList();
            }
        }

        public bool RemoveHistoryEntry(Guid changeId)
        {
            using (var db = new BakeryDbContext())
            {
                var entry = db.ProductHistories.FirstOrDefault(h => h.ChangeId == changeId);
                if (entry != null)
                {
                    db.ProductHistories.Remove(entry);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
        }
    }
}
