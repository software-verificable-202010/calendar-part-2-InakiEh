using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CalendarPart2
{
    [Serializable]
    public class Appointment
    {
        List<Appointment> appointments = new List<Appointment>();

        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public int fromHour { get; set; }
        public int toHour { get; set; }

        public List<Appointment> GetAppointmentsList()
        {
            return appointments;
        }

    }
}
