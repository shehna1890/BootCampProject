<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ComplaintRegistration.Admin.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <center>
               <p>
                  <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


               </p>
                 
                 
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Login"  />
                </p>

            </center>
            </div>
</asp:Content>
