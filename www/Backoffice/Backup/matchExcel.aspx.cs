using System;
using System.Collections;
using System.Collections.Generic;
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

using Com.Framework.Data;
using Com.Library.DB.User;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using Com.Library.DB.Participate;

public partial class Backoffice_Backup_matchExcel : System.Web.UI.Page
{
    public List<RecruitEntity> RecruitList = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Server.ScriptTimeout = 60 * 10;
        Response.AddHeader("content-disposition", "attachment;filename=recruit.xls");
        Response.ContentType = "application/vnd.ms-excel";
        RecruitGetListArguments recruitArg = new RecruitGetListArguments();
        recruitArg.PageNo = 1;
        recruitArg.PageSize = 0;
        RecruitGetList recruit = new RecruitGetList();
        recruit.SetArguments(recruitArg);
        recruit.Execute();
        RecruitList = recruit.GetRecords();
    }

    public CompanyDetailEntity GetDetailCompany(int companyNo)
    {
        CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
        arg.CompanyNo = companyNo;
        CompanyDetailGetInfo info = new CompanyDetailGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        return info.GetOutput();
    }

    public CompanyEntity GetCompany(int companyNo)
    {
        CompanyGetInfoArguments arg = new CompanyGetInfoArguments();
        arg.CompanyNo = companyNo;
        CompanyGetInfo info = new CompanyGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        return info.GetOutput();
    }

    public List<ParticipateEntity> ParticipateList(int companyNo, int recruitNo)
    {
        ParticipateGetListArguments arg = new ParticipateGetListArguments();
        arg.CompanyNo = companyNo;
        arg.RecruitNo = recruitNo;
        arg.PageNo = 1;
        arg.PageSize = 0;
        ParticipateGetList list = new ParticipateGetList();
        list.SetArguments(arg);
        list.Execute();
        List<ParticipateEntity> _record = list.GetRecords();
        OutputEntity _output = list.GetOutput();
        return _record;
    }

    public UserEntity UserInfo(int userNo)
    {
        UserGetInfoArguments arg = new UserGetInfoArguments();
        arg.UserNo = userNo;
        UserGetInfo info = new UserGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        return info.GetOutput();
    }

    public ResumeEntity ResumeInfo(int userNo)
    {
        ResumeGetInfoArguments arg = new ResumeGetInfoArguments();
        arg.UserNo = userNo;
        ResumeGetInfo info = new ResumeGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();
        return info.GetOutput();
    }

    public string GetCategoryName(int CategoryNo)
    {
        CategoryGetInfoArguments arg = new CategoryGetInfoArguments();
        arg.CategoryNo = CategoryNo;
        CategoryGetInfo info = new CategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().CategoryKRName;
    }

    public string GetSubCategoryName(int SubCategoryNo)
    {
        SubCategoryGetInfoArguments arg = new SubCategoryGetInfoArguments();
        arg.SubCategoryNo = SubCategoryNo;
        SubCategoryGetInfo info = new SubCategoryGetInfo();
        info.SetArguments(arg);
        info.ExecuteNonQuery();

        return info.GetOutput().SubCategoryKRName == string.Empty ? "" : "<br/>" + info.GetOutput().SubCategoryKRName;
    }
}
