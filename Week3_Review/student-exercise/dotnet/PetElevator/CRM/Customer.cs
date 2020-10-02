using System.Collections.Generic;
using PetElevator.Shared;

namespace PetElevator.CRM
{
    public class Customer : Person, IBillable
    {
        public  string PhoneNumber { get; set; }
        public  List<Pet> Pets { get; set; } = new List<Pet>(); 
        
        /*
        public Customer(string firstName, string lastName, string phoneNumber = "") : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }
        */
        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }
        // This is dumb.
        public Customer(string firstName, string lastName) : this(firstName, lastName, "") {}

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double sum = 0;
            foreach(double servicePrice in servicesRendered.Values)
            {
                sum += servicePrice;
            }
            return sum;
        }
    }
}