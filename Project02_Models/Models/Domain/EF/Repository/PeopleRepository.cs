using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project02_Models.Models.Domain.EF.Repository
{
    public class PeopleRepository
    {
        public List<Person> GetAll() {
            using (PersonModel context = new PersonModel())
            {
                var res = context.People.Where(p => p.Height > 150).OrderBy(p => p.Name).ToList();
                return res;
            }
        }
    }
}