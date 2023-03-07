<%@ Page Title="" Language="C#" MasterPageFile="~/mains.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Eradpap.Page.view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
       <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="name" HeaderText="Имя товара" />
            <asp:BoundField DataField="price" HeaderText="Цена" />
            <asp:BoundField DataField="count" HeaderText="Кол-во товара" />
            <asp:BoundField DataField="name_Categ" HeaderText="Категория" />
            <asp:BoundField DataField="img" HeaderText="Фото" />
       </Columns>
    </asp:GridView>

</asp:Content>
