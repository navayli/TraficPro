using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficpro
{
    public class PenaltyData
    {
        private Dictionary<PenaltyBallType, PenaltyAmountType> keyValues;
        public PenaltyData()
        {
            keyValues = new Dictionary<PenaltyBallType, PenaltyAmountType>()
            {
                {PenaltyBallType.One, PenaltyAmountType.Fifty},
                { PenaltyBallType.Three, PenaltyAmountType.Hundred},
                { PenaltyBallType.Four, PenaltyAmountType.TwoHundred}
            };     
        }
        public PenaltyAmountType GetPenaltyAmount(PenaltyBallType penaltyBallType)
        {
            return keyValues[penaltyBallType];
        }
        

        
    }
}
