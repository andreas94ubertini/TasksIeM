using Microsoft.EntityFrameworkCore;
using TaskUni.Models;

namespace TaskUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new  AccLez09MtmUniContext())
            {
                try
                {
                    // elenco tutti gli esami a cui è iscritto uno studente
                    // elenco di tutti gli studenti iscritti ad un esame

                    

                    Studente s = ctx.Studentes.Include(s => s.EsameRifs).Single(s => s.StudenteId == 1);
                    Esame e = ctx.Esames.Include(e => e.StudenteRifs).Single(e => e.EsameId == 5);






                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
