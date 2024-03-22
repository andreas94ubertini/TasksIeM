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
    internal class LibroDal : IDal<Libro>
    {
        static LibroDal? instance;

        public static LibroDal getInstance()
        {
            if (instance == null)
                instance = new LibroDal();

            return instance;
        }
        private LibroDal() { }
        public bool delete(int id)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Libro WHERE libroID = @id";
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

        public List<Libro> findAll()
        {
            List<Libro> libriList = new List<Libro>();
            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT libroID,titolo,annoPub,isDispo FROM Libro";
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Libro l = new Libro()
                        {
                            LibroID = Convert.ToInt32(reader[0]),
                            Titolo = reader[1].ToString(),
                            AnnoPub = (DateTime)reader[2],
                            IsDispo = (bool)reader[3],
                        };
                        libriList.Add(l);

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
            return libriList;
        }

        public Libro findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Libro(titolo,annoPub,isDispo)VALUES(@titolo,@annoPub,@isDispo)";
                cmd.Parameters.AddWithValue("@titolo", t.Titolo);
                cmd.Parameters.AddWithValue("@annoPub", t.AnnoPub);
                cmd.Parameters.AddWithValue("@isDispo", t.IsDispo);

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

        public bool update(Libro t)
        {
            bool risultato = false;

            using (SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Utente SET titolo = @titolo, annoPub=@annoPub,isDisp=@isDisp WHERE libroID = @id";
                cmd.Parameters.AddWithValue("@titolo", t.Titolo);
                cmd.Parameters.AddWithValue("@annoPub", t.AnnoPub);
                cmd.Parameters.AddWithValue("@idDisp", t.IsDispo);
                cmd.Parameters.AddWithValue("@id", t.LibroID);

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
