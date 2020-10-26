namespace AddressBookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ContactDetails
    {
        // Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNumber;
        public string email;
        public string nameOfAddressBook;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDetails"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="email">The email.</param>
        public ContactDetails(string firstName, string lastName, string address, string city, string state, string zip, 
                               string phoneNumber, string email, string nameOfAddressBook)
        {
            this.firstName = firstName.ToLower();
            this.lastName = lastName.ToLower();
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.nameOfAddressBook = nameOfAddressBook;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.
        /// </returns>
        public override bool Equals(Object obj)
        {
            // if the list is null
            if (obj == null)
                return false;
            try
            {
                // Get the contacts from list with same name
                var duplicates = ((List<ContactDetails>)obj).Find(contact => ((contact.firstName).ToLower() == (this.firstName).ToLower()
                                                                        && (contact.lastName).ToLower() == (this.lastName).ToLower()
                                                                        && contact.nameOfAddressBook == this.nameOfAddressBook));

                // Return true if duplicate is found else false
                if (duplicates != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                // Get the contacts from list with same name
                var contact = ((ContactDetails)obj);
                return ((contact.firstName).ToLower() == (this.firstName).ToLower()
                        && (contact.lastName).ToLower() == (this.lastName).ToLower()
                        && contact.nameOfAddressBook == this.nameOfAddressBook);
            }
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void toString()
        {
            // For null contact
            if(this.nameOfAddressBook == null)
            {
                Console.WriteLine("No record found");
                return;
            }

            // Display all the atributes of contact
            int rowNum = 1;
            Console.WriteLine("\nname of contact is {0}", this.firstName + " " + lastName);
            Console.WriteLine("{0}-firstname is {1}", rowNum++, firstName);
            Console.WriteLine("{0}-lastname is {1}", rowNum++, lastName);
            Console.WriteLine("{0}-address is {1}", rowNum++, address);
            Console.WriteLine("{0}-city is {1}", rowNum++, city);
            Console.WriteLine("{0}-state is {1}", rowNum++, state);
            Console.WriteLine("{0}-zip is {1}", rowNum++, zip);
            Console.WriteLine("{0}-phoneNumber is {1}", rowNum++, phoneNumber);
            Console.WriteLine("{0}-email is {1}", rowNum++, email);
        }
    }
}
