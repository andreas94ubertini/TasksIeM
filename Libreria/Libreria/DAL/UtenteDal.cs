using Libreria.Models;
using Libreria.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DAL
{
    internal class UtenteDal : IDal<Utente>
    {
        static UtenteDal? instance;

        public static UtenteDal getInstance()
        {
            if (instance == null)
                instance = new UtenteDal();

            return instance;
        }
        private UtenteDal() { }
        public bool delete(int id)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Utente WHERE utenteID = @id";
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        risultato = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public List<Utente> findAll()
        {
            throw new NotImplementedException();
        }

        public Utente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Utente t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Utente(nome,cognome,email)VALUES(@nome,@cognome,@email)";
                cmd.Parameters.AddWithValue("@nome", t.Nome);
                cmd.Parameters.AddWithValue("@cognome", t.Cognome);
                cmd.Parameters.AddWithValue("@email", t.Email);

                try
                {
                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        risultato = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public bool update(Utente t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Utente SET nome = @nome, cognome=@cognome,email=@email WHERE utenteID = @id";
                cmd.Parameters.AddWithValue("@nome", t.Nome);
                cmd.Parameters.AddWithValue("@cognome", t.Cognome);
                cmd.Parameters.AddWithValue("@email", t.Email);
                cmd.Parameters.AddWithValue("@id", t.UtenteID);

                try
                {
                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        risultato = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }
    }
}
