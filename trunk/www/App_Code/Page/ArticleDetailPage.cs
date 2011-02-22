using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
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
    public class ArticleDetailPage : SitePage
    {

        private ArticleEntity m_AricleInfo = null;
        public ArticleEntity ArticleInfo
        {
            get { return m_AricleInfo; }
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

        private int m_PageNo = 1;
        public virtual int PageNo
        {
            get { return m_PageNo; }
        }

        private int m_ArticleNo = 1;
        public virtual int ArticleNo
        {
            get { return m_ArticleNo; }
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
            m_PageNo = Request.QueryString["PageNo"] == null ? m_PageNo : Convert.ToInt32(Request.QueryString["PageNo"]);
            m_ArticleNo = Request.QueryString["ArticleNo"] == null ? m_PageNo : Convert.ToInt32(Request.QueryString["ArticleNo"]);
            m_SearchType = Request.QueryString["SearchType"] == null ? (byte)0 : Convert.ToByte(Request.QueryString["SearchType"]);
            m_SearchValue = Request.QueryString["SearchValue"] == null ? string.Empty : Convert.ToString(Request.QueryString["SearchValue"]);
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            ArticleGetInfoArguments arg = new ArticleGetInfoArguments();
            arg.BoardNo = BoardNo;
            arg.ArticleNo = ArticleNo;
            arg._AddReadCount = 1;
            ArticleGetInfo info = new ArticleGetInfo();
            info.SetArguments(arg);
            info.Execute();
            m_AricleInfo = info.GetOutput();
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