using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand.StoreProc
{
    public class InfoBuild
    {
        public string GetInfo(string tableName, ListView.ListViewItemCollection paramCollection)
        {
            string selectPart = string.Empty;
            string fromPart = "dbo." + tableName + " WITH (NOLOCK)";
            string wherePart = string.Empty;
            foreach (ListViewItem lv in paramCollection)
            {
                if (lv.SubItems[4].Text.ToLower() != "input")
                {
                    selectPart += (selectPart != string.Empty ? "\r\n,	" : "") + "@" + lv.Text + " = " + lv.Text;
                }
                else
                {
                    wherePart += (wherePart != string.Empty ? "\r\nAND	" : "WHERE\r\n	") + "@" + lv.Text + " = " + lv.Text;
                }
            }

            string query = @"
SELECT
	" + selectPart + @"
FROM
	" + fromPart + @"
" + wherePart;
            return query;
        }
    }
}
