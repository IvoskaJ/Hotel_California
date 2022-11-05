using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class GuestUser : User
    {
        private TimeSpan sessionTime;
        private DateTime loginTime;
        private DateTime logoffTime;
        private List<Order> orders;
        private List<TimeSpan> sessionTimes;

        private void setLoginTime() { this.loginTime = DateTime.Now; }
        public DateTime getLoginTime() { return this.loginTime; }

        public void setLogOffTime() { this.logoffTime = DateTime.Now; }
        public DateTime getLogoffTime() { return this.logoffTime; }

        private void setSessionTime() { this.sessionTime = this.logoffTime.Subtract(this.loginTime); }
        public TimeSpan getSessionTime() { return this.sessionTime; }

        public void setOrders(Order order) {
            this.orders.Add(order);
        }

        public List<Order> getOrders() { return this.orders; }

        public void LogIn() { setLoginTime(); }
        public void LogOff() { setLogOffTime(); setSessionTime(); sessionTimes.Add(this.sessionTime); }

        public List<TimeSpan> getSessionTimes() { return this.sessionTimes; }

        public GuestUser() : base() {
            setLoginTime();
            this.orders = new List<Order>();
            this.sessionTimes = new List<TimeSpan>();
        }
    }
}