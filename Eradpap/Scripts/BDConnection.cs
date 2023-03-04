using Eradpap.Interface;
using Npgsql;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace Eradpap.Scripts
{
    public class BDConnection : IBDConnections
    {
        
        NpgsqlConnection npgSqlConnection;
        public string ConnetcToBD { get; set; }
        public string Request { get; set; }

        public BDConnection(string request) 
        {
            Request = request;
            ConnetcToBD = "Server=localhost;Port=5432;Username=postgres;Password=159753;Database=Eradpap;";
            npgSqlConnection = new NpgsqlConnection(ConnetcToBD);
        }

        
        public void ConnnectionClose()
        {
            npgSqlConnection.Close();
        }

        public void ConnnectionOpen()
        {
            
            npgSqlConnection.Open();
        }

        public object RequestExecution() 
        {

            NpgsqlCommand npgSqlCommand = new NpgsqlCommand(Request, npgSqlConnection);

            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                return npgSqlDataReader;
            }
            else return new Exception();
        }
    }
}