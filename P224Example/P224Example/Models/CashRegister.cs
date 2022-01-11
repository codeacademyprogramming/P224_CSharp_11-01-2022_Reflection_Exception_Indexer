using P224Example.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Models
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public int TotalSalesCount = 0;

        public CashRegister(double totalAmount, Currency currency)
        {
            TotalAmount = totalAmount;
            Currency = currency;
        }

        public void AddNewSales(double price, Currency currency)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount += price;
                            break;
                        case Currency.USD: TotalAmount += price * 1.7;
                            break;
                        case Currency.EUR: TotalAmount += price * 1.92;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount += price / 1.7;
                            break;
                        case Currency.USD: TotalAmount += price;
                            break;
                        case Currency.EUR: TotalAmount += price*1.13;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.EUR:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount += price / 1.92;
                            break;
                        case Currency.USD: TotalAmount += price / 1.13;
                            break;
                        case Currency.EUR: TotalAmount += price;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            TotalSalesCount++;

        }
        public void RemoveSales(double price, Currency currency)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount -= price;
                            break;
                        case Currency.USD: TotalAmount -= price * 1.7;
                            break;
                        case Currency.EUR: TotalAmount -= price * 1.92;
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount -= price / 1.7;
                            break;
                        case Currency.USD: TotalAmount -= price;
                            break;
                        case Currency.EUR: TotalAmount -= price * 1.13; 
                            break;
                    }
                    break;
                case Currency.EUR:
                    switch (currency)
                    {
                        case Currency.AZN: TotalAmount -= price / 1.92;
                            break;
                        case Currency.USD: TotalAmount -= price * 1.13;
                            break;
                        case Currency.EUR: TotalAmount -= price;
                            break;
                    }
                    break;
            }
            TotalSalesCount--;

        }
    }
}