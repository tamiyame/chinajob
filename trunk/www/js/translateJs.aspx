<%@ Page Language="C#" MasterPageFile="~/CN/WebMaster/EmptyMaster.master" AutoEventWireup="true" CodeFile="translateJs.aspx.cs" Inherits="js_translateJs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

(function($)
{
	$.translateHelper = {};
	$.translateHelper.contryCode_kr = 1;
	$.translateHelper.contryCode_cn = 2;
	
	$.translateHelper.contryCode = <%= this.WebMaster.CountryCode %>;
	$.translateHelper.translateData = new Array();
<asp:Repeater ID="rptTranslateData" runat="server">
<ItemTemplate>
	$.translateHelper.translateData.push({"transCode":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).TransCode%>","krText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).KrText%>","cnText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).CnText%>"});
</ItemTemplate>
</asp:Repeater>
	$.translateHelper.getText = function(transCode) {
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

		if ( $.translateHelper.contryCode == $.translateHelper.contryCode_kr )
		{
			retVal = entity.krText;
		}
		else if ( $.translateHelper.contryCode == $.translateHelper.contryCode_cn)
		{
			retVal = entity.cnText;
		}
		else
		{
			alert("contryCode not found");
			return retVal;
		}
		
		return retVal;
	}
})(jQuery);
</asp:Content>
