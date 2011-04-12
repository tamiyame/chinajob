<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fileuploader.aspx.cs" Inherits="CN_Popup_fileuploader" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<script type="text/javascript" src="/js/jquery-1.4.2.min.js"> </script>
		<script type="text/javascript" src="/js/common.js"></script>
    <link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/base.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/icon.css" />
    <link rel="stylesheet" type="text/css" href="/ImgSrv/cn/Css/popup.css" />
    
    <title>file uploader</title>
    <script type="text/javascript">
    $(function(){
        $('input[name=upload_file]').change(function(){
            $('#file-search').val($(this).val());
        })        
    })
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return onSubmitCheck();">
    <div class="file-upload" >
        <div class="title">파일첨부</div>
        <div class="file-search">
            <table>
                <tr>
                    <td><input type="text" id="file-search" /></td>
                    <td>
                        <!-- file upload trick.. -->
                        <div style="width: 62px;height: 18px;cursor:pointer; ">
                            <div style="width:62px;height:18px;position: absolute;overflow: hidden; ">
                                <input id="upload_file" name="upload_file" style="height:18px;font-size: 20px; right: 0px; position: absolute; top: 0px;FILTER: alpha(opacity=0); opacity: 0;" type="file" />
                                <a id="btnFileSearch" href="javascript:;" class="icon icon-find"></a>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <div class="desc" >파일첨부는 JPG,GIF,PNG만 가능합니다</div>
        <div class="button" ><a href="javascript:;" class="icon icon-add-confirm" onclick="onFileUpload();"></a></div>
    </div>
<script language="javascript">
function onFileUpload()
{
    var fileName = $("#upload_file" ).val() + "";
    var idx = fileName.lastIndexOf(".");
    var fileExt = fileName.substr(idx + 1, fileName.length - idx );
    
    if ( fileName == "" )
    {
        alert( "파일을 첨부하세요" );
        return false;
    }

    document.forms[ 0 ].submit();
}

function onSubmitCheck()
{
    var fileName = $("#upload_file" ).val() + "";
    var idx = fileName.lastIndexOf(".");
    var fileExt = fileName.substr(idx + 1, fileName.length - idx );
    
    if ( fileName == "" )
    {
        alert( "파일을 첨부하세요" );
        return false;
    }
    return true;
}
</script>
    </form>    
</body>
</html>
