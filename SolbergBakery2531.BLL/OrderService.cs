using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SolbergBakery2531.BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
                // 1. Generate the PDF Document
                await Task.Run(() => {
                    QuestPDF.Settings.License = LicenseType.Community;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Margin(50);
                            page.Header().Text("SOLBERG BAKERY").FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                            page.Content().PaddingVertical(10).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3); // Name
                                    columns.RelativeColumn(1); // Qty
                                    columns.RelativeColumn(2); // Price
                                    columns.RelativeColumn(2); // Total
                                });

                                // Header Row
                                table.Header(header =>
                                {
                                    header.Cell().Text("Product");
                                    header.Cell().Text("Qty");
                                    header.Cell().Text("Price");
                                    header.Cell().Text("Total");
                                });

                                // Item Rows
                                foreach (var item in items)
                                {
                                    table.Cell().Text(item.Name);
                                    table.Cell().Text(item.Quantity.ToString());
                                    table.Cell().Text($"{item.Price:C}");
                                    table.Cell().Text($"{(item.Price * item.Quantity):C}");
                                }
                            });

                            page.Footer().AlignCenter().Text(x => {
                                x.Span("Page ");
                                x.CurrentPageNumber();
                            });
                        });
                    }).GeneratePdf(filePath);
                });
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public bool RunPurchase(List<OrderItemDTO> items)
        {
            if (!items.Any())
            {
                return false;
            }
            var prodService = new ProductService();
            foreach (var item in items)
            {
                DataTable dt = prodService.FetchProductById(item.ProductId);
                if (dt.Rows.Count > 0)
                {
                    int currentStock = Convert.ToInt32(dt.Rows[0]["quantityInStock"]);
                    prodService.LogStock(item.ProductId, -item.Quantity, item.Price * 0.9m, item.Price, "From Order");
                    prodService.UpdateStock(item.ProductId, currentStock - item.Quantity);
                }
            }
            return true;
        }
    } 
}
