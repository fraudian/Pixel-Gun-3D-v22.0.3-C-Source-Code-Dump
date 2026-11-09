using UnityEngine;

namespace Org.BouncyCastle.Utilities.Date
{
    public class DateTimeUtilities
    {
        // Fields
        public static readonly System.DateTime UnixEpoch;
        
        // Methods
        private DateTimeUtilities()
        {
        
        }
        public static long DateTimeToUnixMs(System.DateTime dateTime)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((655765240 & 2147483648) == 0)
            {
                    val_6 = null;
                val_6 = null;
                System.DateTime val_5 = Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch;
                long val_2 = val_5.Ticks;
                val_5 = dateTime.dateData.Ticks - val_2;
                val_2 = (val_5 >> 11) + (val_5 >> 63);
                return (long)val_2;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "DateTime value may not be before the epoch", paramName:  "dateTime");
        }
        public static System.DateTime UnixMsToDateTime(long unixMs)
        {
            null = null;
            long val_2 = Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch.Ticks + (unixMs * 10000);
            return 0;
        }
        public static long CurrentUnixMs()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(dateTime:  new System.DateTime() {dateData = val_1.dateData});
        }
        private static DateTimeUtilities()
        {
            Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch = 0;
        }
    
    }

}
