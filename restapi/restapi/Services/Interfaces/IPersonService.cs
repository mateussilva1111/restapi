using restapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restapi.Services.Interfaces
{
    public interface IPersonService
    {
        PersonModel CreatePerson(PersonModel person);
        PersonModel FindById(long id);
        IEnumerable<PersonModel> FindAll();
        PersonModel Update(PersonModel person);
        void Delete(long id);
    }
}
