using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA_KyleDiablo
{
    class Appointment
    {
        private int _appointmentId;
        private int _customerId;
        private int _userId;
        private string _title;
        private string _description;
        private string _location;
        private string _contact;
        private string _type;
        private string _url;
        private DateTime _start;
        private DateTime _end;

        public Appointment(int appointmentId, int customerId, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            _appointmentId = appointmentId;
            _customerId = customerId;
            _userId = userId;
            _title = title;
            _description = description;
            _location = location;
            _contact = contact;
            _type = type;
            _url = url;
            _start = start;
            _end = end;
        }

        public void UpdateAppointment(int customerId, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            _customerId = customerId;
            _userId = userId;
            _title = title;
            _description = description;
            _location = location;
            _contact = contact;
            _type = type;
            _url = url;
            _start = start;
            _end = end;
        }
    }
}
