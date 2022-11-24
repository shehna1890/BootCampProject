<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintRegistration.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <center>
               <p>
                  <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
                 <asp:TextBox ID="Txtuser" runat="server"></asp:TextBox>


               </p>
                 
                 
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="Txtpwd" runat="server"></asp:TextBox>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"  />
                </p>

            </center>
            </div>
</asp:Content>
