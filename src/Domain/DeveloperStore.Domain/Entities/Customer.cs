using System;

namespace DeveloperStore.Domain.Entities
{
    public class Customer : Base
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }
    }
}