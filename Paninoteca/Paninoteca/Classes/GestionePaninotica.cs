using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paninoteca.Classes
{
    internal class GestionePaninotica
    {
        private string credenziali = "Server=ACEDEMY2024-04\\SQLEXPRESS;Database=acc_paninoteca;" +
                                      "User Id=academy;Password=academy!;MultipleActiveResultSets=true;" +
                                      "Encrypt=false;TrustServerCertificate=false";
        private List<Panino> panini = new List<Panino>();
        public void AddPanino(Panino p)
        {
            using (SqlConnection con = new SqlConnection(credenziali))
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Panino(nome,descrizione,prezzo,isVegan)VALUES" +
                    "(@nome,@desc,@prezzo,@isVegan)";
                cmd.Parameters.AddWithValue("@nome",p.Nome);
                cmd.Parameters.AddWithValue("@desc",p.Descrizione);
                cmd.Parameters.AddWithValue("@prezzo",p.Prezzo);
                cmd.Parameters.AddWithValue("@isVegan",p.IsVegan);
                try
                {
                    con.Open();
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows>0) {
                        Console.WriteLine("Panino Aggiunto");
                    }
                    else
                    {
                        Console.WriteLine("Errore nell'aggiunta");
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
        }

        public void GetAll()
        {
           
            using (SqlConnection con = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT paninoID,nome,descrizione,prezzo,isVegan FROM Panino";
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Panino p = new Panino()
                        {
                            PaninoID = Convert.ToInt32(reader[0]),
                            Nome = reader[1].ToString(),
                            Descrizione = reader[2].ToString(),
                            Prezzo = Convert.ToDouble(reader[3]),
                            IsVegan = Convert.ToBoolean(reader[4])
                        };
                        panini.Add(p);

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
        }
        public void Description()
        {
            if (panini.Count() == 0)
            {
                GetAll();
            }
            foreach(Panino p in panini)
            {
                Console.WriteLine($"-{p.Nome}, {p.Descrizione}, {p.Prezzo}EUR, {p.IsVegan}");
            }
        }
        public void CountAll()
        {
            if (panini.Count() == 0)
            {
                GetAll();
            }
            int total = panini.Count();
            Console.WriteLine($"Totale panini presenti {total}");
        }
        public void GetVegan()
        {
            if (panini.Count() == 0)
            {
                GetAll();
            }
            var vegan = from panino in panini
                        where panino.IsVegan == true
                        select panino;
            foreach(Panino v in vegan)
            {
                Console.WriteLine($"-Vegano-{v.Nome}, {v.Descrizione}, {v.Prezzo}EUR, {v.IsVegan}");
            }
        }
        public void AveragePrice()
        {
            if (panini.Count() == 0)
            {
                GetAll();
            }
            double average = panini.Average(p => p.Prezzo);
            Console.WriteLine($"Prezzo medio {average} Eur");
        }
    }
}
