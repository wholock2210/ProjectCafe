using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Datban
{
    public int Madatban { get; set; }

    public int Maban { get; set; }

    public int Tang { get; set; }

    public int Thoigianvao { get; set; }

    public int? Thoigianra { get; set; }

    public virtual Ban Ban { get; set; } = null!;
}
