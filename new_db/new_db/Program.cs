using new_db.Models;
using System.Data.SqlClient;

namespace new_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citta> list = new List<Citta>();

            string credenziali = "Server=ACEDEMY2024-04\\SQLEXPRESS;Database=acc_lez24_citta;" +
                "User Id=academy;Password=academy!;MultipleActiveResultSets=true;" +
                "Encrypt=false;TrustServerCertificate=false";

            using (SqlConnection con = new SqlConnection(credenziali))
            {
                string query = "SELECT cittaID, nome, prov FROM Citta";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader[0]}, {reader[1]}, {reader[2]}");
                    Citta c = new Citta() {
                        Id = Convert.ToInt32(reader[0]),
                        Name = reader[1].ToString(),
                        Prov = reader[2].ToString()
                    };
                    list.Add(c);
                }
                con.Close();
            }
            foreach(Citta c in list)
            {
                Console.WriteLine($"--{c.Id}, {c.Name}, {c.Prov}--");
            }
            //string nome = "Pineto";
            //string prov = "Ps";
            //using (SqlConnection con = new SqlConnection(credenziali))
            //{

            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "INSERT INTO Citta(nome,prov)VALUES(@nomeCitta,@provCitta)";
            //    cmd.Parameters.AddWithValue("@nomeCitta", nome);
            //    cmd.Parameters.AddWithValue("@provCitta", prov);
            //    try
            //    {
            //        con.Open();
            //        int affectedRows = cmd.ExecuteNonQuery();
            //        if (affectedRows > 0)
            //        {
            //            Console.WriteLine("Aggiunta correttamente");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errore");
            //        }
            //    }catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        con.Close();
            //        Console.WriteLine("Connessione chiusa");

            //    }

            //}
            //int toDelete = 4;
            //using (SqlConnection con = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "DELETE FROM Citta WHERE cittaID = @id";
            //    cmd.Parameters.AddWithValue("@id",toDelete);
            //    try
            //    {
            //        con.Open();
            //        int affectedRows = cmd.ExecuteNonQuery();
            //        if (affectedRows > 0)
            //        {
            //            Console.WriteLine("Eliminato correttamente");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errore");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }

            //}

            Citta cit = new Citta()
            {
                Id = 1,
                Prov = "PES"
            };
            using (SqlConnection con = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Citta SET prov = @newProv WHERE cittaID = @id";
                cmd.Parameters.AddWithValue("@newProv", cit.Prov);
                cmd.Parameters.AddWithValue("@id", cit.Id);
                try
                {
                    con.Open();
                    int affectedRow = cmd.ExecuteNonQuery();
                    if(affectedRow > 0)
                    {
                        Console.WriteLine("Update effettuato");
                    }
                    else
                    {
                        Console.WriteLine("Errore");
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Connessiona chiusa");
                    con.Close();
                }
            }

            }
    }
}
