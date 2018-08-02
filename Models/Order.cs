using System;

namespace ProjectDashboard.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateScheduledForProduction { get; set; }
        public DateTime DateScheduledForDelivery { get; set; }
        
    }
}