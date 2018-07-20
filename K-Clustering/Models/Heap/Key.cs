using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianMaintenance.Models
{
    public class Key
    {
        public double KeyValue { get; set; }
        public int Index { get; set; }

        public Key(double key,int index)
        {
            this.KeyValue = key;
            this.Index = index;
        }

        public int CompareTo(Key value)
        {
            return this.KeyValue.CompareTo(value.KeyValue);
        }

        public override string ToString()
        {
            return KeyValue.ToString();
        }

        public override bool Equals(object obj)
        {
            var that = (Key) obj;
            if (this.Index == that.Index && this.KeyValue == that.KeyValue)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Key a, Key b)
        {
            return true;//a.KeyValue > b.KeyValue;
        }

        public static bool operator <(Key a, Key b)
        {
            return a.KeyValue < b.KeyValue;
        }
    }
}
