using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models.Responses
{
    public record RegisterUserResponse
    {
        public string GroupName { get; set; } = null!;
        public string ClientKey { get; set; } = null!;
    }
}
