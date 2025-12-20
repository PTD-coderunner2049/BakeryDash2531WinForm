using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SolbergBakery2531._utils
{
    public static class BLLUtils
    {
        public static string GetFilteredView(string columnName, string filterValue)
        {
            string safeValue = filterValue.Replace("'", "''");
            return $"CONVERT({columnName}, 'System.String') LIKE '%{safeValue}%'";
        }
    }
}