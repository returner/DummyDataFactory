using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models.Requests
{
    public record RequestBase
    {
        public string? ClientKey { get; set; }
    }
}
