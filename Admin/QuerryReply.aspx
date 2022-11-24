<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="QuerryReply.aspx.cs" Inherits="ComplaintRegistration.Admin.QuerryReply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Product"></asp:Label>
                <asp:TextBox ID="PrTextBox1" runat="server"></asp:TextBox>

            </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Question"> </asp:Label>
                   <asp:TextBox ID="QrTextBox2" runat="server"></asp:TextBox>
                </td>
                </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Reply"></asp:Label>
                <asp:TextBox ID="RpTextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
             <td> <asp:Button ID="Button1" runat="server" Text="Reply" OnClick="Button1_Click" /></td>

        </tr>
       
  </table>
</asp:Content>
