using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class Address
    {
        private int _addressId;
        private string _address;
        private string _address2;
        private int _cityId;
        private string _postalCode;
        private string _phone;

        public Address(int addressId, string address, string address2, int cityId, string postalCode, string phone)
        {
            _addressId = addressId;
            _address = address;
            _address2 = address2;
            _cityId = cityId;
            _postalCode = postalCode;
            _phone = phone;
        }

        public void UpdateAddress(string address, string address2, int cityId, string postalCode, string phone)
        {
            _address = address;
            _address2 = address2;
            _cityId = cityId;
            _postalCode = postalCode;
            _phone = phone;
        }

        public override string ToString()
        {
            return _address;
        }
    }
}
