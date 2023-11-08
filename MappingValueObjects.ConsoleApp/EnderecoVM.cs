namespace MappingValueObjects.ConsoleApp
{
    internal class EnderecoVM
    {
        public string? Logradouro { get; set; }
        public uint? Numero  { get; set; }
        public string? Cep { get; set; }

        public EnderecoVM() { }

        public EnderecoVM(string logradouro, uint numero, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
        }
    }
}
