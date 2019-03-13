using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterGroupProject.Utils
{
    public static class Utils
    {
        public static bool IsValidEmail(string text)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
