using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Ordertaiban
{
    public int Maordertb { get; set; }

    public int Makh { get; set; }

    public int Maban { get; set; }

    public int Tang { get; set; }

    public string? Ghichu { get; set; }

    public virtual Ban Ban { get; set; } = null!;

    public virtual ICollection<Dsmonordertb> Dsmonordertbs { get; set; } = new List<Dsmonordertb>();

    public virtual Khachhang MakhNavigation { get; set; } = null!;
}
