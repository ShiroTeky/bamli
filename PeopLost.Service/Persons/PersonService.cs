
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PeopLost.Dapper.Persons;
using System.Linq;

namespace PeopLost.Service.Persons
{
    public partial class PersonService: IPersonService
    {
        IRepository<Person> personRepository;
        PersonRepository persondapper = new PersonRepository();

        public PersonService(IRepository<Person> personRepository)
        {
            this.personRepository = personRepository;
        }

        public virtual void Delete(Person person)
        {
            personRepository.Delete(person);
        }

        public Person GetById(Guid PersonId)
        {
            return personRepository.GetById(PersonId);
        }

        public virtual void Insert(Person person)
        {
            personRepository.Insert(person);
        }

        public void Update(Person person)
        {
            
                personRepository.Update(person);
            
        }


        public IList<Person> GetAll(string contry)
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> GetAll()
        {
            throw new  System.NotImplementedException();
        }


        public IList<Dapper.AlertUtils> GetMyAlertsPersons(Guid id)
        {
            return persondapper.GetMyAlerts(id).ToList();
        }
    }
}
