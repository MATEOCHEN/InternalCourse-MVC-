using System;

namespace MoneyTemplate.Models.ViewModel
{
    public class Account
    {
        public Type Type { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
    }

    public enum Type
    {
        Income = 1,
        Cost = 2
    }
}