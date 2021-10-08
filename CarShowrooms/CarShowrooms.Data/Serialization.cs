using CarShowrooms.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowrooms.Data
{
    public class Serialization
    {
        static private Serialization _obj;
        
        static public Serialization Instance { get
            {
                if (_obj == null)
                    _obj = new Serialization();
                return _obj;
            }
            set { _obj = value; }
        }

        private Serialization() { }

        public List<Car> Cars
        {
            get { return Car.Items; }
            set { Car.Items = value; }
        }

        public List<Detail> Details
        {
            get { return Detail.Items; }
            set { Detail.Items = value; }
        }

        public List<Seller> Sellers
        {
            get { return Seller.Items; }
            set { Seller.Items = value; }
        }

        public List<Shwrm> Shwrms
        {
            get { return Shwrm.Items; }
            set { Shwrm.Items = value; }
        }

        public List<SellersInShwrm> sellersInShwrms
        {
            get { return SellersInShwrm.Items; }
            set { SellersInShwrm.Items = value; }
        }

    }
}
