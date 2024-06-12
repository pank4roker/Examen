using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z7
{
    class Invoice
    {
        public int account;
        public string customer;
        public string provider;
        string article;
        int quantity;

        public void Tovar(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double PriceWithout(double price)
        {
            return  price * quantity;
        }
        public double PriceWith(double price,double nds)
        {
            return (price * quantity) / nds;
        }
        
    }
}
