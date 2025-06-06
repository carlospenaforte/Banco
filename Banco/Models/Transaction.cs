namespace Banco.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }

        public int AccountOriginId { get; set; }
        public Account AccountOrigin { get; set; }

        public int AccountDestinationId { get; set; }
        public Account AccountDestination { get; set; }
    }
}
