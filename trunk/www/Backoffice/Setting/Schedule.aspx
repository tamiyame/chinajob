<%@ Page Language="C#" MasterPageFile="~/Backoffice/WebMaster/SettingMaster.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="Backoffice_Setting_Schedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
<script type="text/javascript">
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<style>
 .scheduleTable{margin-top:20px;}
 .scheduleTable table{width:700px;}
 .scheduleTable td{border:none;}
 .scheduleTable tr{height:26px;}
 .scheduleTable td,
 .scheduleTable input,
 .scheduleTable select{font-size:12px;}
 a.button{border:1px solid #bebebe; background:#fbfbfb;padding:4px 8px;font-weight:bold;}
</style>

<div class="title">일정설정</div>
<div class="desc">박람회 일정에 따른 기능 설정입니다. 관리자는 설정된 일정과 무관합니다.</div>

<div class="scheduleTable">
    <table>
        <tr>
            <td style="width:120px;">채용정보등록기간</td>
            <td style="width:100px;">
                <input type="checkbox" name="CompanyJoinType" value="1" <%=ScheduleInfo.CompanyJoinType == 1 ? "checked='checked'":"" %>/>&nbsp;해제
            </td>
            <td style="width:60px;text-align:center;">
                <select name="CompanyJoin_Start_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.CompanyJoin_Start.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="CompanyJoin_Start_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.CompanyJoin_Start.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="CompanyJoin_Start_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.CompanyJoin_Start.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
            <td style="width:30px;text-align:center;">-</td>
            <td style="width:60px;text-align:center;">
                <select name="CompanyJoin_End_Year">
                 <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>"  <%=i==ScheduleInfo.CompanyJoin_End.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="CompanyJoin_End_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.CompanyJoin_End.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="CompanyJoin_End_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.CompanyJoin_End.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
        </tr>
        <tr>
            <td style="width:120px;">인재정보등록기간</td>
            <td style="width:100px;">
                <input type="checkbox" name="UserJoinType" value="1" <%=ScheduleInfo.UserJoinType == 1 ? "checked='checked'":"" %>/>&nbsp;해제
            </td>
            <td style="width:60px;text-align:center;">
                <select name="UserJoin_Start_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>"  <%=i==ScheduleInfo.UserJoin_Start.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="UserJoin_Start_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.UserJoin_Start.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="UserJoin_Start_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.UserJoin_Start.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
            <td style="width:30px;text-align:center;">-</td>
            <td style="width:60px;text-align:center;">
                <select name="UserJoin_End_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.UserJoin_End.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="UserJoin_End_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.UserJoin_End.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;" >
                <select name="UserJoin_End_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.UserJoin_End.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
        </tr>
        <tr>
            <td style="width:120px;">채용지원가능기간</td>
            <td style="width:100px;">
                <input type="checkbox" name="RecruitType" value="1" <%=ScheduleInfo.RecruitType == 1 ? "checked='checked'":"" %>/>&nbsp;해제 
            </td>
            <td style="width:60px;text-align:center;">
                <select name="Recruit_Start_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_Start.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Recruit_Start_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_Start.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Recruit_Start_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_Start.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
            <td style="width:30px;text-align:center;">-</td>
            <td style="width:60px;text-align:center;">
                <select name="Recruit_End_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_End.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Recruit_End_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_End.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Recruit_End_DAy">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Recruit_End.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
        </tr>
        <tr>
            <td style="width:120px;">면접요청가능기간</td>
            <td style="width:100px;">
                <input type="checkbox" name="ParticipateType" value="1" <%=ScheduleInfo.ParticipateType == 1 ? "checked='checked'":"" %>/>&nbsp;해제
            </td>
            <td style="width:60px;text-align:center;">
                <select name="Participate_Start_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_Start.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Participate_Start_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_Start.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Participate_Start_DAy">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_Start.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
            <td style="width:30px;text-align:center;">-</td>
            <td style="width:60px;text-align:center;">
                <select name="Participate_End_Year">
                <% for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 2; i++) {  %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_End.Year?"selected='selected'":"" %>><%=i %></option>
                <% } %>
                </select>년
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Participate_End_Month">
                <%for (int i = 1; i <= 12; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_End.Month?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>월
            </td>
            <td style="width:40px;text-align:center;">
                <select name="Participate_End_Day">
                <%for (int i = 1; i <= 31; ++i)
                  { %>
                    <option value="<%=i %>" <%=i==ScheduleInfo.Participate_End.Day?"selected='selected'":"" %>><%=i %></option>
                <%} %>
                </select>일
            </td>
        </tr>
        <tr>
            <td colspan="9" style="text-align:right;">
                <a class="button" href="javascript:;" onclick="onWrite();">업데이트</a>
            </td>
        </tr>
    </table>    
</div>
<script language="javascript" type="text/javascript">
function onWrite()
{
    jQuery("form:eq(0)").submit();
}
</script> 
</asp:Content>