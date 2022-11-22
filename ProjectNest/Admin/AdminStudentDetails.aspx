<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminStudentDetails.aspx.cs" Inherits="ProjectNest.Admin.AdminStudentDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" HorizontalAlign="Center" OnRowDeleting="GridView1_RowDeleting" >
    <Columns>
        <asp:BoundField DataField="id" HeaderText="User Id" />
        <asp:BoundField DataField="name" HeaderText="Username" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:BoundField DataField="phn" HeaderText="Phone" />
        <asp:CommandField DeleteText="Confirm" HeaderText="Confirm" ShowDeleteButton="True" />
    </Columns>

    </asp:GridView>
    
</asp:Content>

