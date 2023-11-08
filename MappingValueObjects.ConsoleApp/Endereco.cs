namespace MappingValueObjects.ConsoleApp
{
    internal class Endereco
    {
        public string? Logradouro { get; set; }
        public uint? Numero  { get; set; }
        public CEP? Cep { get; set; }

        public Endereco() { }

        public Endereco(string logradouro, uint numero, CEP cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
        }
    }
}
