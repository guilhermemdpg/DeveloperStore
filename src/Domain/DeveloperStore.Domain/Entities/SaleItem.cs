using System;

namespace DeveloperStore.Domain.Entities
{
    public class SaleItem : Base
    {
        public new Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCancelled { get; set; }

        public SaleItem(string productName, int quantity, decimal unitPrice)
        {
            if (quantity > 20)
                throw new ArgumentException("Cannot sell more than 20 identical items");

            Id = Guid.NewGuid();
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            IsCancelled = false;
            
            CalculateDiscount();
            CalculateTotalAmount();
        }

        private void CalculateDiscount()
        {
            if (Quantity >= 10 && Quantity <= 20)
                Discount = 0.20m;
            else if (Quantity >= 4)
                Discount = 0.10m;
            else
                Discount = 0;
        }

        private void CalculateTotalAmount()
        {
            var subtotal = Quantity * UnitPrice;
            TotalAmount = subtotal - (subtotal * Discount);
        }

        public void Cancel()
        {
            IsCancelled = true;
        }
    }
}