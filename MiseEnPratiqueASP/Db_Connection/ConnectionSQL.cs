using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

using MiseEnPratiqueASP.Models;

using System.Data.SqlClient;

namespace MiseEnPratiqueASP.Db_Connection
{
    public static class ConnectionSQL
    {

        const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_ASP;Integrated Security=True;";


        public static void AddUser(ModelValidationRegisterForm form)
        {
            using (SqlConnection connection = new(CONNECTION_STRING))
            {

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO [User] (Nom, Prenom, Email, Pwd, Confirmation) VALUES(@p1,@p2,@p3,@p4,@p5)";


                cmd.Parameters.AddWithValue("p1", form.Nom);
                cmd.Parameters.AddWithValue("p2", form.Prenom);
                cmd.Parameters.AddWithValue("p3", form.Email);
                cmd.Parameters.AddWithValue("p4", form.Pwd);
                cmd.Parameters.AddWithValue("p5", form.Confirmation);

                cmd.ExecuteNonQuery();
            }
        }



        public static string LogUser(LoginValidation log)
        {
            string? result = string.Empty;
            string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_ASP;Integrated Security=True;";

            using (SqlConnection connection = new(CONNECTION_STRING))
            {

                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM [User] WHERE Email = @p1 AND Pwd = @p2";


                cmd.Parameters.AddWithValue("p1", log.Email);
                cmd.Parameters.AddWithValue("p2", log.Pwd);


                // Exécution de la commande SQL
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // L'utilisateur existe
                        result = reader["Nom"].ToString();
                    }
                }
            }
            return result ?? "";
        }
    }
}
