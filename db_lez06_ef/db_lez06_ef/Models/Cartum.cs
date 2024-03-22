using System;
using System.Collections.Generic;

namespace db_lez06_ef.Models;

public partial class Cartum
{
    public int CartaId { get; set; }

    public string Codice { get; set; } = null!;

    public string Negozio { get; set; } = null!;

    public int PersonaRif { get; set; }

    public virtual Persona PersonaRifNavigation { get; set; } = null!;
}
