using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleCreateArguments : DBArguments
    {
        public int BoardNo
        {
            get { return Convert.ToInt32(GetValue("BoardNo", 0)); }
            set { SetValue("BoardNo", value); }
        }

        public int ArticleNo_parent
        {
            get { return Convert.ToInt32(GetValue("ArticleNo_parent", 0)); }
            set { SetValue("ArticleNo_parent", value); }
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

        public int UserNo
        {
            get { return Convert.ToInt32(GetValue("UserNo", 0)); }
            set { SetValue("UserNo", value); }
        }

        public string UserID
        {
            get { return Convert.ToString(GetValue("UserID", string.Empty)); }
            set { SetValue("UserID", value); }
        }

        public string UserName
        {
            get { return Convert.ToString(GetValue("UserName", string.Empty)); }
            set { SetValue("UserName", value); }
        }

        public string UserCNName
        {
            get { return Convert.ToString(GetValue("UserCNName", string.Empty)); }
            set { SetValue("UserCNName", value); }
        }

        public string UserENGName
        {
            get { return Convert.ToString(GetValue("UserENGName", string.Empty)); }
            set { SetValue("UserENGName", value); }
        }

        public string UserIP
        {
            get { return Convert.ToString(GetValue("UserIP", string.Empty)); }
            set { SetValue("UserIP", value); }
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
    }
}