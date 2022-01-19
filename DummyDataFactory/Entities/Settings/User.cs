using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Settings
{
    public record User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public bool IsUse { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
