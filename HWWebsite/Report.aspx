<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report"  MasterPageFile="~/MasterPage.master"%>




<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <h1>Employee Report</h1>
    <p>
        <asp:ObjectDataSource ID="ReportODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetReportESMenuItems" TypeName="HomeworkLibrary.BLL.AdminController"></asp:ObjectDataSource>
    </p>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>






    <h1>Employee Skills Directory</h1>


    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <LocalReport ReportPath="EmployeeSkillReport.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="EmployeeSkillDS" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetReportESMenuItems" TypeName="HomeworkLibrary.BLL.AdminController"></asp:ObjectDataSource>






</asp:Content>