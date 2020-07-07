using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8_5LAB
{
    class DreamHouseHunters: Application
    {
        public string JobTitle;
        public int CurrentAnnualIncome;
        public int BuyingHouseMonth;
        public int NumOfBedrooms;
        public int NumOfBathrooms;

        public DreamHouseHunters(string jobTitle, int currentIncome, int BuyingHouseMonth, int NumOfBedrooms, int NumOfBathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {
            this.JobTitle = jobTitle;
            this.CurrentAnnualIncome = currentIncome;
            this.BuyingHouseMonth = BuyingHouseMonth;
            this.NumOfBedrooms = NumOfBedrooms;
            this.NumOfBathrooms = NumOfBathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to the TV show: Dream House Hunters");
        }
    
    }
}
