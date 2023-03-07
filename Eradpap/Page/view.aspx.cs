using Eradpap.Scripts;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eradpap.Page
{
    public partial class view : System.Web.UI.Page
    {
        static string sqlRequest = "SELECT publics.\"Product\".\"id\", publics.\"Product\".\"name\", publics.\"Product\".\"price\",\r\npublics.\"Product\".\"count\", publics.\"Product\".\"img\",\r\npublics.\"Categories\".\"name_Categ\" \r\nFROM publics.\"Product\" JOIN publics.\"Categories\" ON \r\npublics.\"Categories\".\"id\" = publics.\"Product\".\"id_Categories\"";
        BDConnection BDConnection = new BDConnection(sqlRequest);
        List<string[]> list = new List<string[]>();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
            
        }

    }
}