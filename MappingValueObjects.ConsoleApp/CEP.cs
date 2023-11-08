namespace MappingValueObjects.ConsoleApp
{
    public class CEP : ValueObject<string?>
    {
        public CEP()
        {
        }

        public CEP(string? value) : base(value)
        {
        }

        protected override void Validate(string? value)
        {
            if (value == null) return;
            if (value.Length != 8) throw new Exception("Tamanho inválido");
        }

        public override string ToString()
        {
            return Value?.ToString(); //retornar com formatação #####-###
        }
    }
}