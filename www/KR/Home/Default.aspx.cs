using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using Com.Framework.Data;
using Com.Library.DB.Board;
using Com.Library.DB.Banner;
using Com.Library.DB.Schedule;
using Com.Library.DB.Company;
using Com.Library.DB.Category;
using Com.Library.DB.User;

using Site.Web.Page;

public partial class KR_Home_Default : SitePage
{
    private ListData<ArticleEntity, OutputEntity> m_ArticleList = null;
    public ListData<ArticleEntity, OutputEntity> ArticleList
    {
        get { return m_ArticleList; }
    }

    public ListData<BannerEntity, OutputEntity> BannerList_Human;
    public ListData<BannerEntity, OutputEntity> BannerList_Company;
    public PageSettingEntity PageEntity = null;
    public ListData<RecruitSearchEntity, OutputEntity> RecruitSearchList = null;
    public ListData<ResumeSearchEntity, OutputEntity> UserSearchList = null;

    public ResumeEntity resumeEntity;
    public ResumeDetailEntity detailEntity_cn;
    public ResumeDetailEntity detailEntity_kr;
    public ResumeDetailEntity detailEntity_eng;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.WebCookies.IsLogin && !this.WebCookies.isCompany)
        {
            ResumeGetInfoArguments infoArg = new ResumeGetInfoArguments();
            infoArg.UserNo = this.WebCookies.UserNo;
            ResumeGetInfo info_resume = new ResumeGetInfo();
            info_resume.SetArguments(infoArg);
            info_resume.ExecuteNonQuery();
            resumeEntity = info_resume.GetOutput();

            ResumeDetailGetInfoArguments detailArg_kr = new ResumeDetailGetInfoArguments();
            detailArg_kr.CountryNo = 1;
            detailArg_kr.UserNo = this.WebCookies.UserNo;
            ResumeDetailGetInfo detail_kr = new ResumeDetailGetInfo();
            detail_kr.SetArguments(detailArg_kr);
            detail_kr.ExecuteNonQuery();
            detailEntity_kr = detail_kr.GetOutput();
            ResumeDetailGetInfoArguments detailArg_cn = new ResumeDetailGetInfoArguments();
            detailArg_cn.CountryNo = 2;
            detailArg_cn.UserNo = this.WebCookies.UserNo;
            ResumeDetailGetInfo detail_cn = new ResumeDetailGetInfo();
            detail_cn.SetArguments(detailArg_cn);
            detail_cn.ExecuteNonQuery();
            detailEntity_cn = detail_cn.GetOutput();

            ResumeDetailGetInfoArguments detailArg_eng = new ResumeDetailGetInfoArguments();
            detailArg_eng.CountryNo = 3;
            detailArg_eng.UserNo = this.WebCookies.UserNo;
            ResumeDetailGetInfo detail_eng = new ResumeDetailGetInfo();
            detail_eng.SetArguments(detailArg_eng);
            detail_eng.ExecuteNonQuery();
            detailEntity_eng = detail_eng.GetOutput();
        }

        {
            RecruitSearchArguments searchArg = new RecruitSearchArguments();
            searchArg.CountryNo = this.WebMaster.CountryCode;
            searchArg.PageNo = 1;
            searchArg.PageSize = 32;
            RecruitSearch search = new RecruitSearch();
            search.SetArguments(searchArg);
            search.Execute();
            List<RecruitSearchEntity> record = search.Execute();
            OutputEntity outputdata = search.GetOutput();
            RecruitSearchList = new ListData<RecruitSearchEntity, OutputEntity>(record, outputdata);
        }
        {
            ResumeSearchArguments searchArg = new ResumeSearchArguments();
            searchArg.CountryNo = this.WebMaster.CountryCode;
            searchArg.PageNo = 1;
            searchArg.PageSize = 32;

            ResumeSearch search = new ResumeSearch();
            search.SetArguments(searchArg);
            search.Execute();
            List<ResumeSearchEntity> record = search.Execute();
            OutputEntity outputdata = search.GetOutput();

            UserSearchList = new ListData<ResumeSearchEntity, OutputEntity>(record, outputdata);
        }

        {
            PageSettingGetInfo info = new PageSettingGetInfo();
            info.ExecuteNonQuery();
            PageEntity = info.GetOutput();
        }
        {
            ArticleGetListArguments arg = new ArticleGetListArguments();
            arg.PageNo = 1;
            arg.PageSize = 4;
            arg.BoardNo = 2;
            ArticleGetList list = new ArticleGetList();
            list.SetArguments(arg);
            List<ArticleEntity> record = list.Execute();
            OutputEntity outputdata = list.GetOutput();

            m_ArticleList = new ListData<ArticleEntity, OutputEntity>(record, outputdata);
        }
        {
            BannerGetList list = new BannerGetList();
            list.SetArguments(
                new BannerGetListArguments()
                {
                    BannerType = 1, //채용
                    CountryNo = this.WebMaster.CountryCode,
                    IsOperation = 1
                }
            );
            List<BannerEntity> record = list.Execute();
            OutputEntity outputdata = list.GetOutput();
            BannerList_Company = new ListData<BannerEntity, OutputEntity>(record, outputdata);
        }
        {
            BannerGetList list = new BannerGetList();
            list.SetArguments(
                new BannerGetListArguments()
                {
                    BannerType = 2, //인재
                    CountryNo = this.WebMaster.CountryCode,
                    IsOperation = 1
                }
            );
            List<BannerEntity> record = list.Execute();
            OutputEntity outputdata = list.GetOutput();
            BannerList_Human = new ListData<BannerEntity, OutputEntity>(record, outputdata);
        }
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
}
