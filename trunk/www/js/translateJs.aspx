<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/EmptyMaster.master" AutoEventWireup="true" CodeFile="translateJs.aspx.cs" Inherits="js_translateJs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

(function($)
{
	$.translateHelper = {};
	$.translateHelper.countryCode_kr = 1;
	$.translateHelper.countryCode_cn = 2;
	$.translateHelper.countryCode_en = 3;
	
	$.translateHelper.countryCode = <%= this.WebMaster.CountryCode %>;
	$.translateHelper.translateData = new Array();
<asp:Repeater ID="rptTranslateData" runat="server">
<ItemTemplate>
	$.translateHelper.translateData.push({"transCode":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).TransCode%>","krText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).KrText%>","cnText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).CnText%>","enText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).EnText%>"});
</ItemTemplate>
</asp:Repeater>
	$.translateHelper.getTextCore = function(countryCode, transCode) {
		var entity = null;
		var found = false;
		$.each($.translateHelper.translateData, function(idx, data) {
			if ( !found )
			{
				if ( data.transCode == transCode)
				{
					entity = data;
				}
			}
		});
		
		var retVal = "";
		if (entity == null)
		{
			alert("transCode not found");
			return retVal;
		}

		if ( countryCode == $.translateHelper.countryCode_kr )
		{
			retVal = entity.krText;
		}
		else if ( countryCode == $.translateHelper.countryCode_cn)
		{
			retVal = entity.cnText;
		}
		else if ( countryCode == $.translateHelper.countryCode_en)
		{
			retVal = entity.enText;
		}
		else
		{
			alert("contryCode not found");
			return retVal;
		}
		
		return retVal;
	}
	$.translateHelper.getText = function(transCode) {
		return $.translateHelper.getTextCore($.translateHelper.countryCode, transCode);
	}
})(jQuery);
</asp:Content>
