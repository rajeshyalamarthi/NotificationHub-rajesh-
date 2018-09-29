using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
public class SourecDal
    {
        public List<Source> Sourceslist = new List<Source>();

        public List<Source> GetSources()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("selectproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "SELECT";
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Sourceslist.Add(new Source
                        {

                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            Name = (sqlDataReader["Name"].ToString()),
                        });

                    }
                }
            }
            return Sourceslist;
                




            }


        public void Entersource()
        {


        }
    }
}
