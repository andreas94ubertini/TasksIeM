using System;
using System.Collections.Generic;

namespace TaskUni.Models;

public partial class Categorium
{
    public int CategoriaId { get; set; }

    public string NomeCategoria { get; set; } = null!;

    public virtual ICollection<Prodotto> Prodottos { get; set; } = new List<Prodotto>();
}
