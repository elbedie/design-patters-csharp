namespace DesignPatternsCSharp.SOLID.OCP.After;

public class PaymentService
{
    public void ProcessPayment(IPaymentMethod paymentMethod)
    {
        paymentMethod.Pay();
    }
}