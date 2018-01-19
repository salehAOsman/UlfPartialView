using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    //we will create new class to help to display tow classes "model " is same view
    public class PerCar
    {
        // we have reference here to lists
        public static List<Person> People { get; set; }
        public static List<Car> Cars { get; set; }

        //we have method to create a few data to display in view 
        //we use here static type to avoid increase Id every time from deferent method
        static PerCar()
        {
            //here we need create new object 
            People = new List<Person>();
            Cars = new List<Car>();

            //People.Add(new Person() {  Name = "", Age = ""}) with empty constractor but with full constractor we have People.Add(new Person("Ulf",35) ); with 
            People.Add(new Person("Ulf",35) );
            People.Add(new Person("Samer",30) );
            People.Add(new Person("Fredrik", 40));

            Cars.Add(new Car("9-5", "SAAB") );
            Cars.Add(new Car("V60", "Volvo") );
            Cars.Add(new Car("i850", "BMW") );
        }
    }
}