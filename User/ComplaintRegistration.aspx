<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserLogin.Master" AutoEventWireup="true" CodeBehind="ComplaintRegistration.aspx.cs" Inherits="ComplaintRegistration.User.ComplaintRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h2> Register Your Complaints</h2>
      <Table>
         
       <tr>
           <td> Product Name:</td><td> 
               <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
              
           </td>
          
       </tr>
       <tr>
           <td>Complaint Box</td> <td>
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       </tr>
       <tr>
       <td> <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td> 
       </tr>
    
   </Table> 
        </center>
</asp:Content>
