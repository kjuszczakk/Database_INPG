using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace FormUI
{
    class DataAccess
    {
        public List<Milk> GetMilks(string nazwaMleka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                var output =  connection.Query<Milk>($"select * from People where NazwaMleka = '{nazwaMleka}'").ToList();
                //var output = connection.Query<Milk>("dbo.People_GetByLastName @LastName", new { LastName = nazwaMleka }).ToList();

                return output;
            }
        }
    }
}
