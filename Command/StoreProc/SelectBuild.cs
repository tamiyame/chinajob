using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand.StoreProc
{
    public class SelectBuild
    {
        public string GetSelect(string tableName, ListView.ListViewItemCollection lvCollection)
        {
            string selectPart = string.Empty;
            string selectInnerPart = string.Empty;
            string fromPart = "dbo." + tableName + " with ( nolock )";
            string orderPart = string.Empty;

            foreach (ListViewItem item in lvCollection)
            {
                if (item.SubItems[3].Text.ToLower() == "true")
                {
                    orderPart += (orderPart != string.Empty ? ", " : "") + item.Text + " DESC";
                }
                selectPart += (selectPart == string.Empty ? "" : "\r\n	,	") + item.Text;
                selectInnerPart += (selectInnerPart == string.Empty ? "" : "\r\n		,	") + item.Text;
            }

            string retValue = string.Empty;
            retValue = @"
DECLARE @SkipPage INT
SET @SkipPage = ( ( @PageNo - 1 ) * @PageSize )

IF ( @PageNo = 1 )
BEGIN
	SELECT	Top( @PageSize )
		" + selectPart + @"
	FROM
		" + fromPart + @"
	ORDER BY
		" + orderPart + @"
END
ELSE
BEGIN
	SELECT	Top( @PageSize )
		" + selectPart + @"
	FROM
	(
		SELECT
			" + selectInnerPart + @"
		,	ROW_NUMBER() OVER ( ORDER BY
			" + orderPart + @"
		) AS ROWNUM
		FROM
			" + fromPart + @"
	)	A
	WHERE
		ROWNUM > @SkipPage
	AND	ROWNUM <= @SkipPage + @PageSize
	
END
";
            return retValue;
        }
    }
}
