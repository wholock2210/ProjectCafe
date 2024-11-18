using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Ban
{
    public int Maban { get; set; }

    public int Tang { get; set; }

    public string Sizeban { get; set; } = null!;

    public int Matrangthaiban { get; set; }

    public virtual ICollection<Datban> Datbans { get; set; } = new List<Datban>();

    public virtual Trangthaiban MatrangthaibanNavigation { get; set; } = null!;

    public virtual ICollection<Ordertaiban> Ordertaibans { get; set; } = new List<Ordertaiban>();

    public virtual ICollection<Ordertaiquay> Ordertaiquays { get; set; } = new List<Ordertaiquay>();

    public virtual Tang TangNavigation { get; set; } = null!;
}
