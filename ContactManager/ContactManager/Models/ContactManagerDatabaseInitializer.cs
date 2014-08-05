using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ContactManager.Models
{
    public class ContactManagerDatabaseInitializer :
        DropCreateDatabaseIfModelChanges<ContactManagerContext>
    {
        protected override void Seed(ContactManagerContext context)
        {
            base.Seed(context);
            context.Contacts.Add(
                new Contact
                {
                    Name = "Jon Galloway",
                    Email = "jongalloway@gmail.com",
                    Twitter = "jongalloway",
                    City = "San Diego",
                    State = "CA"

                });
            context.Contacts.Add(
                new Contact
                {
                    Name = "Jesse Liberty",
                    Email = "jesseliberty@gmail.com",
                    Twitter = "jesseliberty",
                    City = "Acton",
                    State = "MA"
                });
                
                context.Contacts.Add(
                    new Contact
                    {
                        Name = "Philip Japikse",
                        Email = "skimedic@gmail.com",
                        Twitter = "skimedic",
                        City = "West Chester",
                        State = "OH"
                    });
                    
                    
                
        }
    }
}