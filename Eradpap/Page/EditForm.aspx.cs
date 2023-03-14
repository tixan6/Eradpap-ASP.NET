using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Eradpap.Scripts;

namespace Eradpap.Page
{
    public partial class EditForm : System.Web.UI.Page
    {
        protected void SelectedList(object sender, EventArgs e)
        {

            string sqlRequest = $"SELECT publics.\"Product\".\"id\", publics.\"Product\".\"name\"," +
                $" publics.\"Product\".\"price\",publics.\"Product\".\"count\", publics.\"Product\".\"img\"" +
                $",publics.\"Categories\".\"name_Categ\" FROM publics.\"Product\" JOIN publics.\"Categories\"" +
                $" ON publics.\"Categories\".\"id\" = publics.\"Product\".\"id_Categories\"\r\nWHERE " +
                $"publics.\"Categories\".\"name_Categ\" = '{DropDownList.SelectedItem}'";


            string sqlRequestAll = $"SELECT publics.\"Product\".\"id\", publics.\"Product\".\"name\"" +
                $", publics.\"Product\".\"price\",publics.\"Product\".\"count\", publics.\"Product\".\"img\"" +
                $",publics.\"Categories\".\"name_Categ\" FROM publics.\"Product\" JOIN publics.\"Categories\" " +
                $"ON publics.\"Categories\".\"id\" = publics.\"Product\".\"id_Categories\"";

            List<string[]> list = new List<string[]>();
            BDConnection BDConnection;

            if (DropDownList.SelectedItem.ToString() == "Все")
                BDConnection = new BDConnection(sqlRequestAll);
            else
                BDConnection = new BDConnection(sqlRequest);

            try
            {
                BDConnection.ConnnectionOpen();
                object res = BDConnection.RequestExecution();

                GridView1.DataSource = res;
                GridView1.DataBind();


                BDConnection.ConnnectionClose();
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        protected void OnSelectedIndexChanged_gridViewFromEdit(object sender, EventArgs e)
        {
            /*//Получать данные при выборе нового меню
            *//*int id = (int)GridView1.SelectedDataKey.Values["id"];
            if (removeRecord(id))
            {
                Response.Redirect(Request.Url.ToString());
            }
            else
            {
                ErrorMessage.InnerText = "Ошибка удаления";
            }*/
            string nameProduct = GridView1.SelectedRow.Cells[2].Text;
            decimal price = Convert.ToDecimal(GridView1.SelectedRow.Cells[3].Text);
            int count = Convert.ToInt32(GridView1.SelectedRow.Cells[4].Text);
            string photo = GridView1.SelectedRow.Cells[5].Text;

            namesProduct.Text = nameProduct.Replace("&quot;", "\"");
            PriceProduct.Text = price.ToString();
            CountProduct.Text = count.ToString();
            FileName.InnerText = photo;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SelectedList(e, e);
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
        protected void click_ToChangeBtn(object sender, EventArgs e) 
        {
            //Выполнение запроса
            string nameProduct = namesProduct.Text;
            decimal price = Convert.ToDecimal(PriceProduct.Text);
            int count = Convert.ToInt32(CountProduct.Text);
            string photo = FileName.InnerText;
            int id = (int)GridView1.SelectedDataKey.Values["id"];
            int categ = DropDownList1.SelectedIndex;

            string req = $@"UPDATE publics.""Product"" SET ""name"" = '{nameProduct}',""price"" = {price}, ""count"" = {count}, ""img"" = '{photo}', ""id_Categories"" = {categ} WHERE ""id"" = {id};";
            string newPathToPhoto = SelectPhoto();
            BDConnection bD = new BDConnection(req);
            bD.ConnnectionOpen();
            bD.RequestExecution();
            bD.ConnnectionClose();


            Response.Redirect(Request.Url.ToString());
        }
    }
}