namespace DesignPatternsCSharp.SOLID.OCP.Before;

public class PaymentService
{
    public void ProcessPayment(string type)
    {
        if (type == "creditcard")
        {
            Console.WriteLine("Pagamento via cartão");
        }
        else if (type == "pix")
        {
            Console.WriteLine("Pagamento via PIX");
        }
        else if (type == "boleto")
        {
            Console.WriteLine("Pagamento via boleto");
        }
    }
}