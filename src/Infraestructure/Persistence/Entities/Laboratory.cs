using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class DbLaboratory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
