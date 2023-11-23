using System;
using System.Collections.Generic;

namespace Persistence.Entities
{
    public partial class DbLaboratory
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } = null!;
    }
}
