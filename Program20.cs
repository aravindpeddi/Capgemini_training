//**Strategy Pattern for Dynamic Discount Calculation**

//Implement different discount strategies (`NoDiscount`, `PercentageDiscount`, `FixedAmountDiscount`).
//The `ShoppingCart` class should apply a strategy dynamically based on user input.

using System;

namespace c__Assignment
{
    interface IDiscountStrategy
    {
        double ApplyDiscount(double totalAmount);
    }

    class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double totalAmount)
        {
            return totalAmount;
        }
    }

    class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public double ApplyDiscount(double totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _fixedAmount;

        public FixedAmountDiscount(double fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public double ApplyDiscount(double totalAmount)
        {
            return totalAmount - _fixedAmount;
        }
    }

    class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateTotal(double totalAmount)
        {
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        ShoppingCart cart = new ShoppingCart();

    //        Console.WriteLine("Enter total amount:");
    //        double totalAmount = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Choose discount type: 1. No Discount 2. Percentage Discount 3. Fixed Amount Discount");
    //        int choice = Convert.ToInt32(Console.ReadLine());

    //        switch (choice)
    //        {
    //            case 1:
    //                cart.SetDiscountStrategy(new NoDiscount());
    //                break;
    //            case 2:
    //                Console.WriteLine("Enter discount percentage:");
    //                double percentage = Convert.ToDouble(Console.ReadLine());
    //                cart.SetDiscountStrategy(new PercentageDiscount(percentage));
    //                break;
    //            case 3:
    //                Console.WriteLine("Enter fixed discount amount:");
    //                double fixedAmount = Convert.ToDouble(Console.ReadLine());
    //                cart.SetDiscountStrategy(new FixedAmountDiscount(fixedAmount));
    //                break;
    //            default:
    //                Console.WriteLine("Invalid choice. No discount will be applied.");
    //                cart.SetDiscountStrategy(new NoDiscount());
    //                break;
    //        }

    //        double finalAmount = cart.CalculateTotal(totalAmount);
    //        Console.WriteLine($"Final amount after discount: {finalAmount}");
    //    }
    //}
}