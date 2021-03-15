using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class Country
    {
        private int _countryId;
        private string _country;

        public Country(int countryId, string country)
        {
            _countryId = countryId;
            _country = country;
        }

        public int Id
        {
            get { return _countryId; }
        }

        public override string ToString()
        {
            return _country;
        }
    }
}
