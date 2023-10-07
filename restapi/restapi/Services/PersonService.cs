using restapi.Models;
using restapi.Services.Interfaces;
using System.Collections.Generic;

namespace restapi.Services
{
    public class PersonService : IPersonService
    {    
        public PersonModel CreatePerson(PersonModel person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public IEnumerable<PersonModel> FindAll()
        {
            return new List<PersonModel>
            {
                new PersonModel
                {
                    Id = 1,
                    Nome = "Teste",
                    Sobrenome = "da Siva",
                    Endereco = "endereco",
                    Sexo = Enums.SexoEnum.Masculino
                },
                new PersonModel
                {
                    Id = 1,
                    Nome = "Teste",
                    Sobrenome = "da Siva",
                    Endereco = "endereco",
                    Sexo = Enums.SexoEnum.Masculino
                }
           };
        }

        public PersonModel FindById(long id)
        {
            return new PersonModel
            {
                Id = 1,
                Nome = "Teste",
                Sobrenome = "da Siva",
                Endereco = "endereco",
                Sexo = Enums.SexoEnum.Masculino
            };
        }

        public PersonModel Update(PersonModel person)
        {
            return person;
        }
    }
}
