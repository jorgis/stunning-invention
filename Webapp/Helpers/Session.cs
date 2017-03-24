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

        public string GetAddress()
        {
            var res =  _context.Session.GetString(Constants.AddressSessionKey);
            return res;
        }

        public string GetDemoAddress()
        {
            return "C7x3Qk4Ap5nvAnxtCEnczmgH34nvfeGRBA";
        }

    }
}