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
               //var output =  connection.Query<Milk>($"select * from People where NazwaMleka = '{nazwaMleka}'").ToList();
                var output = connection.Query<Milk>("dbo.People_GetByLastName @NazwaMleka", new { NazwaMleka = nazwaMleka }).ToList();

                return output;
            }
        }
        public List<Milk> GetAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                var output = connection.Query<Milk>("select * from People").ToList();
           
                return output;
            }
        }
        public void InsertMilk(string nazwaMleka, string iloscKartonow, string cenaZaKartonBrutto, string wspolrzedneMagazynu)
        {   
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                //Milk newMilk = new Milk {NazwaMleka = nazwaMleka, IloscKartonow = iloscKartonow, CenaZaKartonBrutto = cenaZaKartonBrutto, WspolrzedneMagazynu = wspolrzedneMagazynu};
                List<Milk> milks = new List<Milk>();
                
                milks.Add(new Milk {NazwaMleka = nazwaMleka, IloscKartonow = iloscKartonow, CenaZaKartonBrutto = cenaZaKartonBrutto, WspolrzedneMagazynu = wspolrzedneMagazynu});
                
                connection.Execute("dbo.People_Insert @NazwaMleka, @IloscKartonow, @CenaZaKartonBrutto, @WspolrzedneMagazynu", milks);
                
            }
        }
        public void DeleteMilk(string str)
        {
 
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample")))
            {
                if (str.Contains("Łaciate"))
                {
                    string kamil = $"Laciate {str[8]}%";
                    connection.Execute($"delete from People where NazwaMleka = '{kamil}'");
                }
                    
               else
                    connection.Execute($"delete from People where NazwaMleka = '{str}'");
                
   
            }
        }

    }
}
