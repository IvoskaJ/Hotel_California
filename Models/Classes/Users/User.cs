using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class User
    {
        private string userID;
        private static Random random = new Random();
        private DateTime dateCreated;
        private void setUserID(string id) {
            this.userID = id;
        }

        public string getUserID() { return this.userID; }

        private static string randomString(int length) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWYXZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        private void setDateCreated() { this.dateCreated = DateTime.Now; }

        public DateTime getDateCreated() { return this.dateCreated; }

        public User(){
            setUserID(randomString(10));
            setDateCreated();
        }
    }
}