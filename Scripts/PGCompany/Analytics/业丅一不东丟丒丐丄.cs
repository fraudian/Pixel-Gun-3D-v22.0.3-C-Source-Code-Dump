using UnityEngine;

namespace PGCompany.Analytics
{
    internal sealed class 业丅一不东丟丒丐丄
    {
        // Fields
        private static PGCompany.Analytics.业丅一不东丟丒丐丄 世丒丞七专三与万丕;
        
        // Properties
        internal static PGCompany.Analytics.业丅一不东丟丒丐丄 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        private 业丅一不东丟丒丐丄()
        {
        
        }
        internal static PGCompany.Analytics.业丅一不东丟丒丐丄 丑七不且上丗丁一世()
        {
            if(PGCompany.Analytics.业丅一不东丟丒丐丄.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Analytics.业丅一不东丟丒丐丄 val_1 = PGCompany.Analytics.业丅一不东丟丒丐丄.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "Instance");
            PGCompany.Analytics.业丅一不东丟丒丐丄.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(PGCompany.Analytics.业丅一不东丟丒丐丄.世丒丞七专三与万丕 != null)
            {
                    return;
            }
            
            PGCompany.Analytics.业丅一不东丟丒丐丄.世丒丞七专三与万丕 = PGCompany.Analytics.业丅一不东丟丒丐丄.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "EnsureInitialized");
        }
        private static PGCompany.Analytics.业丅一不东丟丒丐丄 东丝七业丄丑丒世七(string 与丗丆丏丙丟与丒业 = "")
        {
            if(PGCompany.Analytics.业丅一不东丟丒丐丄.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AppsFlyerHelper.Create] caller: "("[AppsFlyerHelper.Create] caller: ") + 与丗丆丏丙丟与丒业);
            }
            
            PGCompany.下丟业丁且丘下丂一.丑七不且上丗丁一世().万一丝一与丏丕丌丐(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  0, method:  static System.Void PGCompany.Analytics.业丅一不东丟丒丐丄::丙业世丌丞世且丛上(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            return (PGCompany.Analytics.业丅一不东丟丒丐丄)new PGCompany.Analytics.业丅一不东丟丒丐丄();
        }
        private static void 丙业世丌丞世且丛上(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            string val_2 = 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌().ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            string val_5 = 丗丛不丁丑专专丂且.东丐三一业与丘丂丕().ToString();
            string val_8 = Progress.七七世万专丕丁上业.丙丐业丈不与丁丈丆().与且丈三不丁丗丞专().ToString();
            if(PGCompany.Analytics.业丅一不东丟丒丐丄.世丈且业丆丑丏丐一() != false)
            {
                    string[] val_10 = new string[6];
                val_10[0] = "[AppsFlyerHelper.OnMatchCompleted] mode: ";
                val_10[1] = val_2;
                val_10[2] = ", isWinner: ";
                val_10[3] = val_5;
                val_10[4] = ", count: ";
                val_10[5] = val_8;
                UnityEngine.Debug.Log(message:  +val_10);
            }
            
            PGCompany.七丑一上且三世丝三<K, V> val_13 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
            val_13.set_Item(key:  "mode", value:  val_2);
            val_13.set_Item(key:  "isWinner", value:  val_5);
            Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "fightend" + val_8, 丛东不丒丏丈丄且丕:  val_13);
            if((PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
        
        }
    
    }

}
