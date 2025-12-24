using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolbergBakery2531._utils
{
    public static class DataGridExtensions
    {
        public static DataRow GetSelectedRow (this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0) return null;

            var r = grid.SelectedRows[0];

            if (r == null || r.IsNewRow) return null;

            if (r.DataBoundItem is DataRowView drv) return drv.Row; 

            return null; 
        }
        public static DataGridViewRow GetSelectedGridRow(this DataGridView grid)
        {//case when row was manually add() and not a result of being bond to a source
            if (grid.SelectedRows.Count == 0)
                return null;

            var row = grid.SelectedRows[0];
            return row.IsNewRow ? null : row;
        }

    }
}
