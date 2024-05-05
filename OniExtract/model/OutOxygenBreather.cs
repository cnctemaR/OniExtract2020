using KSerialization;
using UnityEngine;

namespace OniExtract2
{
    public class OutOxygenBreather
    {
        public float O2toCO2conversion = 0.5f;
        public float lowOxygenThreshold;
        public float noOxygenThreshold;
        public BVector2 mouthOffset;
        [Serialize]
        public float accumulatedCO2;
        [SerializeField]
        public float minCO2ToEmit = 0.3f;
        private bool IsSuffocating = false;
        public CellOffset[] breathableCells;

        public OutOxygenBreather(OxygenBreather tv)
        {
            this.O2toCO2conversion += tv.O2toCO2conversion;
            this.lowOxygenThreshold = tv.lowOxygenThreshold;
            this.noOxygenThreshold = (float)tv.noOxygenThreshold;
            this.mouthOffset = new BVector2(tv.mouthOffset);
            this.accumulatedCO2 = tv.accumulatedCO2;
            this.minCO2ToEmit = tv.minCO2ToEmit;
            this.IsSuffocating = tv.IsSuffocating;
            this.breathableCells = tv.breathableCells;
        }
    }
}
