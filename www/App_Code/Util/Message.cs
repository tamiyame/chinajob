using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Site.Web.Util
{
    public enum k_MsgType : int
    {
        Write_Confirm = 0,
        Modify_Confirm = 1,
        Company_User = 2,
        Apply_Company = 3,
        User_Login = 4,
        User = 5,
        Apply_User = 6,
        CompanyJoinType = 7,
        UserJoinType = 8,
        RecruitType = 9,
        ParticipateType = 10,
        UserViewType = 11,
    }

    public class Message
    {
        private static string[,] m_Msg = {
            {"등록되었습니다.", "已登记", "등록되었습니다."},
            {"수정되었습니다.", "已编辑", "수정되었습니다."},
            {"기업회원만 접근할 수 있습니다.", "只有企业会员能进入", "기업회원만 접근할 수 있습니다."},
            {"승인된 기업만 접근할 수 있습니다.", "只有已批准企业能进入", "승인된 기업만 접근할 수 있습니다."},
            {"로그인하셔야 이용가능합니다.", "只有登录才能使用  ", "로그인하셔야 이용가능합니다."},
            {"회원만 접근할 수 있습니다.", "只有会员能够进入", "회원만 접근할 수 있습니다."},
            {"승인된 회원만 접근할 수 있습니다.", "只有已批准会员能进入", "승인된 회원만 접근할 수 있습니다."},
            {"채용등록 기간이 아닙니다.", "招聘注册关闭", "채용등록 기간이 아닙니다."},
            {"인제등록 기간이 아닙니다.", "人才注册关闭", "인제등록 기간이 아닙니다."},
            {"채용지원 가간이 아닙니다.", "录用报名关闭", "채용지원 가간이 아닙니다."},
            {"면접요청 가간이 아닙니다.", "面试请求关闭", "면접요청 가간이 아닙니다."},
            {"인재정보 노출기간이 아닙니다.", "인재정보 노출기간이 아닙니다.", "인재정보 노출기간이 아닙니다."}

            
        };
        public static string Msg(int CountryNo, k_MsgType msgType)
        {
            return m_Msg[(int)msgType, CountryNo - 1];
        }

        public static string strCut(string value, int len)
        {
            if (value.Length > len)
            {
                return value.Substring(0, len) + "...";
            }

            return value;
        }
    }
}