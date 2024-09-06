namespace Calcul.Models
{
    public static class OperationFactory
    {
        public static Operation CreateOperation(string operationType)
        {
            return operationType switch
            {
                "Add" => new AddOperation(),
                "Subtract" => new SubtractOperation(),
                "Multiply" => new MultiplyOperation(),
                "Divide" => new DivideOperation(),
                _ => throw new InvalidOperationException("Неизвестная операция.")
            };
        }
    }
}
