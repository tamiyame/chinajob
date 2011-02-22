using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Framework.Data;

namespace Com.Library.DB.Menu
{
    public class SubMenuModifyArguments : DBArguments
    {

        public short TopMenuNo
        {
            get { return Convert.ToInt16(GetValue("TopMenuNo", (short)0)); }
            set { SetValue("TopMenuNo", value); }
        }

        public short SubMenuNo
        {
            get { return Convert.ToInt16(GetValue("SubMenuNo", (short)0)); }
            set { SetValue("SubMenuNo", value); }
        }

        public short OrderNo
        {
            get { return Convert.ToInt16(GetValue("OrderNo", (short)0)); }
            set { SetValue("OrderNo", value); }
        }

        public string SubMenuName
        {
            get { return Convert.ToString(GetValue("SubMenuName", string.Empty)); }
            set { SetValue("SubMenuName", value); }
        }

        public string SubImageUrl
        {
            get { return Convert.ToString(GetValue("SubImageUrl", string.Empty)); }
            set { SetValue("SubImageUrl", value); }
        }

        public string CenterContent
        {
            get { return Convert.ToString(GetValue("CenterContent", string.Empty)); }
            set { SetValue("CenterContent", value); }
        }

        public byte Status
        {
            get { return Convert.ToByte(GetValue("Status", (byte)0)); }
            set { SetValue("Status", value); }
        }
    }
}