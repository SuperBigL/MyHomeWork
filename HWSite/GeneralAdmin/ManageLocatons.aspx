<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageLocatons.aspx.cs" Inherits="GeneralAdmin_ManageLocatons" MasterPageFile="~/Site.master" %>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1> Location Admin<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </h1>
    <p> 
        <asp:ListView ID="ListView1" runat="server">
        </asp:ListView>
    </p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <p> &nbsp;</p>



</asp:Content>