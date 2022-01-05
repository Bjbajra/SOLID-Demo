namespace ISPLibrary
{
    public class ReferenceBook : IBook //ILibraryItems
    {
        public string Author { get; set; }
        //public DateTime BorrowDate { get; set; }
       // public string Borrower { get; set; }
       // public int CheckOutDurationInDays { get; set; } = 0;
        public string LibraryId { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }

       /* public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }*/
    }
}
