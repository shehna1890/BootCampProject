<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductRegistration.aspx.cs" Inherits="ComplaintRegistration.Admin.ProductRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <Table>
      <tr>
          <td> Product Name:</td><td> <asp:textbox id="name" runat="server" ></asp:textbox></td>
      </tr> 
       <tr>
           <td>Product Price:</td><td> <asp:textbox id="price" runat="server" ></asp:textbox></td>
       </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td>
            </tr>
            </Table>
    </center> 
   

   
    
                
               

    
</asp:Content>
