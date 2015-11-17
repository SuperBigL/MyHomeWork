<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="SamplePages_Report" MasterPageFile="~/Site.master" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1>My Report</h1>
<p>
    <asp:ObjectDataSource ID="ReportODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetReportESMenuItems" TypeName="HomeworkLibrary.BLL.AdminController"></asp:ObjectDataSource>
</p>
<p>&nbsp;</p>
<p></p>
<rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
    <LocalReport ReportPath="EmployeeSkillReport.rdlc">
        <DataSources>
            <rsweb:ReportDataSource DataSourceId="ReportODS" Name="EmployeeSkillDS" />
        </DataSources>
    </LocalReport>
</rsweb:ReportViewer>
<p>&nbsp;</p>
<p>&nbsp;</p>



</asp:Content>