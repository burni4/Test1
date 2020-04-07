using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class ElementID<T>
    {
        public T ID { get; set; }
        public ElementID()
        {
            ID = default(T);
        }
    }
}
