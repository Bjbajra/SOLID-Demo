namespace ISPLibrary
{
    public interface IDVD : ILibraryItems
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
