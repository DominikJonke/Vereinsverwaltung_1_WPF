using System;

namespace Vereinsverwaltung.Model
{
    public class Verein
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }
        public DateTime Birthday { get; set; }

    }
}
