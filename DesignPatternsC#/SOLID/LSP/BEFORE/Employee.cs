namespace DesignPatternsCSharp.SOLID.LSP.Before;

public class Employee
{
    public virtual void CalculateBonus()
    {
        Console.WriteLine("Bônus calculado");
    }
}