using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Dsmonordertq
{
    public int Mamon { get; set; }

    public int Maordertq { get; set; }

    public int Makh { get; set; }

    public int Soluong { get; set; }

    public string? Size { get; set; }

    public virtual Mon MamonNavigation { get; set; } = null!;

    public virtual Ordertaiquay Ordertaiquay { get; set; } = null!;
}
