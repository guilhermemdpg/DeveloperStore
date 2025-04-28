using System;
using System.Collections.Generic;

namespace DeveloperStore.Domain.Entities
{
    public class Sale : Base
    {
        public new Guid Id { get; set; }
        public string SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string BranchName { get; set; }
        public bool IsCancelled { get; set; }
        public ICollection<SaleItem> Items { get; set; }

        public Sale(string customerName, string branchName)
        {
            Id = Guid.NewGuid();
            SaleNumber = GenerateSaleNumber();
            SaleDate = DateTime.UtcNow;
            CustomerName = customerName;
            BranchName = branchName;
            Items = new List<SaleItem>();
            IsCancelled = false;
        }

        private string GenerateSaleNumber()
        {
            return DateTime.UtcNow.ToString("yyyyMMddHHmmss");
        }

        public void AddItem(SaleItem item)
        {
            Items.Add(item);
            CalculateTotalAmount();
        }

        public void Cancel()
        {
            IsCancelled = true;
        }

        private void CalculateTotalAmount()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.TotalAmount;
            }
        }
    }
}