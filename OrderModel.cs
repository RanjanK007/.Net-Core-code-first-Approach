using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_Code_FirstApproach.ViewModel
{
    public class OrderModel
    {
        [Key]
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public string CardNumber { get; set; }
        public string UserId { get; set; }
    }
}
