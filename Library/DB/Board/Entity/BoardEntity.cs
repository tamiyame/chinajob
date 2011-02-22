using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardEntity : DataEntity
    {
        public int BoardNo { get { return Convert.ToInt32(GetData("BoardNo", (int)0)); } }
        public string BoardName { get { return Convert.ToString(GetData("BoardName", string.Empty)); } }
        public DateTime DateCreated { get { return Convert.ToDateTime(GetData("DateCreated", DateTime.MinValue)); } }
        public byte PageSize { get { return Convert.ToByte(GetData("PageSize", (byte)0)); } }
        public int ArticleCreate { get { return Convert.ToInt32(GetData("ArticleCreate", (int)0)); } }
        public int ArticleRemove { get { return Convert.ToInt32(GetData("ArticleRemove", (int)0)); } }
        public int MaxArticleNo { get { return Convert.ToInt32(GetData("MaxArticleNo", (int)0)); } }
        public int MaxArticleGroupNo { get { return Convert.ToInt32(GetData("MaxArticleGroupNo", (int)0)); } }
        public int MaxBoardCategoryNo { get { return Convert.ToInt32(GetData("MaxBoardCategoryNo", (int)0)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}