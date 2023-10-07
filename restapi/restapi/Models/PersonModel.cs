using restapi.Enums;

namespace restapi.Models
{
    public class PersonModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
