using System;


using System.Data;

using System.Windows.Forms;

namespace DVLD_Manage
{
    internal class clsDGV_Filter
    {
        public static void Filter(string Text , string ColumnName , DataGridView DGV, DataTable DT, ref int CountRow)
        {
            if (ColumnName == null || ColumnName == string.Empty)
                return;

            ColumnName = clsMethodes.RemoveAllEmptiness(ColumnName);

            DataTable dt = DT;

            if (Text == null || Text == string.Empty)
            {
                DGV.DataSource = dt;
            }

            DataView dataView = new DataView(dt);

                       
            dataView.RowFilter = $"CONVERT({ColumnName}, 'System.String') Like '%{Text}%'";
            

            DGV.DataSource = dataView ;
            CountRow = DGV.RowCount;

        }
    
        public static void FilterActiveUsers(bool IsActive , DataGridView DGV, DataTable DT)
        {

            DataView dataView = new DataView(DT);

            dataView.RowFilter = $"IsActive = {IsActive}";

            DGV.DataSource = dataView ;
        }
    
    
    }
}
