using System;
using System.Collections.Generic;

namespace ProjectCafe.Models;

public partial class Tang
{
    public int Tang1 { get; set; }

    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
