<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserLogin.Master" AutoEventWireup="true" CodeBehind="ProductView.aspx.cs" Inherits="ComplaintRegistration.User.ProductView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center"class="auto-style">
        <tr>
            <td class="auto-style1"></td>
                    <td class="auto-style1"></td>

        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_Id">
                    <Columns>
                        <asp:BoundField DataField="Product_Id" HeaderText="ProductID" />
                        <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                        <asp:BoundField DataField="Product_Price" HeaderText="Product Price" />
                    </Columns>
                </asp:GridView>

        </tr>
       

    </table>
    
       
                
</asp:Content>
