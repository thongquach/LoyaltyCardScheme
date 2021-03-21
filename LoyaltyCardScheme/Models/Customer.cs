
namespace LoyaltyCardScheme.Models
{
    public enum Title
    {
        Mr, Mrs, Ms
    }

    public class Customer
    {
        public int ID { get; set; }
        public Title Title { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
    }
}
