using System;
namespace SplitIt.Models
{
    public class SplitItem
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public bool Paid { get; set; }
        public int SplitBetween { get; set; }
        public int SplitType { get; set; }
    }
}
