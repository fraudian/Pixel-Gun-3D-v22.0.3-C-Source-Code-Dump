using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    public sealed class Times
    {
        // Fields
        private static long NanosecondsPerTick;
        
        // Methods
        public static long NanoTime()
        {
            var val_4;
            System.DateTime val_1 = System.DateTime.UtcNow;
            val_4 = null;
            val_4 = null;
            return (long)Org.BouncyCastle.Utilities.Times.NanosecondsPerTick * val_1.dateData.Ticks;
        }
        public Times()
        {
        
        }
        private static Times()
        {
            Org.BouncyCastle.Utilities.Times.NanosecondsPerTick = 100;
        }
    
    }

}
