<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewComplaint.aspx.cs" Inherits="ComplaintRegistration.Admin.ViewComplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h3> Complaint View </h3>
    <table class="w-80">
    </table>
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Complaint_Id" Height="314px" Width="937px">
        <Columns>
            <asp:BoundField DataField="Complaint_Id" HeaderText="Complaint Id" />
            <asp:BoundField DataField="User_Id" HeaderText="User Id" />
            <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
            <asp:BoundField DataField="Complaint_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
            <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
        </Columns>
    </asp:GridView>
        <br />
         
    <br />
    <br />
    &nbsp;<br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Complaint_Id" Height="314px" Width="937px"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView3_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Complaint_id" HeaderText="Complaint Id" />
            <asp:BoundField DataField="User_Id" HeaderText="User Id" />
            <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
            <asp:BoundField DataField="Complaint_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
            <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
            <asp:CommandField DeleteText="Closed" HeaderText="Status" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
   <br />
    From :<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
    To:<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
   
    <br />
    <br />
    <br />

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Complaints" />
    <asp:Button ID="Button3" runat="server" OnClick="Button2_Click" Text="Complaints in Process" />
    <br />
    <br />
    &nbsp;<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Complaint_Id" Height="314px" Width="937px" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Complaint_Id" HeaderText="Complaint_Id" />
            <asp:BoundField DataField="User_Id" HeaderText="User_Id" />
            <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
            <asp:BoundField DataField="Complaint_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
            <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
            <asp:CommandField DeleteText="View Complaint" HeaderText="Status" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="Complaint_Id" Height="314px" Width="937px"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView3_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Complaint_Id" HeaderText="Complaint Id" />
            <asp:BoundField DataField="User_Id" HeaderText="User_Id" />
            <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
            <asp:BoundField DataField="Complaint_Date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
            <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
            <asp:CommandField DeleteText="Closed" HeaderText="Status" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    </asp:Content>
    
               
