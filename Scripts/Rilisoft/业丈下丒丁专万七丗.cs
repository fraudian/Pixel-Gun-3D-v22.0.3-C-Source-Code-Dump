using UnityEngine;

namespace Rilisoft
{
    internal static class 业丈下丒丁专万七丗
    {
        // Fields
        internal const string 丅丁丑丘东丗丑丄丙 = "recommend-duel";
        private const string 与丌丞丝下上业丁丑 = "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME";
        private const string 丆丛七东且丕丌丛业 = "DuelsRecommender.DUEL_MODE_WAS_SELECTED";
        private static bool 上丌丄丂丟丟一下丕;
        private static int 丒丘世世不丂下七上;
        
        // Methods
        internal static void 丝上上丞丄丅丘丙专()
        {
            string val_5 = Rilisoft.业丈下丒丁专万七丗.世丟七丞丙东专丌丅();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = Rilisoft.业丈下丒丁专万七丗.世丟七丞丙东专丌丅())) == false)
            {
                    return;
            }
            
            System.DateTime val_3 = System.DateTime.UtcNow;
            System.Globalization.CultureInfo val_4 = System.Globalization.CultureInfo.InvariantCulture;
            val_5;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME", 下下丏一丙不丘丌丞:  val_3.dateData);
        }
        internal static bool 丆下丗丗丁专丗丄丛(bool 丛专下丞丒丛下下与, bool 丈丑业与丆下丝丝丐)
        {
            var val_18;
            System.IFormatProvider val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_19 = 丛专下丞丒丛下下与;
            val_20 = null;
            if(Rilisoft.业丈下丒丁专万七丗.七丌世下丈七下丑不() == true)
            {
                goto label_6;
            }
            
            val_21 = null;
            if(Rilisoft.业丈下丒丁专万七丗.丐七七专丁业丘丂一() == false)
            {
                goto label_6;
            }
            
            val_18 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_18.丏世丞丕丂丒七上业() == null)
            {
                    return (bool)val_22;
            }
            
            if(丈丑业与丆下丝丝丐 != false)
            {
                    val_23 = null;
                val_18 = (~Rilisoft.业丈下丒丁专万七丗.丘丒丟丝丌丈东丒丒()) & 1;
            }
            else
            {
                    val_18 = 1;
            }
            
            string val_6 = Rilisoft.业丈下丒丁专万七丗.世丟七丞丙东专丌丅();
            if((val_19 != false) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != true))
            {
                    val_19 = System.Globalization.CultureInfo.InvariantCulture;
                if((System.DateTime.TryParse(s:  val_6, provider:  val_19, styles:  0, result: out  new System.DateTime())) != false)
            {
                    System.DateTime val_10 = System.DateTime.UtcNow;
                if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10.dateData}, t2:  new System.DateTime())) != false)
            {
                    System.TimeSpan val_12 = val_10.dateData.Subtract(value:  new System.DateTime());
                if(val_12._ticks.TotalDays >= 2)
            {
                goto label_31;
            }
            
            }
            
            }
            
            }
            
            label_31:
            var val_14 = (1 != val_18) ? 1 : 0;
            return (bool)val_22;
            label_6:
            val_22 = 0;
            return (bool)val_22;
        }
        private static string 世丟七丞丙东专丌丅()
        {
            int val_3;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME")) == true)
            {
                    return (string)丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME");
            }
            
            val_3 = System.String.alignConst;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME", 下下丏一丙不丘丌丞:  val_3);
            return (string)丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "DuelsRecommender.FIRST_SHOW_PLASHKA_TIME");
        }
        private static bool 丘丒丟丝丌丈东丒丒()
        {
            Rilisoft.业丈下丒丁专万七丗 val_8;
            var val_9;
            var val_10;
            var val_11;
            bool val_12;
            val_9 = null;
            val_9 = null;
            if(Rilisoft.业丈下丒丁专万七丗.上丌丄丂丟丟一下丕 != false)
            {
                    val_10 = 1;
                return (bool)(val_12 != 0) ? 1 : 0;
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "DuelsRecommender.DUEL_MODE_WAS_SELECTED")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DuelsRecommender.DUEL_MODE_WAS_SELECTED", 下下丏一丙不丘丌丞:  0.ToString());
            }
            
            val_8 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "DuelsRecommender.DUEL_MODE_WAS_SELECTED");
            if((val_8.Equals(value:  1.ToString())) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = true;
                Rilisoft.业丈下丒丁专万七丗.上丌丄丂丟丟一下丕 = val_12;
                return (bool)(val_12 != 0) ? 1 : 0;
            }
            
            val_12 = 0;
            return (bool)(val_12 != 0) ? 1 : 0;
        }
        internal static void 三丅不丂丒丂且业丏()
        {
            null = null;
            if(Rilisoft.业丈下丒丁专万七丗.上丌丄丂丟丟一下丕 == true)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "DuelsRecommender.DUEL_MODE_WAS_SELECTED", 下下丏一丙不丘丌丞:  1.ToString());
        }
        private static bool 七丌世下丈七下丑不()
        {
            return (bool)((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "DuelPlayedBet", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1) ? 1 : 0;
        }
        private static bool 丐七七专丁业丘丂一()
        {
            bool val_2 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  8);
            val_2 = val_2 ^ 1;
            return (bool)val_2;
        }
        private static 业丈下丒丁专万七丗()
        {
            Rilisoft.业丈下丒丁专万七丗.上丌丄丂丟丟一下丕 = false;
            Rilisoft.业丈下丒丁专万七丗.丒丘世世不丂下七上 = 0;
        }
    
    }

}
