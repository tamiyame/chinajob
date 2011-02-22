using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand.StoreProc
{
    public class InsertBuild
    {
        public string GetInsert(string tableName, ListView.ListViewItemCollection paramCollection)
        {
            string headPart = string.Empty;
            string tbName = "dbo." + tableName;
            string selectPart = string.Empty;
            foreach (ListViewItem lv in paramCollection)
            {
                headPart += (headPart != string.Empty ? "\r\n,	" : "") + lv.Text;
                selectPart += (selectPart != string.Empty ? "\r\n,	" : "") + "@" + lv.Text;
            }

            string query = @"
INSERT	" + tableName + @"
(
	" + headPart + @"
)
SELECT
	" + selectPart + @"
SELECT
	@FrkErrorCode = @@ERROR
,	@FrkRowCount = @@RowCount
";
            return query;
        }
    }
}
