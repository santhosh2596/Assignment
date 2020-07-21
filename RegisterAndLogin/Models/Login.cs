using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterAndLogin.Models
{
    public class Login : IDisposable
    {
        LEARNINGEntities ctx = new LEARNINGEntities();

        public LOGINTABLE ValidateUser(string username, string password)
        {
            return ctx.LOGINTABLEs.FirstOrDefault(x =>
            x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && x.UserPassword == password);
        }


        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}