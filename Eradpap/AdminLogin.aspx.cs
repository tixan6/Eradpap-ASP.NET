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
            
            string login = LoginUser.Text;
            string password = PasswordUser.Text;
            BDConnection bDConnection = new BDConnection($"SELECT * FROM publics.\"dtAdmin\" WHERE \"dtAdmin\".pass = '{password}' and \"dtAdmin\".log = '{login}';");
            bDConnection.ConnnectionOpen();
            object result = bDConnection.RequestExecution();
            if (result is NpgsqlDataReader)
            {
                Error.Text = "Вы авторизовались";
                Server.Transfer("admin.aspx", true);
            }
            else
            {
                Error.Text = "Неправильный логин или пароль";
            }
            bDConnection.ConnnectionClose();
             
        }


    }
}