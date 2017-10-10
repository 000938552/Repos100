using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private bool discount2;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 15.5m;
        const decimal mdecGeneral = 18.75m;
        const decimal mdecBox = 12.0m;
<<<<<<< HEAD
        const decimal mdecBackStall = 15.0m;
        const decimal mdecDiscount = 15.0m;
        

=======
        const decimal mdecDiscount = 15.0m;
        const decimal mdecDiscount2 = 10.0m;
>>>>>>> feat1.2DiscountType

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private bool Discount2
        {
            get { return discount2; }
            set { discount = value;}
        }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
                case 4:
                    mPrice = mdecBackStall;
                    break;
                                 
         }
         if (discount)
         { mPrice -= mdecDiscount; }

         AmountDue = mPrice * quantity;

     }
    }
}
