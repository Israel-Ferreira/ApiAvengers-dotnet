using AvengersModelo;
using AvengersRepositorio.configuracoes;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AvengerRepositorio
{
    public class AvengerRepository
    {
        public IEnumerable<AvengersModel> Get()
        {
            using (var connection = new SqlConnection(DbConnection.GetConn()))
            {
                return connection.Query<AvengersModel>("SELECT * FROM Herois");
            }
        }
        public bool Delete()
        {
            using (var connection = new SqlConnection(DbConnection.GetConn()))
            {
                var result = connection.Execute("DELETE FROM Herois");
                return result > 0;
            }
        }
    }
}
