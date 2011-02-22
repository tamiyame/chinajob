using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Menu
{
    public class SubMenuEntity : DataEntity
    {
        public short TopMenuNo { get { return Convert.ToInt16(GetData("TopMenuNo", (short)0)); } }
        public short SubMenuNo { get { return Convert.ToInt16(GetData("SubMenuNo", (short)0)); } }
        public short OrderNo { get { return Convert.ToInt16(GetData("OrderNo", (short)0)); } }
        public string SubMenuName { get { return Convert.ToString(GetData("SubMenuName", string.Empty)); } }
        public string SubImageUrl { get { return Convert.ToString(GetData("SubImageUrl", string.Empty)); } }
        public string CenterContent { get { return Convert.ToString(GetData("CenterContent", string.Empty)); } }
        public byte Status { get { return Convert.ToByte(GetData("Status", (byte)0)); } }
    }
}