namespace Banco.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string User { get; set; }
        public decimal Balance { get; set; }

        public ICollection<Transaction> TransactionOrigin { get; set; }
        public ICollection<Transaction> TransactionDestination { get; set; }
    }
}
