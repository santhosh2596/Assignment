using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterAndLogin.Models
{
    public partial class UserDetails
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmailID { get; set; }
    }
}