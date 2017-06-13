using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project01_demo.Models
{
    public class PersonRepository
    {
        public List<Person> GetAll(int? antal) {

            List<Person> lst = new List<Person>();
            if (antal.HasValue) {
                for (int i = 0; i < antal.Value; i++)
                {
                    lst.Add(new Person() { IdPerson = i+1, Name = Guid.NewGuid().ToString() });

                }
            } 
            return lst;
        }
    }
}