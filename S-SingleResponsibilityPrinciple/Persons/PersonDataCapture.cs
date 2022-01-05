namespace S_SingleResponsibilityPrinciple
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            //Ask for user information
            Person output = new Person();

            Console.WriteLine("What is your first name: ");
            output.firstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            output.lastName = Console.ReadLine();

            return output;
        }
    }
}
