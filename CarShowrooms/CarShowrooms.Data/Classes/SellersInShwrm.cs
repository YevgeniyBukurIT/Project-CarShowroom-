using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CarShowrooms.Data.Classes
{
    [DataContract]
    public  class SellersInShwrm : Base<SellersInShwrm>
    {
        [DataMember]
        private Guid _shwrmId;
        [DataMember]
        private Guid _sellerId;

        

        
        //3 зв‘язок: Багато працівників можуть працювати у багатьох салонах 
        public Shwrm Shwrm
        {
            get => Shwrm.Items.Find(s => s.Id == _shwrmId);

            set => _shwrmId = value.Id;
        }

        public Seller Seller
        {
            get => Seller.Items.Find(s => s.Id == _sellerId);

            set => _sellerId = value.Id;
        }

        public SellersInShwrm()
        {
            Items.Add(this);
        }

    }
    
}
