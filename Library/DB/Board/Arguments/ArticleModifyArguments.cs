using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleModifyArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public int ArticleNo
        {
            get { return Convert.ToInt32(GetValue("ArticleNo", 0)); }
            set { SetValue("ArticleNo", value); }
        }

        public string ArticleTitle
        {
            get { return Convert.ToString(GetValue("ArticleTitle", string.Empty)); }
            set { SetValue("ArticleTitle", value); }
        }

        public string SomeContent
        {
            get { return Convert.ToString(GetValue("SomeContent", string.Empty)); }
            set { SetValue("SomeContent", value); }
        }

        public string ArticleContent
        {
            get { return Convert.ToString(GetValue("ArticleContent", string.Empty)); }
            set { SetValue("ArticleContent", value); }
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
    }
}