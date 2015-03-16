using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormpathSample
{
    class PasswordResetResult : Resource
    {
        public string email { get; set; }
        public Account account { get; set; }
    }
}
