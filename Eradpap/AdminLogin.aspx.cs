using Eradpap.Scripts;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
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
            string log = LoginUser.Text;
            string pass = PasswordUser.Text;



            String connectionString = "Server=localhost;Port=5432;Username=postgres;Password=159753;Database=Eradpap;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);

            npgSqlConnection.Open();
 
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT * FROM publics.\"dtAdmin\" WHERE publics.\"dtAdmin\".\"pass\" = '{pass}' AND publics.\"dtAdmin\".\"log\" = '{log}'", npgSqlConnection);

            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                Response.Redirect("admin.aspx");
            }
            else
            {
                Error.Text = "Неправильный логин или пароль";
            }
            npgSqlConnection.Close();

        }


    }
}
