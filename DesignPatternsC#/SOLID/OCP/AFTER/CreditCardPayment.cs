namespace DesignPatternsCSharp.SOLID.OCP.After;

public class CreditCardPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Pagamento via cartão");
    }
}