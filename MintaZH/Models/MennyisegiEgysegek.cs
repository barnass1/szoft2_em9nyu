﻿using System;
using System.Collections.Generic;

namespace MintaZH.Models;

public partial class MennyisegiEgysegek
{
    public int MennyisegiEgysegId { get; set; }

    public string? EgysegNev { get; set; }

    public virtual ICollection<Nyersanyagok> Nyersanyagok { get; set; } = new List<Nyersanyagok>();
}
