namespace DesignPatternsCSharp.SOLID.OCP.After;

public class CreditCardPayment : PaymentMethod, IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Pagamento via cartão");
    }
}