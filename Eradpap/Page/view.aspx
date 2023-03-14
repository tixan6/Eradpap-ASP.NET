<%@ Page Title="" Language="C#" MasterPageFile="~/mains.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Eradpap.Page.view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  
        HeaderStyle-BackColor="#3AC0F2" 
        HeaderStyle-ForeColor="White"
        CssClass="GridView-output" DataKeyNames="id" OnSelectedIndexChanged="OnSelectedIndexChanged_gridViewFromView">
       <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Удалить"  ShowSelectButton="true"/>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="name" HeaderText="Имя товара" />
            <asp:BoundField DataField="price" HeaderText="Цена" />
            <asp:BoundField DataField="count" HeaderText="Кол-во товара" />
            <asp:BoundField DataField="name_Categ" HeaderText="Категория" />
            <asp:ImageField DataImageUrlField="img" HeaderText="Фото" alternatetext="Фото товара"
            nulldisplaytext="Фото товара"/>
       </Columns>


    </asp:GridView>
    <style>
        .GridView-output {
            width: 100%;
        }
        td {
            text-align-last: center;
        }
    </style>
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Категории</h3>
     <asp:DropDownList ID="DropDownList" runat="server" CssClass="select" AutoPostBack="true" OnSelectedIndexChanged="SelectedList">
        <asp:ListItem Text="Все" Value="0"/>
        <asp:ListItem Text="Кальяны" Value="1"/>
        <asp:ListItem Text="Табак"  Value="2"/>
        <asp:ListItem Text="Огниво" Value="3"/>
        <asp:ListItem Text="Прочие" Value="4"/>
     </asp:DropDownList>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderError" runat="server">
    <div>
        <h1 runat="server" id="ErrorMessage"></h1> 
    </div>
    
</asp:Content>