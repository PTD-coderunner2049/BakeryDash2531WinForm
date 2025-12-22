using SolbergBakery2531.DAL;
using SolbergBakery2531.DAL.Data;
using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;

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
    }
}
