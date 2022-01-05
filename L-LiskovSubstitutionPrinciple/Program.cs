using LSPLibrary;

#region BeforeRefactoringLSP
/*Manager accountingVP = new Manager();

accountingVP.FirstName = "Sam";
accountingVP.LastName = "Dong";
accountingVP.CalculatePerHourRate(4);

Employee employee = new Employee();

employee.FirstName = "Bijay";
employee.LastName = "Bajra";
employee.AssignManager(accountingVP);
employee.CalculatePerHourRate(2);

Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour.");
Console.ReadLine();*/
#endregion

IManager accountingVP = new Manager();

accountingVP.FirstName = "Sam";
accountingVP.LastName = "Dong";
accountingVP.CalculatePerHourRate(4);

IManaged employee = new Manager();

employee.FirstName = "Bijay";
employee.LastName = "Bajra";
employee.AssignManager(accountingVP);
employee.CalculatePerHourRate(2);

Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour.");
Console.ReadLine();