using System;
using System.Collections.Generic;
using System.Text;

namespace dcompras.Models
{
    public class Purchase
    {
        public string IdPurchase { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }

        public IList<DetailPurchase> DetailPurchases = new List<DetailPurchase>();
    }
}
