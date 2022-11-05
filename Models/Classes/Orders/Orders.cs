using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class Order
    {
        private string orderId;
        private Room room;
        private static Random random = new Random();
        private DateTime timeOrdered;
        private Reservations reservation;
        private string email;
        private double price; 

        private void setOrderId(string id) {
            this.orderId = id;
        }

        public string getOrderId() { return this.orderId; }

        private static string randomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWYXZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void setRoom(Room room)
        {
            this.room = room;
        }

        public Room getRoom() { return this.room; }

        private void setTimeOrdered() { this.timeOrdered = DateTime.Now; }

        public DateTime getTimeOrdered() { return this.timeOrdered; }

        private void setEmail(string email) { this.email = email; }

        public string getEmail() { return this.email; }

        private void setReservations(Reservations reservation) { this.reservation = reservation; }

        public Reservations getReservations() { return this.reservation; }

        private void setPrice() { this.price = (int)this.reservation.getAmount().Days * this.room.getPricePerNight(); }

        public double getPrice() { return this.price; }

        public Order(Room room, string email, Reservations reservation) {
            setOrderId(randomString(10));
            setTimeOrdered();
            setRoom(room);
            setEmail(email);
            setReservations(reservation);
            setPrice();
        }
    }
}