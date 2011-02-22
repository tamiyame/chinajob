using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleCommentCreateArguments : DBArguments
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

        public string CommentContent
        {
            get { return Convert.ToString(GetValue("CommentContent", string.Empty)); }
            set { SetValue("CommentContent", value); }
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

        public string UserIP
        {
            get { return Convert.ToString(GetValue("UserIP", string.Empty)); }
            set { SetValue("UserIP", value); }
        }
    }
}