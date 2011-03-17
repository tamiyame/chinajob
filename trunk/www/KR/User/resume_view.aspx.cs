using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Com.Library.DB.User;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using Com.Framework.Data;

public partial class KR_User_resume_view : System.Web.UI.Page
{
    public ResumeEntity resumeEntity = null;
    public UserEntity UserInfo = null;
    public ResumeDetailEntity resumeDetail_KR = null;
    public ResumeDetailEntity resumeDetail_CN = null;
    public ResumeDetailEntity resumeDetail_ENG = null;
    public int UserNo { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        UserNo = Request.QueryString["UserNo"] == null ? 0 : Convert.ToInt32(Request.QueryString["UserNo"]);
        if (UserNo == 0)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('유저 정보가 정확하시 않습니다.'); self.close();</script>");
            Response.End();
        }

        ResumeGetInfoArguments resumeGetInfoArguments = new ResumeGetInfoArguments();
        resumeGetInfoArguments.UserNo = UserNo;

        ResumeGetInfo resumeGetInfo = new ResumeGetInfo();
        resumeGetInfo.SetArguments(resumeGetInfoArguments);
        resumeGetInfo.ExecuteNonQuery();
        resumeEntity = resumeGetInfo.GetOutput();

        if (resumeEntity.RegistryTime == DateTime.MinValue)
        {
            resumeEntity = null;
        }

        if (resumeEntity == null)
        {
            Response.Clear();
            Response.Write("<script language='javascript'>alert('유저 정보가 정확하시 않습니다.'); self.close();</script>");
            Response.End();
        }


        resumeDetail_KR = DetailInfo(UserNo, 1);
        resumeDetail_CN = DetailInfo(UserNo, 2);
        resumeDetail_ENG = DetailInfo(UserNo, 3);

        UserGetInfoArguments userArg = new UserGetInfoArguments();
        userArg.UserNo = UserNo;
        UserGetInfo userInfo = new UserGetInfo();
        userInfo.SetArguments(userArg);
        userInfo.ExecuteNonQuery();
        UserInfo = userInfo.GetOutput();
    }

    private ResumeDetailEntity DetailInfo(int userNo, int CountryNo)
    {
        ResumeDetailGetInfoArguments detailArg = new ResumeDetailGetInfoArguments();
        detailArg.UserNo = UserNo;
        detailArg.CountryNo = CountryNo;
        ResumeDetailGetInfo detailInfo = new ResumeDetailGetInfo();
        detailInfo.SetArguments(detailArg);
        detailInfo.ExecuteNonQuery();
        return detailInfo.GetOutput();
    }

    public string GetMilitaryInfo(byte type)
    {
        string retValue = "무관";
        switch (type)
        {
            case 1: retValue = "필"; break;
            case 2: retValue = "미필"; break;
            case 3: retValue = "면제"; break;
            case 4: retValue = "무관"; break;
        }
        return retValue;
    }

    public string GetCompanyName(int CountryNo, int CompanyNo)
    {
        CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
        arg.CompanyNo = CompanyNo;
        CompanyDetailGetInfo info = new CompanyDetailGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        if (CountryNo == 1)
        {
            return info.GetOutput().KRName;
        }
        else if (CountryNo == 2)
        {
            return info.GetOutput().CNName;
        }
        else
        {
            return info.GetOutput().ENGName;
        }
    }

    public string GetCategoryName(int CountryNo, int CategoryNo)
    {
        CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
        arg.CategoryNo = CategoryNo;
        CategoryGetInfo info = new CategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        if (CountryNo == 1)
        {
            return info.GetOutput().CategoryKRName;
        }
        else if (CountryNo == 2)
        {
            return info.GetOutput().CategoryCNName;
        }
        else
        {
            return info.GetOutput().CategoryENGName;
        }
    }

    public string GetSubCategoryName(int CountryNo, int SubCategoryNo)
    {
        SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
        arg.SubCategoryNo = SubCategoryNo;
        SubCategoryGetInfo info = new SubCategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        if (CountryNo == 1)
        {
            return info.GetOutput().SubCategoryKRName;
        }
        else if (CountryNo == 2)
        {
            return info.GetOutput().SubCategoryCNName;
        }
        else
        {
            return info.GetOutput().SubCategoryENGName;
        }
    }
}
