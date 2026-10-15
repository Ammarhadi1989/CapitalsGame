using System;
using System.Collections.Generic;
using System.Text;

namespace Capitalgame
{
    public class Country
    {
        public string country { get; set; }

        public string capitalEn { get; set; }

        public string capitalSwe { get; set; }

        


        // Constructor

        public Country(string country, string capitalEn, string capitalSwe)
        {
            this.country = country;
            this.capitalEn = capitalEn;
            this.capitalSwe = capitalSwe;
            
        }
    }
}
