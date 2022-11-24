<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserLogin.Master" AutoEventWireup="true" CodeBehind="QuerryRegistration.aspx.cs" Inherits="ComplaintRegistration.User.QuerryRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2> Register Your Querries</h2>
      <Table>
        <tr>
           <td> Product Name:</td><td> 
               <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
              
           </td>
          
       </tr>
       <tr>
           <td>QuerryBox</td> <td> <asp:TextBox ID="Txtquerry" runat="server"></asp:TextBox>
       </tr>
       <tr>
       <td> <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td> 
       </tr>
    
   </Table> 
        </center>
   
    

    
</asp:Content>
