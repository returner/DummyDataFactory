using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models.Requests
{
    public record RegisterUserRequest
    {
        public string Email { get; set; } = null!;
        public string AppName { get; set; } = null!;
    }
}
