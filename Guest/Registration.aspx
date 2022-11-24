<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ComplaintRegistration.Guest.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center></center>
    <table>            
                
                <tr>
                    <td>Name:</td><td> <asp:textbox id="name" runat="server" ></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validlname" runat="server" ControlToValidate="name" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
               
                <tr>
                    <td>Email:</td><td><asp:TextBox ID="email" runat="server" TextMode="Email" ></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="validemail" runat="server" ControlToValidate="email" ErrorMessage="required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Phone Number:</td><td><asp:TextBox ID="PhoneNumber" runat="server" TextMode ="Phone"></asp:TextBox></td>
                </tr>
                
                
                <tr>
                    <td>Password:</td><td><asp:textbox ID="pwd" runat="server" TextMode="Password"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validpwd" runat="server" ControlToValidate="pwd" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>User Name:</td><td> <asp:textbox id="user" runat="server"></asp:textbox></td>
                    <td><asp:RequiredFieldValidator ID="validuser" runat="server" ControlToValidate="user" ErrorMessage="Required!" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>

                
               <tr>
                    <td><asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click"></asp:Button></td>
                  
                </tr>                
            </table>
</asp:Content>
