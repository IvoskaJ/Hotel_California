using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Classes
{
    public class Reservations
    {
        private DateTime To;
        private DateTime From;
        private TimeSpan Amount;

        public void setTimeTo(DateTime to) { this.To = to; }
        public DateTime getTimeTo() { return this.To; }

        public void setTimeFrom(DateTime from) { this.From = from; }

        public DateTime getFrom() { return this.From; }

        private void setAmount() { this.Amount = this.To.Subtract(this.From); }

        public TimeSpan getAmount() { return this.Amount; }

        public Reservations(DateTime from, DateTime to)
        {
            setTimeFrom(from);
            setTimeTo(to);
            setAmount();
        }
    }
}