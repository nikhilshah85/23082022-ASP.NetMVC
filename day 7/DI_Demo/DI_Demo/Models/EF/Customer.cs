using System;
using System.Collections.Generic;

namespace DI_Demo.Models.EF
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerType { get; set; }
        public int? CustomerWalletBalance { get; set; }
        public string? CustomerEmail { get; set; }
    }
}
