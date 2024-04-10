namespace AspLez01_intro.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Matricola { get; set; }
        public Studente() { }
        public Studente(int id, string? name, string? surname, string? matricola)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Matricola = matricola;
        }
    }
}
