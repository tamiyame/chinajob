using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleCommentEntity : DataEntity
    {
        public int BoardNo { get { return Convert.ToInt32(GetData("BoardNo", (int)0)); } }
        public int ArticleNo { get { return Convert.ToInt32(GetData("ArticleNo", (int)0)); } }
        public int CommentNo { get { return Convert.ToInt32(GetData("CommentNo", (int)0)); } }
        public string CommentContent { get { return Convert.ToString(GetData("CommentContent", string.Empty)); } }
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public string UserID { get { return Convert.ToString(GetData("UserID", string.Empty)); } }
        public string UserName { get { return Convert.ToString(GetData("UserName", string.Empty)); } }
        public string UserIP { get { return Convert.ToString(GetData("UserIP", string.Empty)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}