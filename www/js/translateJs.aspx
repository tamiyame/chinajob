<%@ Page Language="C#" AutoEventWireup="true" CodeFile="translateJs.aspx.cs" Inherits="js_translateJs" %>
var translateData = new Array();
<asp:Repeater ID="rptTranslateData" runat="server">
<ItemTemplate>
	translateData.push({"transCode":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).TransCode%>","krText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).KrText%>","cnText":"<%# ((Com.Library.Translate.TranslateEntity)Container.DataItem).CnText%>"});
</ItemTemplate>
</asp:Repeater>    
function getText(contryCode, transCode)
{
	var entity = null;
	var found = false;
	$.each(translateData, function(idx, data) {
		if ( !found )
		{
			if ( data.transCode == transCode)
			{
				entity = data;
			}
		}
	});
	
	if (entity == null)
	{
		alert("transCode not found");
	}
	else
	{
		if ( contryCode == 1 )
		{
			
		}
	}
}