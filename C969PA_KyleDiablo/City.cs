using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class City
    {
        private int _cityId;
        private string _city;
        private int _countryId;

        public City(int cityId, string city, int countryId)
        {
            _cityId = cityId;
            _city = city;
            _countryId = countryId;
        }

        public void UpdateCity(string city, int countryId)
        {
            _city = city;
            _countryId = countryId;
        }

        public override string ToString()
        {
            return _city;
        }
    }
}
