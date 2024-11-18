using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Trangthaiban
{
    public int Matrangthaiban { get; set; }

    public string Tentrangthaiban { get; set; } = null!;

    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
