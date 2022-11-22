<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="ViewComplaint.aspx.cs" Inherits="ProjectNest.User.ViewComplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center><h1>View Complaint</h1></center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Complaint_id" HorizontalAlign="Center">
        <Columns>
            <asp:BoundField DataField="complaint_id" HeaderText="Complaint Id" />
            <asp:BoundField DataField="pname" HeaderText="Product" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date" />
            <asp:BoundField DataField="status" HeaderText="status" />
        </Columns>
    </asp:GridView>
</asp:Content>
