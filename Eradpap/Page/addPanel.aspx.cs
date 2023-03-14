using Eradpap.Scripts;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eradpap.Page
{
    public partial class addPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ToAddProduct_Click(object sender, EventArgs e) 
        {
            if (Page.IsValid)
            {
                
                    string name = NameTextBoxId.Text.ToString();
                    decimal price = Convert.ToDecimal(priceTextBoxId.Text);
                    int count = Convert.ToInt32(CountTextBoxId.Text);
                    int selectListItems = SelectedListItemsID.SelectedIndex;
                    string pasth = SelectPhoto();

                    if (selectListItems == 0)
                    {
                        ErrorForList.Text = "Выберите категорию";
                    }
                    else
                    {
                        BDConnection bDConnection = new BDConnection($"INSERT INTO publics.\"Product\" (\"name\", \"price\", \"count\", \"img\", \"id_Categories\") \r\nVALUES ('{name}', '{price}', '{count}', '{pasth}', '{selectListItems}');");
                        bDConnection.ConnnectionOpen();
                        bDConnection.RequestExecution();
                        bDConnection.ConnnectionClose();
                    }

                
               
            }
        }

        private string SelectPhoto() 
        {
            string savePath = @"D:\Study\Курсовая по базам данных\Eradpap\Eradpap\img\";

            if (FileUploader.HasFile)
            {
                savePath += FileUploader.FileName;     
                FileUploader.SaveAs(savePath);
                FileName.InnerText = FileUploader.FileName.ToString();
                return savePath; 
            }
            else
            {
                FileName.InnerText = "Выберите фотографию повторно";
                return "Неверный формат";
            }
        }
    }
}