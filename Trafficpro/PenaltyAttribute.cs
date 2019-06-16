using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PenaltyAttribute : Attribute
    {
        public byte MaxPenalty { get; private set; }

        public PenaltyAttribute(byte maxPenalty)
        {
            MaxPenalty = maxPenalty;
        }
    }
}
