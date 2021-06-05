using SalesWebMvc2.Models.Enums;
using System;
namespace SalesWebMvc2.Models
{
    public class SalesRecord
    {
        private int v1;
        private DateTime dateTime;
        private double v2;
        private SaleStatus billed;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }


        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;          
        }    
    }
}
