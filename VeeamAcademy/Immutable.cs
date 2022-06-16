using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamAcademy
{
    public class Immutable
    {
        private readonly string _value;
        private readonly List<string> _values;
        public Immutable(string value, List<string> values)
        {
            _value = value;
            _values = values;
        }


        public string Value { get { return _value; } }
        public List<string> Values { get { return _values; } }
        public Immutable Text() { return new Immutable(_value, _values); }
    }
}
