using Rentals.Domain.Enums;

namespace Rentals.Domain.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime IssueDate { get; set; }

        public decimal SubtotalAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TotalAmount { get; set; }

        public string Currency {  get; set; } = string.Empty;

        public InvoiceStatus Status { get; set; }

        public Guid RentalId { get; set; }

        public Rental Rental { get; set; } = new Rental();

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; } = new Customer();
    }
}
