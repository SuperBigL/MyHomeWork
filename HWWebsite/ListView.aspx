<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView.aspx.cs" Inherits="SamplePages_ScheduleGrid"  masterpagefile="~/MasterPage.master"%>

<script runat="server">


    
    
    protected void Edit_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <h1>My ListView</h1>
    <p>
        <asp:ObjectDataSource ID="LocationList" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="LocationList" TypeName="HomeworkLibrary.BLL.AdminController"></asp:ObjectDataSource>
    </p>
    <p>Action&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Location Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Street Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Province&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Contact Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Active</p>
    <p>
        <asp:LinkButton ID="Add" runat="server" OnClick="Add_Click">Add</asp:LinkButton>
        <asp:TextBox ID="Location" runat="server" Width="187px" style="margin-left: 77px"></asp:TextBox>
        <asp:TextBox ID="Street" runat="server" style="margin-left: 41px"></asp:TextBox>
        <asp:TextBox ID="City" runat="server" style="margin-left: 18px"></asp:TextBox>
        <asp:TextBox ID="Province" runat="server" OnTextChanged="TextBox4_TextChanged" Width="86px" style="margin-left: 35px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Contact" runat="server" style="margin-left: 57px"></asp:TextBox>
        <asp:TextBox ID="PhoneNumber" runat="server" style="margin-left: 36px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="Active" runat="server" />
    </p>
    <p>
        <asp:ListView ID="LocationGrid" runat="server" DataSourceID="LocationList">
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                    <td>
                        <asp:LinkButton ID="Edit" runat="server" OnClick="Edit_Click">Edit</asp:LinkButton>

                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="LocationID" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Name" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Street" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="City" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Province" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Contact" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Phone" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Active" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="PlacementContracts" Mode="ReadOnly" />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    <td>
                        <asp:LinkButton ID="Edit" runat="server" OnClick="Edit_Click">Edit</asp:LinkButton>
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="LocationID" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Name" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Street" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="City" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Province" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Contact" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Phone" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Active" Mode="Edit" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="PlacementContracts" Mode="Edit" />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:LinkButton ID="Edit" runat="server" OnClick="Edit_Click">Edit</asp:LinkButton>
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="LocationID" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Name" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Street" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="City" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Province" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Contact" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Phone" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Active" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="PlacementContracts" Mode="Insert" ValidationGroup="Insert" />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:DynamicControl runat="server" DataField="Edit" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="LocationID" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Name" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Street" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="City" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Province" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Contact" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Phone" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Active" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="PlacementContracts" Mode="ReadOnly" />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th runat="server">Edit</th>
                                    <th runat="server">LocationID</th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Street</th>
                                    <th runat="server">City</th>
                                    <th runat="server">Province</th>
                                    <th runat="server">Contact</th>
                                    <th runat="server">Phone</th>
                                    <th runat="server">Active</th>
                                    <th runat="server">PlacementContracts</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                  <td>
                      <asp:DynamicControl runat="server" DataField="Edit" Mode="Edit" />
                  </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="LocationID" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Name" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Street" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="City" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Province" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Contact" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Phone" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="Active" Mode="ReadOnly" />
                    </td>
                    <td>
                        <asp:DynamicControl runat="server" DataField="PlacementContracts" Mode="ReadOnly" />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    </p>





</asp:Content>




