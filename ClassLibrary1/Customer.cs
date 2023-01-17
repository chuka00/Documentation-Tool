using System;

namespace ClassLibrary1
{


    [Document("This class represents a customer in the system")]
    public class Customer
    {
        [Document("This gets or sets the customer's ID")]
        public int ID { get; set; }
        [Document("This gets or sets the customer's Name")]
        public string Name { get; set; }
        [Document("This gets or sets the customer's Address")]
        public string Address { get; set; }
        [Document("This gets or sets the customer's Age")]
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }

        [Document("Retrieves customer details from the database")]
        public void GetCustomerDetails(int id)
        {
            
        }

        public Customer(int age, GenderEnum gender)
        {
            Age = age;
            Gender = gender;

        }

        [Document("Provides valid gender options of a customer")]
        public enum GenderEnum
        {
            Male,
            Female
        }

        [Document("Makes a phrase or sentence with the available parameters", "Age and gender", "Outputs a sentence, otherwise known as string")]
        public void FormsAPhraseWithCustomer(int age, GenderEnum gender)
        {
            this.Gender = gender;
            this.Age = age;

            if (GenderEnum.Male == gender) Console.WriteLine("We have a {0} year old male", age);
            else Console.WriteLine("We have a {0} year old female", age);
        }

    }
}

