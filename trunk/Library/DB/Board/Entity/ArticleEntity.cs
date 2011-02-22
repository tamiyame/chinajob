using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class ArticleEntity : DataEntity
    {
        public int BoardNo { get { return Convert.ToInt32(GetData("BoardNo", (int)0)); } }
        public int ArticleNo { get { return Convert.ToInt32(GetData("ArticleNo", (int)0)); } }
        public int ArticleNo_parent { get { return Convert.ToInt32(GetData("ArticleNo_parent", (int)0)); } }
        public int ArticleGroupNo { get { return Convert.ToInt32(GetData("ArticleGroupNo", (int)0)); } }
        public short OrderNo { get { return Convert.ToInt16(GetData("OrderNo", (short)0)); } }
        public byte LevelNo { get { return Convert.ToByte(GetData("LevelNo", (byte)0)); } }
        public int BoardCategoryNo { get { return Convert.ToInt32(GetData("BoardCategoryNo", (int)0)); } }
        public int BoardSubCategoryNo { get { return Convert.ToInt32(GetData("BoardSubCategoryNo", (int)0)); } }
        public int UserNo { get { return Convert.ToInt32(GetData("UserNo", (int)0)); } }
        public string UserID { get { return Convert.ToString(GetData("UserID", string.Empty)); } }
        public string UserName { get { return Convert.ToString(GetData("UserName", string.Empty)); } }
        public string UserIP { get { return Convert.ToString(GetData("UserIP", string.Empty)); } }
        public string ArticleTitle { get { return Convert.ToString(GetData("ArticleTitle", string.Empty)); } }
        public string SomeContent { get { return Convert.ToString(GetData("SomeContent", string.Empty)); } }
        public string ArticleContent { get { return Convert.ToString(GetData("ArticleContent", string.Empty)); } }
        public int ReadCount { get { return Convert.ToInt32(GetData("ReadCount", (int)0)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public int CommentCreate { get { return Convert.ToInt32(GetData("CommentCreate", (int)0)); } }
        public int CommentRemove { get { return Convert.ToInt32(GetData("CommentRemove", (int)0)); } }
        public int MaxCommentNo { get { return Convert.ToInt32(GetData("MaxCommentNo", (int)0)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}