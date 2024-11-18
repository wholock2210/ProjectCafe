using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Ordertaiquay
{
    public int Maordertq { get; set; }

    public int Makh { get; set; }

    public string? Ghichu { get; set; }

    public int? Maban { get; set; }

    public int? Tang { get; set; }

    public virtual Ban? Ban { get; set; }

    public virtual ICollection<Dsmonordertq> Dsmonordertqs { get; set; } = new List<Dsmonordertq>();

    public virtual Khachhang MakhNavigation { get; set; } = null!;
}
