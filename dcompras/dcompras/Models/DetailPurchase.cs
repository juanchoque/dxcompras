using System;
using System.Collections.Generic;
using System.Text;

namespace dcompras.Models
{
    public class DetailPurchase
    {
        public string IdDetailPurchase { get; set; }
        public DateTime Date { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public Purchase Purchase { get; set; }
    }
}
