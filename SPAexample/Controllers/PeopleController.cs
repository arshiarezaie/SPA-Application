using SPAexample.Data;
using SPAexample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPAexample.Controllers
{
    public class PeopleController : ApiController
    {
        SPAexampleContext db = new SPAexampleContext();

        void EntryState(Person person, EntityState state)
        {
            db.Entry(person).State = state;
        }

        public IEnumerable<Person> Get()
        {
            return db.People;
        }

        public Person Get(int Id)
        {
            return db.People.Find(Id);
        }

        public void Post(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
        }

        public void Put(int Id, Person person)
        {
            if (Id == person.ID)
            {
                EntryState(person, EntityState.Modified);
                db.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            EntryState(Get(Id), EntityState.Deleted);
            db.SaveChanges();
        }

    }
}
