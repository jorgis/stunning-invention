using Microsoft.AspNetCore.Http;
using Webapp.Helpers;

namespace WebApp.Helpers
{

    public class Session
    {
        private HttpContext _context;

        public Session(HttpContext context)
        {
            _context = context;
        }

        public string GetPrivateKey()
        {
            var res = _context.Session.GetString(Constants.PrivateKeySessionKey);
            return res;
        }

        public string GetPublicKey()
        {
            var res =  _context.Session.GetString(Constants.PublicKeySessionKey);
            return res;
        }


    }
}