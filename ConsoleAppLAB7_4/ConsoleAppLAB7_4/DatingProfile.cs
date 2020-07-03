using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLAB7_4
{
    class DatingProfile
    {
        public string FirstName;
        private string LastName;
        public int Age;
        public string Gender;
        public string Bio;
        private List<Messages> myMessages;


        public DatingProfile(string FirstName, string LastName, int age, string gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = age;
            this.Gender = gender;
            myMessages = new List<Messages>();

        }

        public void WriteBio(string text)
        {
            Bio = text;

        }

        public void InboxAdd(Messages message)
        {
            myMessages.Add(message);

        }


        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.InboxAdd(message);
        }


        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;





                }
            }
        }



    }





}

