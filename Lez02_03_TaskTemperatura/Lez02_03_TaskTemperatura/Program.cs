namespace Lez02_03_TaskTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float temp = 37.0f;
            //  if(temp < 35.0f || temp > 42.0f || temp >= 37.5f)
            //    Console.Write("Accesso al ristorante negato");
            //else       
            //    Console.WriteLine("Accesso al ristorante consentito");

            Console.WriteLine("Inserisci la tua temperatura");
            try
            {
                string? input = Console.ReadLine();
                double temp = Convert.ToDouble(input);
                if (temp >= 35.0d && temp <= 42.0d)
                    if(temp <       37.5d)
                        Console.WriteLine("Puoi entrare");
                else
                    Console.WriteLine("Non puoi entarare");

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fine programma");
            }
            
        }
    }
}
