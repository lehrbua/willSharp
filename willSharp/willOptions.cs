using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace willSharp
{
    public class willOptions
    {
        public int Rows { get; set; } = 5;
        public string KeyWord { get; set; } = string.Empty;
        public int PriceFrom { get; set; } = 0;
        public int PriceTo { get; set;} = 5;
        public bool PayLivery { get; set; } = false;
        public enum Condition
        {
            New = 22,
            Used = 23,
            Broken = 24,
            AsNew = 2546,
            Exhibit = 2539,
        }

        public enum Handover
        {
            WillCollect = 2536,
            Shipping = 2537
        }

        public List<int> Conditions { get; private set; } = new List<int>();

        public void AddCondition(Condition condition)
        {
            if (Conditions.Contains((int)condition)) throw new ArgumentException("Condition existing");
            else Conditions.Add((int)condition);
        }

        public void RemoveCondition(Condition condition)
        {
            Conditions.Remove((int)condition);
        }

        public void AddHandover(Handover condition)
        {
            if (Conditions.Contains((int)condition)) throw new ArgumentException("Handover existing");
            else Conditions.Add((int)condition);
        }

        public void RemoveHandover(Handover condition)
        {
            Conditions.Remove((int)condition);
        }

    }
}
