using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MyKTV.sys
{
    class DBHelper
    {
        private string strCon = "Data Source=192.168.1.102;Initial Catalog=MyKTV;User ID=sa;Pwd=123456";
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(strCon);
                }
                return _conn;
            }
        }
        public void OpenConn()
        {
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            else if(Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void CloseConn()
        {
            if (Conn.State == ConnectionState.Broken || Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
    }
}
