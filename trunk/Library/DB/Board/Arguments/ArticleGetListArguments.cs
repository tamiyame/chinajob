using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleGetListArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public byte Status
        {
            get { return Convert.ToByte(GetValue("Status", (byte)0)); }
            set { SetValue("Status", value); }
        }

        public int BoardCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BoardCategoryNo", 0)); }
            set { SetValue("BoardCategoryNo", value); }
        }

        public int BoardSubCategoryNo
        {
            get { return Convert.ToInt32(GetValue("BoardSubCategoryNo", 0)); }
            set { SetValue("BoardSubCategoryNo", value); }
        }

        public string UserName_Search
        {
            get { return Convert.ToString(GetValue("UserName_Search", string.Empty)); }
            set { SetValue("UserName_Search", value); }
        }

        public string ArticleTitle_Search
        {
            get { return Convert.ToString(GetValue("ArticleTitle_Search", string.Empty)); }
            set { SetValue("ArticleTitle_Search", value); }
        }

        public int UserNo_Search
        {
            get { return Convert.ToInt32(GetValue("UserNo_Search", 0)); }
            set { SetValue("UserNo_Search", value); }
        }

        public int PageNo
        {
            get { return Convert.ToInt32(GetValue("PageNo", 0)); }
            set { SetValue("PageNo", value); }
        }

        public byte PageSize
        {
            get { return Convert.ToByte(GetValue("PageSize", (byte)0)); }
            set { SetValue("PageSize", value); }
        }
    }
}