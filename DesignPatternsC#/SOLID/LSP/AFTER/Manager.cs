namespace DesignPatternsCSharp.SOLID.LSP.After;

public class Manager : BonusEmployee
{
    public override void CalculateBonus()
    {
        Console.WriteLine("Bônus do gerente calculado");
    }
}