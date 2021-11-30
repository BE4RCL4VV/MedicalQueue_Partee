using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Partee
{
    public class Patient
    {
        private string _first;
        private string _last;
        private int _priority;

        public Patient(string first, /*string last,*/ int priority)
        {
            _first = first;
            //_last = last;
            _priority = priority;
        }
        public string FirstName
        {
            get { return _first; }
            set { _first = value; }
        }
        public string LastName
        {
            get { return _last; }
            set { _last = value; }
        }
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        public override string ToString()
        {
            return FirstName + "\t" + Priority;
        }
    }
}
