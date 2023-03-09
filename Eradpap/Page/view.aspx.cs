using Eradpap.Scripts;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eradpap.Page
{
    
    public partial class view : System.Web.UI.Page
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
                //Вывод ошибки
                ErrorMessage.InnerText = "Ошибка вывода из базы данных";
            }


        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SelectedList(e, e);
            }
            
        }



    }
}