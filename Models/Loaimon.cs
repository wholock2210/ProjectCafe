using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Loaimon
{
    public int Maloaimon { get; set; }

    public string Tenloaimon { get; set; } = null!;

    public virtual ICollection<Mon> Mons { get; set; } = new List<Mon>();
}
