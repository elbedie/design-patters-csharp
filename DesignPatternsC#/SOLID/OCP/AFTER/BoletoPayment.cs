namespace DesignPatternsCSharp.SOLID.OCP.After;

public class BoletoPayment : PaymentMethod, IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Pagamento via boleto");
    }
}