namespace S_SingleResponsibilityPrinciple
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            //Create a username for the person
            Console.WriteLine($"Your username is { user.firstName.Substring(0, 1)}{user.lastName}");
        }
    }
}
