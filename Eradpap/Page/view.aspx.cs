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
        public enum valuesRequest
        {
            All = 0,
            Hookah = 1,
            Tobacco = 2,
            Fire = 3,
            Other = 4
        }
        

        protected void SelectedList(object sender, EventArgs e)
        {

            //Just.InnerText = DropDownList.SelectedItem.ToString();
            string sqlRequest = $"SELECT publics.\"Product\".\"id\", publics.\"Product\".\"name\", publics.\"Product\".\"price\",publics.\"Product\".\"count\", publics.\"Product\".\"img\",publics.\"Categories\".\"name_Categ\" FROM publics.\"Product\" JOIN publics.\"Categories\" ON publics.\"Categories\".\"id\" = publics.\"Product\".\"id_Categories\"\r\nWHERE publics.\"Categories\".\"name_Categ\" = '{DropDownList.SelectedItem}'";
            BDConnection BDConnection = new BDConnection(sqlRequest);
            List<string[]> list = new List<string[]>();

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







        
        protected void Page_Load(object sender, EventArgs e)
        {
   
            
        }



    }
}