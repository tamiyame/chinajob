using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Com.Framework.Data;
using Com.Library.Page;
using Com.Library.DB.Board;

namespace Site.Web.Page
{
    public class ArticleListPage : SitePage
    {
        private ListData<ArticleEntity, OutputEntity> m_ArticleList = null;
        public ListData<ArticleEntity, OutputEntity> ArticleList
        {
            get { return m_ArticleList; }
        }

        private List<BoardCategoryEntity> m_BoardCategory = null;
        public string GetCategoryName(int BoardCategoryNo)
        {
            if (m_BoardCategory == null)
            {
                BoardCategoryGetListArguments arg = new BoardCategoryGetListArguments();
                arg.BoardNo = BoardNo;
                arg.Status = 1;
                BoardCategoryGetList list = new BoardCategoryGetList();
                list.SetArguments(arg); 
                list.Execute();
                m_BoardCategory = list.GetRecords();
            }

            foreach (BoardCategoryEntity item in m_BoardCategory)
            {
                if (item.BoardCategoryNo == BoardCategoryNo)
                {
                    return item.CategoryName;
                }
            }
            return string.Empty;
        }

        public virtual int BoardNo
        {
            get { return 0; }
        }

        public virtual int UserNo_Search
        {
            get { return 0; }
        }

        private int m_PageNo = 1;
        public virtual int PageNo
        {
            get { return m_PageNo; }
        }

        public virtual byte PageSize
        {
            get { return 10; }
        }

        private byte m_SearchType;
        private byte SearchType
        {
            get { return m_SearchType; }
            set { this.m_SearchType = value; }
        }

        private string m_SearchValue = string.Empty;
        private string SearchValue
        {
            get { return m_SearchValue; }
            set { this.m_SearchValue = value; }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            m_PageNo = Request.QueryString["PageNo"] == null ? m_PageNo: Convert.ToInt32(Request.QueryString["PageNo"]);
            m_SearchType = Request.QueryString["SearchType"] == null ? (byte)0: Convert.ToByte(Request.QueryString["SearchType"]);
            m_SearchValue = Request.QueryString["SearchValue"] == null ? string.Empty : Convert.ToString(Request.QueryString["SearchValue"]);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            ArticleGetListArguments arg = new ArticleGetListArguments();
            arg.PageNo = PageNo;
            arg.PageSize = PageSize;
            arg.BoardNo = BoardNo;
            if (SearchType == 1)
            {
                arg.ArticleTitle_Search = SearchValue;
            }
            if (SearchType == 2)
            {
            }
            if (UserNo_Search != 0)
            {
                arg.UserNo_Search = UserNo_Search;
            }
            ArticleGetList list = new ArticleGetList();
            list.SetArguments(arg);
            List<ArticleEntity> record = list.Execute();
            OutputEntity outputdata = list.GetOutput();

            m_ArticleList = new ListData<ArticleEntity, OutputEntity>(record, outputdata);
        }

        public string PageMove(string pageName, int pageNo)
        {
            string url = string.Empty;
            url = "?PageNo=" + pageNo.ToString();
            if (this.SearchType != 0)
            {
                url += "&SearchType=" + SearchType.ToString() + "&SearchValue=" + Server.UrlEncode(SearchValue);
            }
            return pageName += url;
        }

        public string PageMove(string pageName)
        {
            string url = string.Empty;
            url = "?PageNo=" + this.PageNo.ToString();
            if (this.SearchType != 0)
            {
                url += "&SearchType=" + SearchType.ToString() + "&SearchValue=" + Server.UrlEncode(SearchValue);
            }
            return pageName += url;
        }


        public string PageMove(string pageName, int pageNo, int boardNo)
        {
            string url = string.Empty;
            url = "?PageNo=" + pageNo.ToString() + "&BoardNo=" + boardNo;
            if (this.SearchType != 0)
            {
                url += "&SearchType=" + SearchType.ToString() + "&SearchValue=" + Server.UrlEncode(SearchValue);
            }
            return pageName += url;
        }

        public string PageMoveWithBoardNo(string pageName, int boardNo)
        {
            string url = string.Empty;
            url = "?PageNo=" + this.PageNo.ToString() + "&BoardNo=" + boardNo;
            if (this.SearchType != 0)
            {
                url += "&SearchType=" + SearchType.ToString() + "&SearchValue=" + Server.UrlEncode(SearchValue);
            }
            return pageName += url;
        }
    }
}