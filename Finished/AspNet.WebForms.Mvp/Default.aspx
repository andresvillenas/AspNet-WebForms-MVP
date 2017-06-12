<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspNet.WebForms.Mvp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Products</h1>

    Filter by type:
    <asp:DropDownList ID="ddlProductTypes" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProductTypes_SelectedIndexChanged"></asp:DropDownList><br />

    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField ReadOnly="True" HeaderText="Id" DataField="Id">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ReadOnly="True" HeaderText="Name" DataField="Name">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ReadOnly="True" HeaderText="Type" DataField="ProductType">
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <div>
        <asp:Literal ID="ltlErrorMessage" runat="server" />
    </div>
</asp:Content>
