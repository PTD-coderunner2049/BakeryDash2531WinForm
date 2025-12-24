using SolbergBakery2531.BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SolbergBakery2531.BLL
{
    public class OrderService
    {
        public bool ValidateQuantity(int inputQty, int stockLimit, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (inputQty < 1)
            {
                errorMessage = "Quantity must be at least 1.";
                return false;
            }

            if (inputQty > stockLimit)
            {
                errorMessage = $"Sorry! Only {stockLimit} items available in stock.";
                return false;
            }
            return true;
        }
        public async Task<bool> ExportOrderToPdf(string filePath, List<OrderItemDTO> items)
        {
            try
            {
                await Task.Run(() => {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine("SOLBERG BAKERY - RECEIPT");
                        sw.WriteLine($"Date: {DateTime.Now}");
                        sw.WriteLine("--------------------------");
                        foreach (var item in items)
                        {
                            sw.WriteLine($"{item.Name.PadRight(15)} x{item.Quantity} @ {item.Price:C}");
                        }
                    }
                });

                var prodService = new ProductService();

                foreach (var item in items)
                {
                    DataTable dt = prodService.FetchProductById((Guid)item.ProductId);
                    if (dt.Rows.Count > 0)
                    {
                        int currentStock = Convert.ToInt32(dt.Rows[0]["quantityInStock"]);
                        int remainingStock = currentStock - item.Quantity;
                        
                        prodService.UpdateStock(item.ProductId, remainingStock);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    } 
}
