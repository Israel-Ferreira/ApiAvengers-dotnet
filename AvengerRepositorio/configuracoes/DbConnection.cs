using System;
using System.Collections.Generic;
using System.Text;

namespace AvengersRepositorio.configuracoes
{
    public class DbConnection
    {
        private static string connectionString = "Data source=LAB210-70\\SQL;Initial Catalog=Avengers;Integrated Security=true;";

        public static string GetConn()
        {
            return connectionString;
        }

    }
}
