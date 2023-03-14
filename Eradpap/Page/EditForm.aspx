<%@ Page Title="" Language="C#" MasterPageFile="~/mains.Master" AutoEventWireup="true" CodeBehind="EditForm.aspx.cs" Inherits="Eradpap.Page.EditForm" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Категории</h3>
     <asp:DropDownList ID="DropDownList" runat="server" CssClass="select" AutoPostBack="true" OnSelectedIndexChanged="SelectedList">
        <asp:ListItem Text="Все" Value="0"/>
        <asp:ListItem Text="Кальяны" Value="1"/>
        <asp:ListItem Text="Табак"  Value="2"/>
        <asp:ListItem Text="Огниво" Value="3"/>
        <asp:ListItem Text="Прочие" Value="4"/>
     </asp:DropDownList>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderError" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="false"  
        HeaderStyle-BackColor="#3AC0F2" 
        HeaderStyle-ForeColor="White"
        CssClass="GridView-output" DataKeyNames="id" OnSelectedIndexChanged="OnSelectedIndexChanged_gridViewFromEdit">
       <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Выбрать" ShowSelectButton="true"/>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="name" HeaderText="Имя товара"/>
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
        .editPlaceForTable {
            border: solid 0.3px #3a3a3a;
            width: 800px;
            height: 250px;
        }
        .editPlaceForTable {
            display: flex;
            justify-content: space-evenly;
        }
        .PriceProduct {
            width: 70px;
            height: 25px;
        }
        .CountProduct {
            width: 70px;
            height: 25px;
        }
        .namesProduct {
            height: 25px;
        }
        .ChangeCAtegories 
        {
            margin-top: 60px;
        }
        .changeBTN {
            margin-top: 20px;
        }
    </style>    
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <h1>Данные для изменения</h1>

    <div class="editPlaceForTable">
        <div class="first">
            <div class="ChangeName">
                <h3>Имя товара</h3>
                <asp:TextBox runat="server" CssClass="namesProduct" ID="namesProduct"/>
            </div>

            <div class="ChangePrice">
                <h3>Цена</h3>
                <asp:TextBox runat="server" CssClass="PriceProduct" ID="PriceProduct" />
            </div>
        </div>
        
        <div class="second">
            <div class="ChangeCount">
                <h3>Кол-во товара</h3>
                <asp:TextBox runat="server" CssClass="CountProduct" ID="CountProduct"/>
            </div>

            <div class="ChangeCAtegories">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="select">
                    <asp:ListItem Text="Выберите категорию" Value="0"/>
                    <asp:ListItem Text="Кальяны" Value="1"/>
                    <asp:ListItem Text="Прочие" Value="2"/>
                    <asp:ListItem Text="Огниво" Value="3"/>
                    <asp:ListItem Text="Табак"  Value="4"/>  
                </asp:DropDownList>
            </div>
        </div>
        
        <div class="third">
            <div class="ChangePhotoPath">
                <h3>Фото</h3>
                <div class="addedPhoto">
                    <div class="placeForPhoto">
                        <p runat="server" id="FileName">Выбранный путь фотографии</p>
                    </div>

                    <div class="SelectPhoto">
                        <asp:FileUpload ID="FileUploader" runat="server" />
                    </div>
                </div>
            </div>
        </div>
         
    </div>
        <div class="changeBTN">
            <asp:Button Text="Сохранить изменения" runat="server" OnClick="click_ToChangeBtn" />
        </div>
    
</asp:Content>