using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOP_Generic
{
    internal class KeyValuePair<TKey,Tvalue,TResult>
    {
        public TKey ID { get; set; }
        public Tvalue Name { get; set; }
        public DateTime BirthDate { get; set; }

        public TResult Get(TResult data)
        {
            return (data);
        }
    }
}
