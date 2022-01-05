namespace S_SingleResponsibilityPrinciple
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to learn SRP in SOLID");
        }
        public static void EndApp()
        {
            Console.ReadLine();
        }
        public static void DisplayValidatorError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
    }
}
