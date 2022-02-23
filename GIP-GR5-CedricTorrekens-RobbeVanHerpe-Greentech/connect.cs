using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    //       _____                  _______        _     
    //      / ____|                |__   __|      | |    
    //     | |  __ _ __ ___  ___ _ __ | | ___  ___| |__  
    //     | | |_ | '__/ _ \/ _ \ '_ \| |/ _ \/ __| '_ \ 
    //     | |__| | | |  __/  __/ | | | |  __/ (__| | | |
    //      \_____|_|  \___|\___|_| |_|_|\___|\___|_| |_|
    //
    //

    class connect
    {
        public MySqlConnection con;

        public void connection()
        {
            con = new MySqlConnection("datasource=5.189.173.7;database=dbGreenTech;port=3306;username=root;password=6ETu%3f8");
            con.Open();
        }
    }
}
