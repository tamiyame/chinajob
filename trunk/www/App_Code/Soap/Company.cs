using System;
using System.Collections;
using System.Collections.Generic;

using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

using Com.Framework.Data;
using Com.Library.DB.Company;
namespace Site.Web.Soap
{
    /// <summary>
    /// Company의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class Company : System.Web.Services.WebService
    {

        public Company()
        {

            //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
            //InitializeComponent(); 
        }

        [WebMethod]
        public CompanyEntity IsCompanyID(string companyID)
        {
            CompanyEntity entity = null;
            CompanyGetInfo info = new CompanyGetInfo();
            CompanyGetInfoArguments arg = new CompanyGetInfoArguments();
            arg.CompanyID = companyID;
            info.SetArguments(arg);
            info.ExecuteNonQuery();
            entity = info.GetOutput();
            return entity;
        }

        [WebMethod]
        public CompanyDetailEntity IsPermitNo(string permitNo)
        {
            CompanyDetailGetInfo info = new CompanyDetailGetInfo();
            CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
            arg.PermitNo = permitNo;
            info.SetArguments(arg);
            info.ExecuteNonQuery();
            CompanyDetailEntity entity = info.GetOutput();
            return entity;
        }

        [WebMethod]
        public CompanyDetailEntity IsEmail(string email)
        {
            CompanyDetailGetInfo info = new CompanyDetailGetInfo();
            CompanyDetailGetInfoArguments arg = new CompanyDetailGetInfoArguments();
            arg.Email = email;
            info.SetArguments(arg);
            info.ExecuteNonQuery();
            CompanyDetailEntity entity = info.GetOutput();
            return entity;
        }

        [WebMethod]
        public ListData<CompanyAllEntity, OutputEntity> CompanyList(int countryNo, int pageNo, byte pageSize)
        {
            CompanyGetListArguments arg = new CompanyGetListArguments();
            if (countryNo != 0)
            {
                arg.CountryNo = countryNo;
            }
            arg.PageNo = pageNo;
            arg.PageSize = pageSize;
            CompanyGetList list = new CompanyGetList();
            list.SetArguments(arg);
            list.Execute();
            List<CompanyAllEntity> _record = list.GetRecords();
            OutputEntity _output = list.GetOutput();

            ListData<CompanyAllEntity, OutputEntity> listData = new ListData<CompanyAllEntity, OutputEntity>(_record, _output);

            return listData;
        }
    }
}