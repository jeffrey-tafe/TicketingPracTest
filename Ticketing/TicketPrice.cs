﻿using System;
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
        private decimal amountDue;
        private decimal mPrice;

        // Original prices
        //const decimal mdecBalcony = 35.5m;
        //const decimal mdecGeneral = 28.75m;
        //const decimal mdecBox = 62.0m;
        //const decimal mdecDiscount = 5.0m;

        // Price Changes V1
        //const decimal mdecBalcony = 45.5m;
        //const decimal mdecGeneral = 38.75m;
        //const decimal mdecBox = 72.0m;
        //const decimal mdecDiscount = 15.0m;

        // Price Changes V2
        const decimal mdecBalcony = 55.5m;
        const decimal mdecGeneral = 48.75m;
        const decimal mdecBox = 82.0m;
        //const decimal mdecDiscount = 25.0m;

        // Increased discount
        const decimal mdecDiscount = 35.0m;

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
         }
         if (discount)
         { mPrice -= mdecDiscount; }

         AmountDue = mPrice * quantity;

     }
    }
}
