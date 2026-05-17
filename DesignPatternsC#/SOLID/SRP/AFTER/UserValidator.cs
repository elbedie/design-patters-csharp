public class UserValidator
{
    public bool Validate(string name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }
}