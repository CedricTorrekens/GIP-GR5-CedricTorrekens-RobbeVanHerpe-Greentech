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

    class SQLScripts
    {
        public static readonly string sqlInsertUser = "INSERT INTO tblUsers (voornaamUser, naamUser, emailUser, wachtwUser) VALUES (@NameUser, @LastNameUser, @Email, @Password);";

        public static readonly string sqlLogIn = "SELECT idUser, emailUser, wachtwUser FROM tblUsers WHERE emailUser = @Email;";

        public static readonly string sqlUserInfo = "SELECT idUser, voornaamUser, naamUser, emailUser FROM tblUsers WHERE idUser = @userId;";

        // stations from user
        public static readonly string sqlUserStations = "SELECT * FROM tblStationUsers WHERE Userid = @userId;";

        // get data
        public static readonly string sqlData = "SELECT * FROM tblGegevens WHERE TimeStamp > '2022-03-13 12:02:04';";
        public static readonly string sqlLastData = "SELECT idStationGeg, TimeStamp FROM tblGegevens ORDER BY TimeStamp DESC LIMIT 1;";

    }
}
