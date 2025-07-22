using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace VideoRentalApp
{
    public static class DbHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["VideoRentalDB"].ConnectionString;

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                foreach (var param in parameters)
                    cmd.Parameters.AddWithValue(param.Key, param.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static int GetOrInsertClient(string nume)
        {
            string query = "SELECT Id FROM Clienti WHERE Nume = @Nume";
            var parameters = new Dictionary<string, object> { { "@Nume", nume } };
            object result = ExecuteScalar(query, parameters);

            if (result != null && result != DBNull.Value)
                return Convert.ToInt32(result);

            string insert = "INSERT INTO Clienti (Nume, Email) VALUES (@Nume, '-'); SELECT SCOPE_IDENTITY();";
            object newId = ExecuteScalar(insert, parameters);

            return newId != null && newId != DBNull.Value ? Convert.ToInt32(newId) : -1;
        }

        public static int GetOrInsertFilm(string titlu, string gen)
        {
            string query = "SELECT Id FROM Filme WHERE Titlu = @Titlu AND Gen = @Gen";
            var parameters = new Dictionary<string, object>
            {
                { "@Titlu", titlu },
                { "@Gen", gen }
            };
            object result = ExecuteScalar(query, parameters);

            if (result != null && result != DBNull.Value)
                return Convert.ToInt32(result);

            string insert = "INSERT INTO Filme (Titlu, Gen) VALUES (@Titlu, @Gen); SELECT SCOPE_IDENTITY();";
            object newId = ExecuteScalar(insert, parameters);

            return newId != null && newId != DBNull.Value ? Convert.ToInt32(newId) : -1;
        }
    }
}
