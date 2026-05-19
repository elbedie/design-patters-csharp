namespace DesignPatternsCSharp.SOLID.LSP.Before;

public class Intern : Employee
{
    public override void CalculateBonus()
    {
        throw new Exception("Estagiário não recebe bônus");
    }
}