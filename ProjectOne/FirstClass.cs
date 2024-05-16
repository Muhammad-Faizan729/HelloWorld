using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class FirstClass
    {
        public string carModel;
        public string CarPrice;
        public string carYear;

        public void CarDetails()
        {
            carModel = "Civic";
            CarPrice = "1234567";
            carYear = "2020";

            Console.WriteLine(carModel, CarPrice, carYear);

           
        }

    }
}
