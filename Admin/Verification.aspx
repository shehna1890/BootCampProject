<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="ComplaintRegistration.Admin.Verification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table  align="center"class="auto-style">
       
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
    
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="User_Id" OnRowDeleting="GridView1_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:CommandField DeleteText="Confirm" HeaderText="Status" ShowDeleteButton="True" />
                            </Columns>
                        </asp:GridView>

                        </table>

</asp:Content>
