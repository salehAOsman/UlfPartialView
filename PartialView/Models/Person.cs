using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView.Models
{
    public class Person
    {
        //here we fix sequences for Id with constractor dawon
        static int idCount = 0;
        public int Id { get; private set; }// no one can change from out side 
        public string Name { get; set; }
        public int Age { get; set; }

        //constractor for id      "ctor" 
        
        public Person(string name,int age)
        {
                Id = idCount++;
                Name = name;
                Age = age;
        }
    }
}