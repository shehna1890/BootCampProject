<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Querry.aspx.cs" Inherits="ComplaintRegistration.Admin.Querry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <center>
        <table>
        <tr>
            <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Querry_Id" >
                    <Columns>
                        
                        <asp:BoundField DataField="Querry_Id" HeaderText="QuerryId" />
                        <asp:BoundField DataField="Querry" HeaderText="Querry" />
                        <asp:BoundField DataField="User_Name" HeaderText="UserName" />
                        <asp:BoundField DataField="Product_Id" HeaderText="ProductId" />
                        <asp:HyperLinkField DataNavigateUrlFields="Querry_Id" DataNavigateUrlFormatString="QuerryReply.aspx?Querry_Id={0}" HeaderText="Reply" Text="Reply" />
                        
                    </Columns>
                </asp:GridView>
                

    </table>

    </center>
        
                
</asp:Content>
