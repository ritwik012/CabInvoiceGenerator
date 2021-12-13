using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public double distance;
        public int time;
        private double v1;
        private int v2;
        public const double COST_PER_KILOMETER = 10.0, COST_PER_MINUTE = 1.0, MINIMUM_FARE = 5.0;

        public InvoiceGenerator(double v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double CalculateCabFare()
        {
            throw new NotImplementedException();
        }

        public double CalculateCabFare(double distance, int time)
        {
            double totalFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }
        public double CalculateCabFare(Ride[] ride)
        {
            double totalFare = 0;
            foreach (var data in ride)
            {
                totalFare += this.CalculateCabFare(data.distance, data.time);
            }
            return totalFare;
        }
    }
}