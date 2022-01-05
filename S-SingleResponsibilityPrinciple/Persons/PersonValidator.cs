namespace S_SingleResponsibilityPrinciple
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //Check to be sure the first and last names are valid
            if (string.IsNullOrEmpty(person.firstName))
            {
                StandardMessages.DisplayValidatorError("first name");                
                return false;
            }

            if (string.IsNullOrEmpty(person.lastName))
            {
                StandardMessages.DisplayValidatorError("last name");               
                return false;
            }
            return true;
        }
    }
}
