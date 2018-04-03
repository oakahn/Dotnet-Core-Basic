using System;

namespace Todsphol.Myname
{
    public class Name
    {
       public string Get(string lang = "e") {
           if ("e".Equals(lang)) {
               return GetEnglish();
           }
            return GetThai();
        }

        private string GetEnglish()
        {
            return "Todsphol";
        }

        public string GetThai() {
            return "ทศพล";
        }

    }
}
