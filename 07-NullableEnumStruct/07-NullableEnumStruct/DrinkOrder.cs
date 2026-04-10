using System;
using System.Collections.Generic;
using System.Text;

namespace _07_NullableEnumStruct
{
    public enum DrinkType { Coffee, Tea, Juice, Water }
    public enum DrinkSize { Small, Medium, Large }
    public enum OrderStatus { New, Preparing, Ready, Delivered }

    public class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();
        }
        public decimal CalculatePrice()
        {
            switch(Drink)
            {
                case DrinkType.Coffee:
                    if (Size == DrinkSize.Small) return 3;
                    if (Size == DrinkSize.Medium) return 4;
                        return 5;
                case DrinkType.Tea:
                    if (Size == DrinkSize.Small) return 2;
                    if (Size == DrinkSize.Medium) return 3;
                   return 4;
                case DrinkType.Juice:
                    if (Size == DrinkSize.Small) return 4;
                    if (Size == DrinkSize.Medium) return 5;
                        return 6;
                case DrinkType.Water:
                    if (Size == DrinkSize.Small) return 1;
                    if (Size == DrinkSize.Medium) return 1.5m;
                    return 2;
                    default:
                    return 0;
            }
        }
        public void UpdateStatus(OrderStatus newstatus)
        {
            Status = newstatus;
            Console.WriteLine($"Sifaris #{OrderNumber} statusu:{Status}");
        }
        public void DisplayOrder()
        {
            Console.WriteLine($"Sifaris No: {OrderNumber}");
            Console.WriteLine($"Musteri: {CustomerName}");
            Console.WriteLine($"Icki: {Drink} {Size}");
            Console.WriteLine($"Qiymet : {Price} AZN");
            Console.WriteLine($"Status: {Status}");

        }
    }
}
