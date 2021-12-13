using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public Ride(double runningDistance, int runningTime)
        {
            this.distance = runningDistance;
            this.time = runningTime;
        }
    }
}