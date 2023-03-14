<%@ Page Title="" Language="C#" MasterPageFile="~/mains.Master" AutoEventWireup="true" CodeBehind="addPanel.aspx.cs" Inherits="Eradpap.Page.addPanel" %>





<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderError" runat="server">
    <div>
        <h1 runat="server" id="ErrorMessage"></h1> 
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="headerAddPlace">

         <div class="addedPhoto">
            <div class="placeForPhoto">
                <p runat="server" id="FileName">Выбранный путь фотографии</p>
            </div>

            <div class="SelectPhoto">
                <asp:FileUpload ID="FileUploader" runat="server" />
            </div>
        </div>



        <div class="categoriesAdded">
            <h1>Выбор категории</h1>

            <asp:DropDownList runat="server" ID="SelectedListItemsID">
                <asp:ListItem Text="Выберите категорию" Value="0" />
                <asp:ListItem Text="Кальяны" Value="1"/>
                <asp:ListItem Text="Прочие" Value="2"/>
                <asp:ListItem Text="Огниво" Value="3" />
                <asp:ListItem Text="Табак" Value="4"/>
            </asp:DropDownList>

            <asp:Label id="ErrorForList" Text="" ForeColor="Red" runat="server" />


            <div class="inputField">
                <h4>Цена: </h4>
                <asp:TextBox ID="priceTextBoxId" CssClass="priceTextBox" runat="server" />
                
                <asp:RequiredFieldValidator ID="Price" ErrorMessage="Поля не может быть пустым" 
                    ControlToValidate="priceTextBoxId" runat="server" 
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                

            </div>

            <div class="inputField">
                <h4>Название товара: </h4>
                <asp:TextBox ID="NameTextBoxId" CssClass="NameTextBox" runat="server" />

                <asp:RequiredFieldValidator ErrorMessage="Поля не может быть пустым" 
                    ControlToValidate="NameTextBoxId" runat="server" 
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
            </div>

            <div class="inputField">
                <h4>Кол-во товара на складе: </h4>
                <asp:TextBox ID="CountTextBoxId"  CssClass="CountTextBox" runat="server" />

                <asp:RequiredFieldValidator ErrorMessage="Поля не может быть пустым" 
                    ControlToValidate="NameTextBoxId" runat="server" 
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
            </div>


        </div>


    </div>

    <div class="addProduct">
        <asp:Button Text="Добавить товар" runat="server" OnClick="ToAddProduct_Click" />
    </div>
    


    <style>
        .headerAddPlace {
            display: flex;
            justify-content: space-evenly;
        }
        .placeForPhoto {
            width: 150px;
            height: 150px;
            border: solid 0.3px #343434
        }
        .categoriesAdded h1 {
            font-size: 15px
        }
        .inputField {
            
            display: flex;
            align-items: center;
        }
        .priceTextBox {
            height: 20px;
            width: 70px;
            margin-left: 10px;
        }
        .NameTextBox {
            height: 20px;
            width: 200px;
            margin-left: 10px;
        }
        .CountTextBox {
            height: 20px;
            width: 70px;
            margin-left: 10px;
        }
        .addedPhoto {
            align-self: center;
            text-align: center;
            margin-left: 20px;
        }
        .SelectPhoto {
            margin-top: 10px;
        }
        .addProduct {
            margin-top: 70px;
            text-align-last: center;
        }
    </style>

</asp:Content>
