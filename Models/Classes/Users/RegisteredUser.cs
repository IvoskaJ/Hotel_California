using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class RegisteredUser : GuestUser
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private bool loggedIn;
        private DateTime birthday;

        private void setUsername(string username) { this.username = username; }
        public string getUsername() { return this.username; }

        private void setFirstName(string firstName) { this.firstName = firstName; }
        public string getFirstName() { return this.firstName; }

        private void setLastName(string lastName) { this.lastName = lastName; }
        public string getLastName() { return this.lastName; }
        private void setPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }
        public string getPhoneNumber() { return this.phoneNumber; }
        private void setEmail(string email) { this.email = email; }
        public string getEmail() { return this.email; }

        private void setBirthDay(DateTime birthday) { this.birthday = birthday; }
        public DateTime getBirthDay() { return this.birthday; }

        private void setPassword(string password) { this.password = password; }

        private void setLoggedIn() { this.loggedIn = false; }
        
        public bool getLoggedIn() { return this.loggedIn; }

        private string getPassword() { return this.password; }
        public RegisteredUser(string username, string password, string firstName, string lastName, string phoneNumber, string email, DateTime birthday) : base() {
            setBirthDay(birthday);
            setUsername(username);
            setPassword(password);
            setFirstName(firstName);
            setLastName(lastName);
            setPhoneNumber(phoneNumber);
            setEmail(email);
            setLoggedIn();
        }

        public void changePassword(string password, string newPassword) {
            if(password == getPassword()) {
                setPassword(newPassword);
                Console.Write("Your password has been changed!");
            }
        }

        public void changeUserName(string newUsername) {
            setUsername(newUsername);
            Console.Write("your username has been changed successfully");
        }

        public void changePhoneNumber(string newPhoneNumber) {
            setPhoneNumber(newPhoneNumber);
            Console.Write("your phone number has been changed successfully");
        }

        public void login(string username, string password) { if (this.username == username && this.password == password) { this.loggedIn = true; } }

        public void logoff() { this.loggedIn = !this.loggedIn; }
    }
}