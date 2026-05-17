namespace DesignPatternsCSharp.SOLID.SRP.After;

public class UserService
{
    private readonly UserValidator _validator;
    private readonly UserRepository _repository;
    private readonly EmailService _emailService;

    public UserService()
    {
        _validator = new UserValidator();
        _repository = new UserRepository();
        _emailService = new EmailService();
    }

    public void CreateUser(string name, string email)
    {
        bool isValid = _validator.Validate(name);

        if (!isValid)
        {
            Console.WriteLine("Nome inválido");
            return;
        }

        _repository.Save(name, email);

        _emailService.Send(email);
    }
}