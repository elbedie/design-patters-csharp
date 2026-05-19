namespace DesignPatternsCSharp.SOLID.OCP.After;

public class PixPayment : PaymentMethod, IPaymentMethod
{
    public void Pay()
    {
        Console.WriteLine("Pagamento via PIX");
    }
}