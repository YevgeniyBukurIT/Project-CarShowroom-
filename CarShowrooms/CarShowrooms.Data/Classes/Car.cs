using CarShowrooms.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace CarShowrooms.Data
{
    [DataContract]
    public class Car : Base<Car>
    {

        
        [DataMember]
        private Guid _sellerId;

       

        [DataMember]
        private Guid _shwrmId;

        [DataMember]
        public Model Model { get; set; } //Модель
        [DataMember]
        public string licensePlate { get; set; } //номерний знак
        [DataMember]
        public string VINnumber { get; set; } //ВІН номер
        [DataMember]
        public Occasion occasion { get; set; } //привід
        [DataMember]
        public int NumberOfSeats { get; set; } //кількість місць

        public override string ToString()
        {
            return Model + "/" + licensePlate + "/" + VINnumber + "/" + occasion + "/" + NumberOfSeats; 
        }





        //1 зв‘язок: багато авто можуть належити одному салону 
     
        public Shwrm Shwrm
        {
            get => Shwrm.Items.Find(shwrm => shwrm.Id == _shwrmId);

            set => _shwrmId = value.Id;
        }
        
        //2 зв‘язок: багато авто може продати 1 продавець 
        public Seller Seller
        {
            get => Seller.Items.Find(seller => seller.Id == _sellerId);

            set => _sellerId = value.Id;
        }

        //4 зв‘язок
        public List<Detail> details
        {
            get
            {
                return Detail.Items.Where(detail => detail.Car == this).ToList();
            }
        }



        //рахуємо ціну авто (ОК)
        public double totalPrice = 0;

        public string GetSumModel(String deteils)
        {


            if (deteils == "Audi")
                totalPrice = 1000;
            if (deteils == "BMW")
                totalPrice = 2000;
            if (deteils == "MersedecBenz")
                totalPrice = 3000;
            if (deteils == "Renault")
                totalPrice = 4000;
            if (deteils == "Subaru")
                totalPrice = 5000;
            if (deteils == "Mitsubisi")
                totalPrice = 6000;



            return totalPrice.ToString();

        }

        
        //Надаємо кредит  на авто (ОК)
        public string GetCredit(double CreditValue = 1)
        {

            CreditValue = totalPrice * 1.2;

            return CreditValue.ToString();
        }

       



    }


}



