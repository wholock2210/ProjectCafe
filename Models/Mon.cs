using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Mon
{
    public int Mamon { get; set; }

    public string Tenmon { get; set; } = null!;

    public string Gia { get; set; } = null!;

    public int Maloaimon { get; set; }

    public virtual ICollection<Dsmonordertb> Dsmonordertbs { get; set; } = new List<Dsmonordertb>();

    public virtual ICollection<Dsmonordertq> Dsmonordertqs { get; set; } = new List<Dsmonordertq>();

    public virtual Loaimon MaloaimonNavigation { get; set; } = null!;
}
