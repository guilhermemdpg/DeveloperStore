namespace DeveloperStore.API.Application.DTO
{
    public class SaleDTO
    {
        public Guid Id { get; set; }
        public string SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string BranchName { get; set; }
        public bool IsCancelled { get; set; }
        public List<SaleItemDTO> Items { get; set; }
    }
}