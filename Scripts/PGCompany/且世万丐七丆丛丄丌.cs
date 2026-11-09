using UnityEngine;

namespace PGCompany
{
    internal static class 且世万丐七丆丛丄丌
    {
        // Methods
        internal static float 丐丞丂丒丏专不丒业()
        {
            System.TimeSpan val_2 = System.TimeSpan.FromMilliseconds(value:  (double)System.Environment.TickCount);
            return (float)(float)val_2._ticks.TotalSeconds;
        }
        internal static bool 丗上丌与三丟东东世(out System.DateTime 东且丁丆丛丁丏丘且)
        {
            var val_3;
            long val_1 = FriendsController.丝丗专上三不丄丑丑();
            if(val_1 > 0)
            {
                    System.DateTimeOffset val_2 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  val_1);
                东且丁丆丛丁丏丘且.dateData = val_2.m_dateTime.dateData;
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            东且丁丆丛丁丏丘且.dateData = 0;
            return (bool)val_3;
        }
        internal static System.DateTime 丒丌丟业丂丌丈丕丒()
        {
            var val_4;
            long val_1 = FriendsController.丝丗专上三不丄丑丑();
            if(val_1 > 0)
            {
                    System.DateTimeOffset val_2 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  val_1);
                val_4;
                return (System.DateTime)val_3.dateData;
            }
            
            System.DateTime val_3 = System.DateTime.UtcNow;
            return (System.DateTime)val_3.dateData;
        }
    
    }

}
