using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CarShowrooms.Data.Classes
{
    [DataContract]
    public class Detail : Base<Detail>
    {

                
        [DataMember]
        private Guid _carId;


        [DataMember]
        public string DeteilType { get; set; } //тип деталі (наприклад: задній міст, кардан, капот)
        [DataMember]
        public string DetailNumber { get; set; } //Номер деталі
        [DataMember]
        public int Mass { get; set; } //маса деталі
        [DataMember]
        public Model DetailModel { get; set; } //до якого авто належить деталь 

        public override string ToString()
        {
            return DeteilType + "/" + DetailNumber + "/" + Mass + "/" + DetailModel;
        }



        //4 зв‘язок: Багато деталів можуть належити одному авто
        public Car Car
        {
            get => Car.Items.Find(car => car.Id == _carId);

            set => _carId = value.Id;
        }


        
                 
                


            //метод, який відповідає за доставку деталі до дому (ОК)
         public string HomeDelivery(bool isDelivery )
         {

            if (isDelivery)
                return "200$";

            return "";

         }
            
        



    }   
}
