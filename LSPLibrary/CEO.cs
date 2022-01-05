namespace LSPLibrary
{
    public class CEO : BaseEmployee,IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }       
        public void GeneratePerformanceReview()
        {
            //Simulate reviewing a direct report
            Console.WriteLine("I am reviewing a direct report's performance.");
        }
        public void FireSomeone()
        {
            //Simulate firing someone
            Console.WriteLine("You are fired.");
        }
    }
}
