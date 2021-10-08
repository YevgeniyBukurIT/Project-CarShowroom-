using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarShowrooms.Data.Classes
{
    [DataContract]
    public class Base<T>
        where T : Base<T>
    {

        static public List<T> Items = new List<T>();

        [DataMember]
        public Guid Id { get; private set; }

        

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add((T)this);
        }

       

    }
}
