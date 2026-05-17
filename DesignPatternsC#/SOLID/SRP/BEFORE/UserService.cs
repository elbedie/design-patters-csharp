public class UserService
{
    public void CreateUser(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Nome inválido");
            return;
        }

        Console.WriteLine("Usuário salvo no banco");

        Console.WriteLine($"Email enviado para {email}");
    }
}