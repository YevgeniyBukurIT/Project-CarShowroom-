using CarShowrooms.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowrooms.Data
{
    [DataContract]
    public class Seller : Base<Seller>
    {
                    
        

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public Sex Sex { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
           
            return Name + "/" + SurName + "/" + Sex + "/" + Age + "/" + PhoneNumber;

        }

        //2 зв‘язок
        public List<Car> cars
        {
            get
            {
                return Car.Items.Where(car => car.Seller == this).ToList();
            }
        }

        //3 зв‘язок
        public List<Shwrm> shwrms
        {
            get => SellersInShwrm.Items.Where(s => s.Seller.Id == Id).Select(s => s.Shwrm).ToList();
        }



        //МЕТОДИ
        //визначаємо зарплатню продавця за місяць (ОК)
        double monthSalary = 0;
        public string GetSalaryMounth(decimal selledCar)
        {
            if (selledCar == 1)
                monthSalary += 500;
            if (selledCar >= 2)
                monthSalary = 600;
            if (selledCar >= 6)
                monthSalary += 800;
            

            return monthSalary.ToString();


        }


        //річна зарплата (ОК)
        public string GetSalaryYear(decimal value)
        {
            double yearSalary = monthSalary * (365 - 106 - 16);

            
            return yearSalary.ToString();

        }

               

    }
}
