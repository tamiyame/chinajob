using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardCategoryEntity : DataEntity
    {
        public int BoardNo { get { return Convert.ToInt32(GetData("BoardNo", (int)0)); } }
        public int BoardCategoryNo { get { return Convert.ToInt32(GetData("BoardCategoryNo", (int)0)); } }
        public string CategoryName { get { return Convert.ToString(GetData("CategoryName", string.Empty)); } }
        public string CategoryCNName { get { return Convert.ToString(GetData("CategoryCNName", string.Empty)); } }
        public string CategoryENGName { get { return Convert.ToString(GetData("CategoryENGName", string.Empty)); } }
        public int MaxBoardSubCategoryNo { get { return Convert.ToInt32(GetData("MaxBoardSubCategoryNo", (int)0)); } }
        public int ArticleCreate { get { return Convert.ToInt32(GetData("ArticleCreate", (int)0)); } }
        public int ArticleRemove { get { return Convert.ToInt32(GetData("ArticleRemove", (int)0)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}