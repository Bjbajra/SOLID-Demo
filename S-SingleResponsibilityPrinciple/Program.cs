using S_SingleResponsibilityPrinciple;

#region BeforeRefactoring
/*Console.WriteLine("Welcome to learn SRP in SOLID");

//Ask for user information
Person user = new Person();

Console.WriteLine("What is your first name: ");
user.firstName = Console.ReadLine();

Console.WriteLine("What is your last name: ");
user.lastName = Console.ReadLine();

//Check to be sure the first and last names are valid
if (string.IsNullOrEmpty(user.firstName))
{
    Console.WriteLine("You did not give us a valid first name!");
    Console.ReadLine();
    return;
}

if (string.IsNullOrEmpty(user.lastName))
{
    Console.WriteLine("You did not give us a valid last name!");
    Console.ReadLine();
    return;
}

//Create a username for the person
Console.WriteLine($"Your username is { user.firstName.Substring(0,1)}{user.lastName}");
Console.ReadLine();*/
#endregion

StandardMessages.WelcomeMessage();

Person user = PersonDataCapture.Capture();

bool isUserValid = PersonValidator.Validate(user);

if(isUserValid == false)
{
    StandardMessages.EndApp();
    return;
}

AccountGenerator.CreateAccount(user);
StandardMessages.EndApp();