using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace WpfApp1
{
    class OPR
    {
        DATABASE db = new DATABASE();
        INFO info = new INFO();
        MySqlCommand cmd = new MySqlCommand();

        public DataTable selectQ()
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM members_info";

            return db.exeread(cmd);
        }

        public int inserQ(INFO info)
        {


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO members_info (Name,Email,Gender,Birthdate,Phone) VALUES('"+info.name1+"','"+info.email1+"','"+info.gender1+"','"+info.bday1+"','"+info.phone1+"' )";

            return db.exenon(cmd);
        }



        public int updateQ(INFO info)
        {


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE members_info SET Name = '" + info.name1 + "',Email = '" + info.email1 + "',Gender = '" + info.gender1 + "',Birthdate= '" + info.bday1 + "',Phone '" + info.phone1 + "' ";

            return db.exenon(cmd);
        }

        public int deleteQ(INFO info)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM members_info WHERE ID = '"+info.id1+"' ";
                return db.exenon(cmd);
        }


    }
}
