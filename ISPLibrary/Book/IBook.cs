namespace ISPLibrary
{
    public interface IBook : ILibraryItems
    {
         string Author { get; set; }
         int Pages { get; set; }
    }
}
