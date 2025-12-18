using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryDash2531._utils
{
    public static class DataGridExtensions
    {
        public static DataRow GetSelectedRow (this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return null;

            DataGridViewRow r = grid.SelectedRows[0];

            if (r == null || r.IsNewRow)
                return null;
            return ((DataRowView)r.DataBoundItem).Row;
        }
    }
}
