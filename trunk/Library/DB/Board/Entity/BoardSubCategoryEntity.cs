using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Board
{
    public class BoardSubCategoryEntity : DataEntity
    {
        public int BoardNo { get { return Convert.ToInt32(GetData("BoardNo", (int)0)); } }
        public int BoardCategoryNo { get { return Convert.ToInt32(GetData("BoardCategoryNo", (int)0)); } }
        public int BoardSubCategoryNo { get { return Convert.ToInt32(GetData("BoardSubCategoryNo", (int)0)); } }
        public string SubCategoryName { get { return Convert.ToString(GetData("SubCategoryName", string.Empty)); } }
        public int ArticleCreate { get { return Convert.ToInt32(GetData("ArticleCreate", (int)0)); } }
        public int ArticleRemove { get { return Convert.ToInt32(GetData("ArticleRemove", (int)0)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}