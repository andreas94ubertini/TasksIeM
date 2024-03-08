namespace Lez05_03_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //scrittura file ------------
            //string? path = Path.GetDirectoryName(typeof(Program).Assembly.Location); salva nella directory del progetto
            string pathUno = "C:\\Users\\utente\\Desktop\\test.txt";
            string contenuto = "Test di scrittura";
            try
            {
                if(pathUno != null)
                    using (StreamWriter sw = new StreamWriter(pathUno))
                    {
                        sw.WriteLine(contenuto);
                        sw.WriteLine("Dopo");
                    }
                    Console.WriteLine("Tutto Ok");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Lettura file-----------------
            string pathLettura = "C:\\Users\\utente\\Desktop\\test.txt";
            try
            {
                using (StreamReader sr = new StreamReader(pathLettura))
                {
                    string? line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
