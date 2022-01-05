using OCPLibrary;

#region BeforeRefactoringWithOCP
/*List<PersonModel> applicants = new List<PersonModel>
{
    new PersonModel{FirstName = "Bijay", LastName = "Bajra", TypeOfEmployee = EmployeeType.Executive },
    new PersonModel{FirstName = "Dainora", LastName = "Bajra", TypeOfEmployee = EmployeeType.Manager },
    new PersonModel{FirstName = "Bikram", LastName = "Bajra"}
};

List<EmployeeModel> employees = new List<EmployeeModel>();
Accounts accountProcessor = new Accounts();

foreach (var person in applicants)
{
    employees.Add(accountProcessor.Create(person));
}

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager : {employee.IsManager} IsExecutive: {employee.IsExecutive}");
}

Console.ReadLine();
*/
#endregion


List<IApplicantModel> applicants = new List<IApplicantModel>
{
    new ExecutiveModel{FirstName = "Bijay", LastName = "Bajra"},
    new ManagerModel{FirstName = "Dainora", LastName = "Bajra" },
    new PersonModel{FirstName = "Bikram", LastName = "Bajra"},
    new TechnicianModel{FirstName = "Anup", LastName = "Shakya"},
};

List<EmployeeModel> employees = new List<EmployeeModel>();


foreach (var person in applicants)
{
    employees.Add(person.AccountProcessor.Create(person));
}

foreach (var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager : {employee.IsManager} IsExecutive: {employee.IsExecutive} IsTechnician: {employee.IsTechnician}");
}

Console.ReadLine();