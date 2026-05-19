namespace DesignPatternsCSharp.SOLID.OCP.After;

public class BoletoPayment : IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Pagamento via boleto");
    }
}