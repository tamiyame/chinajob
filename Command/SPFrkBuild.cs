using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotbookCommand
{
    public class SPFrkBuild
    {
        private string m_SPName = string.Empty;
        private ListView.ListViewItemCollection m_ListViewItemCollection; 
        public SPFrkBuild(string spName, ListView.ListViewItemCollection lvCollection )
        {
            m_SPName = spName;
            m_ListViewItemCollection = lvCollection;
        }

        private string Header()
        {
            string header = string.Empty;
            header = @"set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/* *******************************************************************
** DATE :
** Writer :
** Memo :
******************************************************************** */
CREATE PROCEDURE [dbo].[" + m_SPName + @"]
(
	@IsTransaction	tinyint			= 0
,	@ErrorCode		int				= 0		OUTPUT
,	@ErrorMessage	nvarchar( 1000 )= ''	OUTPUT
";

            foreach (ListViewItem item in m_ListViewItemCollection)
            {
                header += "\r\n" + GetParamGen( item );
            }

            header += @"
)
as
Set NOCOUNT ON

-- Frk Default Value
DECLARE @FrkDateNow DateTime
DECLARE @FrkRowCount int
DECLARE @FrkTranCount int
DECLARE @FrkErrorCode int
DECLARE @FrkErrorMessage nvarchar( 1000 )
Set @FrkDateNow = GetDate()
set @FrkTranCount = @@TRANCOUNT
-- Frk Check


If ( @IsTransaction = 0 )
Begin
	If ( @FrkTranCount < 1 )
	Begin
		Set @FrkErrorCode = -1
		Set @FrkErrorMessage = 'Transaction.'
		goto ERROR
	End
	Else If ( @FrkTranCount > 1 )
	Begin
		Set @FrkErrorCode = -2
		Set @FrkErrorMessage = 'Transaction.'
		goto ERROR
	End
End
Else
Begin
	If ( @FrkTranCount <> 0 )
	Begin
		Set @FrkErrorCode = -3
		Set @FrkErrorMessage = 'Transaction.'
		goto ERROR
	End
	Begin Tran
End

-- Implementation
";
            return header;
        }

        private string Bottom()
        {
            string bottom = string.Empty;
            bottom = @"


-- Frk Error Check
SELECT
	@FrkErrorCode = @@ERROR
,	@FrkRowCount = @@RowCount

-- End

COMPLETE:
	If ( @IsTransaction <> 0 )
	Begin
		If ( @@TRANCOUNT = 1 )
		Begin
			Commit Tran
		End
	End
	SET @ErrorCode = 0
	SET @ErrorMessage = ''
	return 0
ERROR:
	If ( @IsTransaction <> 0 )
	Begin
		If ( @@TRANCOUNT = 1 )
		Begin
			Rollback Tran
		End
	End
	SET @ErrorCode = @FrkErrorCode
	SET @ErrorMessage = @FrkErrorMessage
	return @FrkErrorCode
";
            return bottom;
        }

        public string GetSP()
        {
            return Header() + Bottom();
        }

        public string GetQuerySP(string query)
        {
            return Header() + query + Bottom();
        }

        private string GetParamGen(ListViewItem lv)
        {
            string retValue = ",\t";
            retValue += "@" + lv.Text + "\t";
            if (lv.SubItems[1].Text.ToLower() == "varchar" || lv.SubItems[1].Text.ToLower() == "nvarchar")
            {
                retValue += lv.SubItems[1].Text + "(" + lv.SubItems[2].Text + ")\t";
            }
            else
            {
                retValue += lv.SubItems[1].Text + "\t";
            }

            if (lv.SubItems[3].Text != string.Empty)
            {
                if (lv.SubItems[3].Text.ToLower().Trim() == "null")
                {
                    retValue += "= NULL\t";
                }
                else
                {
                    if (lv.SubItems[1].Text.ToLower() == "int" || lv.SubItems[1].Text.ToLower() == "smallint" ||
                        lv.SubItems[1].Text.ToLower() == "bigint" || lv.SubItems[1].Text.ToLower() == "tinyint" ||
                        lv.SubItems[1].Text.ToLower() == "float")
                    {
                        retValue += "= " + lv.SubItems[3].Text + "\t";
                    }
                    else
                    {
                        retValue += "= '" + lv.SubItems[3].Text + "'\t";
                    }
                }
            }
            else
            {
                if (lv.SubItems[4].Text.ToLower() == "output" || lv.SubItems[4].Text.ToLower() == "input/output")
                {
                    retValue += "= NULL\t";
                }
            }

            if (lv.SubItems[4].Text.ToLower() == "output")
            {
                retValue += "OUTPUT";
            }
            else if (lv.SubItems[4].Text.ToLower() == "input/output")
            {
                retValue += "OUTPUT--IN";
            }

            return retValue;
        }
    }
}
