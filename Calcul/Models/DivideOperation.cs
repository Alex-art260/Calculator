namespace Calcul.Models
{
    public class DivideOperation : Operation
    {
        public override double Execute(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return a / b;
        }
    }
}
