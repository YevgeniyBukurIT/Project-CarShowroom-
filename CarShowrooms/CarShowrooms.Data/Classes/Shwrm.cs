using CarShowrooms.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace CarShowrooms.Data
{
    [DataContract]
    public class Shwrm : Base<Shwrm>
    {
        
        
        [DataMember]
        public string NameShowroom { get; set; } //Назва автосалону (Audi, BMW, Ford)

        [DataMember]
        public string Address { get; set; } //Адреса автосалону

        [DataMember]
        public int Raiting { get; set; } //рейтинг салону

        [DataMember]
        public int NumberPlaceOfCars { get; set; } //кылькысть місць під авто у салоні (Наприклад: автосалон може вмістити у середині 20 авто)
        
        public override string ToString()
        {
            return NameShowroom + "/" + Address + "/" + Raiting + "/" + NumberPlaceOfCars;
        }



        //1 зв‘язок 
        
        public List<Car> cars
        {
            get => Car.Items.Where(car => car.Shwrm == this).ToList();
            
        }

        
        //3 зв‘язок
        public List<Seller> sellers
        {
            get => SellersInShwrm.Items.Where(s => s.Shwrm.Id == Id).Select(s => s.Seller).ToList();
        }


         
                
    }
}
