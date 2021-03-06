using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace MovieMakers.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        
        public string ApplicationUserId  { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        
        [Required] public DateTime OrderDate { get; set; }
        [Required] public DateTime ShippingDate { get; set; }
        public Double OrderTotal { get; set; }
        public string OrderCode { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string TransactionId { get; set; }

        public string Phonenumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
    }
}