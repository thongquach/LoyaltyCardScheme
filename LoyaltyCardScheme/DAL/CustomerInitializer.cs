using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LoyaltyCardScheme.Models;


namespace LoyaltyCardScheme.DAL
{
    public class CustomerInitializer : DropCreateDatabaseIfModelChanges<CustomerContext>
    {
        protected override void Seed(CustomerContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { Title=Title.Mr, FirstName="Thong", SurName="Quach", Address1="77/32", Address2="Ha Ton Quyen Street",
                            Address3="District 5", Address4="Ho Chi Minh City", PostCode="700000", Telephone="0977328488", Age=24 },
                new Customer { Title=Title.Mr, FirstName="Nam", SurName="Nguyen", Address1="12", Address2="Minh Phung Street",
                            Address3="District 6", Address4="Ho Chi Minh City", PostCode="700000", Telephone="0977114215", Age=24 }
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
        }
    }
}
