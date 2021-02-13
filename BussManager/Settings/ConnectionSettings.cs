using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace BussManager.Settings
{
    public class ConnectionSettings
    {
        private const string server = @"(LocalDB)\MSSQLLocalDB";
        private const string database = "JasmairyMultiservices_prueba";
        private string conStr = "";

        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        public ConnectionSettings()
        {
            setConnectionSettings();
        }

        private void setConnectionSettings()
        {
            // this.conStr = $"Server={server};Database={database};Trusted_Connection=True;";
            this.conStr = "Data Source=SQL5078.site4now.net;Initial Catalog=DB_A6F393_bussmanager;User Id=DB_A6F393_bussmanager_admin;Password=Sincontrasena01";
            this.connection = new SqlConnection(this.conStr);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public DataTable BringData(string query)
        {
            table = new DataTable();
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = query;

            if (this.connect())
            {
                adapter.SelectCommand = this.command;
                adapter.Fill(this.table);
            }
            this.Disconnect();

            var result = this.table;
            return result;
        }

        public SqlTransaction BeginTrans(string TransactionName)
        {
            connect();
            return connection.BeginTransaction(TransactionName);
        }
        

        public string bringJsonData(string query)
        {
            try
            {
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = query;
                table = new DataTable();
                if (this.connect())
                {
                    adapter.SelectCommand = this.command;
                    adapter.Fill(table);
                }
                Disconnect();
                var response = table.Rows.Count > 0;
                return response ? JsonConvert.SerializeObject(this.table) : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;

            }
        }

        public bool IsConnected()
        {
            bool isConnected = this.connection.State == ConnectionState.Open;
            return isConnected;
        }

        public bool connect()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch (Exception es)
            {
                MessageManager.ErrorMessage(es.Message);
                return false;
            };
        }

        public void Disconnect()
        {
            try
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            catch (Exception es)
            {
                throw es;
            }
        }

        public bool CorrerSP(string sp)
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = sp;
            if (this.connect())
            {
                this.command.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public bool CorrerSP(string sp, List<parametro> parametros)
        {
            try
            {
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = sp;

                foreach (var par in parametros)
                {
                    this.command.Parameters.Add(par.nombre, par.tipo).Value = par.valor;
                }

                if (this.connect())
                {
                    this.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageManager.ErrorMessage(e.Message);
            }
            finally
            {
                Disconnect();   
            }
            return false;
        }

    }
}

public class parametro
{
    public string nombre { get; set; }
    public SqlDbType tipo { get; set; } 
    public string valor { get; set; }
}
