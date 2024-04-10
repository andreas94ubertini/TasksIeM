using System;
using System.Collections.Generic;

namespace AspLez02_db.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? Codice { get; set; }

    public string Titolo { get; set; } = null!;

    public string? Descrizione { get; set; }

    public string? Autore { get; set; }

    public decimal Prezzo { get; set; }

    public int? Quantita { get; set; }
}
