using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Dsmonordertb
{
    public int Maordertb { get; set; }

    public int Makh { get; set; }

    public int Maban { get; set; }

    public int Tang { get; set; }

    public int Mamon { get; set; }

    public int Soluong { get; set; }

    public string? Size { get; set; }

    public virtual Mon MamonNavigation { get; set; } = null!;

    public virtual Ordertaiban Ordertaiban { get; set; } = null!;
}
