using Connecté;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3.Controller
{
    class MainController
    {
        static public ConnexionSql getInstance(ConnexionSql connexionSql, string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            try
            {
                connexionSql = ConnexionSql.getInstance(unProvider, uneDataBase, unUid, unMdp);
            }
            catch (Exception emp)
            {
                throw (emp);
            }

            return connexionSql;
        }

        static public ConnexionSql openConnection(ConnexionSql connexionSql)
        {
            try
            {
                connexionSql.OpenConnection();

            }
            catch (Exception emp)
            {
                throw (emp);
            }

            return connexionSql;
        }

        static public MySqlCommand reqExec(ConnexionSql connexion, string req)
        {
            MySqlCommand mySqlCommand;
            try
            {
                mySqlCommand = connexion.reqExec(req);
            }
            catch (Exception emp)
            {
                throw (emp);
            }

            return mySqlCommand;
        }

        static public ConnexionSql closeConnection(ConnexionSql connexionSql)
        {
            try
            {
                connexionSql.CloseConnection();

            }
            catch (Exception emp)
            {
                throw (emp);
            }

            return connexionSql;
        }



    }
}
