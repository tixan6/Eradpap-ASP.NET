using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eradpap
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {




        }

        public void SetUpConnection(object sender, EventArgs e) 
        {
         

            String connectionString = "Server=localhost;Port=5432;Username=postgres;Password=159753;Database=Eradpap;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

            npgSqlConnection.Open();
 
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM publics.\"dtAdmin\";", npgSqlConnection);

            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                while (npgSqlDataReader.Read()) // построчно считываем данные
                {
                    object pass = npgSqlDataReader.GetValue(0);
                    object log = npgSqlDataReader.GetValue(1);


                    test.Text = pass.ToString();
                }


            }
            else
                test.Text = "Няма нихуя";
           
        }


    }
}
