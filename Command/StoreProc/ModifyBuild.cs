using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand.StoreProc
{
    public class ModifyBuild
    {
        public string GetUpdate(string tableName, ListView.ListViewItemCollection lvCollection)
        {
            string setPart = string.Empty;
            string tbName = "dbo." + tableName;
            string wherePart = string.Empty;

            foreach (ListViewItem item in lvCollection)
            {
                if (item.SubItems[3].Text.ToLower() == "true")
                {
                    wherePart += (wherePart != string.Empty ? "\r\nAND	" : "") + item.Text;
                }
                setPart += (setPart != string.Empty ? "\r\n,	" : "") + item.Text + " = IsNull( @" + item.Text + ", " + item.Text + " )";
            }

            string retValue = string.Empty;
            retValue = @"

UPDATE
	" + tbName + @"
SET
	" + setPart + @"
WHERE
	" + wherePart;
            return retValue;
        }
    }
}
