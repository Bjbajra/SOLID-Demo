using D_DependencyInversionPrinciple;
using DILibrary;

#region BeforeRefactoringDI
/*Person owner = new Person
{
    FirstName = "Do",
    LastName = "Little",
    EmailAddress = "doli@test.com",
    PhoneNumber = "2415-4584"
};

Chore chore = new Chore
{
    ChoreName = "Take out the box",
    Owner = owner
};

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine()*/
#endregion

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Do";
owner.LastName = "Little";
owner.EmailAddress = "doli@test.com";
owner.PhoneNumber = "2415-4584";

IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the box";
chore.Owner = owner;

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();

Console.ReadLine();