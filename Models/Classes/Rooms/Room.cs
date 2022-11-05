using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class Room
    {
        private string name;
        private int amountOfBeds;
        private string roomNumber;
        private List<string> reviews;
        private bool isBooked;
        private List<Reservations> reservations;
        private double pricePerNight;

        private void setName(string name) { this.name = name; }
        public string getName() { return this.name; }

        private void setRoomNumber(string number) { this.roomNumber = number; }
        public string getRoomNumber() { return this.roomNumber; }

        private void setAmountOfBeds(int amount) { this.amountOfBeds = amount; }
        public int getAmountOfBeds() { return this.amountOfBeds; }

        private void setIsBooked() { this.isBooked = !this.isBooked; }
        public bool getIsBooked() { return this.isBooked; }

        public void addReview(string review) { this.reviews.Add(review); }
        public void addReservations(Reservations reservation) { this.reservations.Add(reservation); }

        public List<Reservations> getReservations() { return this.reservations; }

        public List<string> getReviews() { return this.reviews; }

        private void setPrice(double price) { this.pricePerNight = price; }

        public double getPricePerNight() { return this.pricePerNight; }
        public Room(string name, string roomNumber, int amountOfBeds, double price) {
            setAmountOfBeds(amountOfBeds);
            setName(name);
            setRoomNumber(roomNumber);
            isBooked = false;
            this.reviews = new List<string>();
            this.reservations = new List<Reservations>();
            setPrice(price);
        }
    }
}