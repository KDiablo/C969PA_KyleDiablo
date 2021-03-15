using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class Customer
    {
        private int _customerId;
        private string _customerName;
        private int _addressId;
        private int _active;

        public Customer(int customerId, string customerName, int addressId, int active)
        {
            _customerId = customerId;
            _customerName = customerName;
            _addressId = addressId;
            _active = active;
        }

        public void UpdateCustomer(string customerName, int addressId, int active)
        {
            _customerName = customerName;
            _addressId = addressId;
            _active = active;
        }

        public override string ToString()
        {
            return _customerName;
        }
    }
}
