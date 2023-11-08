namespace MappingValueObjects.ConsoleApp
{
    public abstract class ValueObject<T>
    {
        public T? Value { get; protected set; }

        public ValueObject() { }

        protected ValueObject(T value)
        {
            SetValue(value);
        }

        protected virtual void Validate(T? value)
        {
        }

        public void SetValue(T? value)
        {
            Validate(value);
            Value = value;
        }

        public override string ToString()
        {
            return Value?.ToString();
        }
    }
}