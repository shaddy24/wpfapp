using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace WpfApp1
{
    class DATABASE
    {

        public MySqlConnection con = new MySqlConnection("SERVER = localhost; PORT = 3306; USERNAME = root; PASSWORD =passb11l12; DATABASE =db_nelsoft");



        public MySqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
            
        }

        public int exenon(MySqlCommand cmd)
        {
            cmd.Connection = getcon();

            int rowsaffect = -1;
            rowsaffect = cmd.ExecuteNonQuery();

            return rowsaffect;



        }

        public DataTable exeread(MySqlCommand cmd)
        {
            cmd.Connection = getcon();
             MySqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(sdr);
            con.Close();
            return dt;
        }




    }
}
