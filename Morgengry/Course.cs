using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        private int durationInMinutes;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int DurationInMinutes {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name) :
            this(name, 0)
        {

        }

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public override string ToString()
        {
            return "Name: " + name + ", " + "Duration in Minutes: " + durationInMinutes;
        }

            

    }
}
