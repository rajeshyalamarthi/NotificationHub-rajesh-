using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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


        public void Entersource(string Name)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("insertproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;

                sqlCommand.ExecuteNonQuery();

            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("delproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "DELETE";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;

                sqlCommand.ExecuteNonQuery();



            }
        }

        public void Edit(int Id, string Name)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("editproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "EDIT";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;

                sqlCommand.ExecuteNonQuery();


            }

        }
    }
}
