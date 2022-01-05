namespace OCPLibrary
{
    internal class TechnicianAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0,3) }{person.LastName}@acme.com";

            output.IsTechnician = true; 

            return output;
        }
    }
}
