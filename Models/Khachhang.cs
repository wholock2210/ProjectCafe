using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Khachhang
{
    public int Makh { get; set; }

    public string Tenkh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Ordertaiban> Ordertaibans { get; set; } = new List<Ordertaiban>();

    public virtual ICollection<Ordertaiquay> Ordertaiquays { get; set; } = new List<Ordertaiquay>();
}
