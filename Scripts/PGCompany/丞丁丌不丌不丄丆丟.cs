using UnityEngine;

namespace PGCompany
{
    internal static class 丞丁丌不丌不丄丆丟
    {
        // Fields
        private static System.Action<PGCompany.EggIncubatorProgress, int> 且丏丘丁世一丏与丛;
        internal const string 且丌丁丌丁不丕上丌 = "Ads.HatchSpeedupLastImpression-";
        private static readonly string[] 不丗东且丂丄万丂丁;
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        
        // Methods
        internal static void 专丐世三丁丗丌丙丛(System.Action<PGCompany.EggIncubatorProgress, int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  PGCompany.丞丁丌不丌不丄丆丟.且丌丁丌丁不丕上丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丘丛丆丏丅万丗上丏(System.Action<PGCompany.EggIncubatorProgress, int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  PGCompany.丞丁丌不丌不丄丆丟.且丌丁丌丁不丕上丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal static string 一专丑上三丑且丑丝()
        {
            return "Ads.HatchSpeedupLastImpression-"("Ads.HatchSpeedupLastImpression-") + PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
        }
        internal static bool 上一万丟丏七与东丑(out int 丞世不丒下上上丝丑, out System.DateTime 东丆丒东不丕丑万丂)
        {
            return PGCompany.丞丁丌不丌不丄丆丟.上一万丟丏七与东丑(下上丐丆丝丟丝丒不:  PGCompany.丞丁丌不丌不丄丆丟.一专丑上三丑且丑丝(), 丞世不丒下上上丝丑: out  1152921553939556032, 东丆丒东不丕丑万丂: out  new System.DateTime() {dateData = 东丆丒东不丕丑万丂.dateData});
        }
        internal static void 下七丂不丄丅丁丐丟(System.DateTime 东丆丒东不丕丑万丂, PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙, int 丝丘与且七丏万丅且)
        {
            string val_11;
            var val_12;
            string val_1 = PGCompany.丞丁丌不丌不丄丆丟.一专丑上三丑且丑丝();
            System.DateTime val_2 = 东丆丒东不丕丑万丂.dateData.ToUniversalTime();
            if((PGCompany.丞丁丌不丌不丄丆丟.上一万丟丏七与东丑(下上丐丆丝丟丝丒不:  val_1, 丞世不丒下上上丝丑: out  0, 东丆丒东不丕丑万丂: out  new System.DateTime())) == false)
            {
                goto label_4;
            }
            
            System.DateTime val_5 = 0.Date;
            System.DateTime val_6 = 东丆丒东不丕丑万丂.dateData.Date;
            if((val_5.dateData.Equals(value:  new System.DateTime() {dateData = val_6.dateData})) == false)
            {
                goto label_4;
            }
            
            val_11 = 1.ToString(provider:  PGCompany.丞丁丌不丌不丄丆丟.丙专丝世不业下丂丈());
            goto label_7;
            label_4:
            val_11 = "0";
            label_7:
            val_12 = null;
            val_12 = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_1, 下下丏一丙不丘丌丞:  val_11 + PGCompany.丞丁丌不丌不丄丆丟.不丗东且丂丄万丂丁 + 32(PGCompany.丞丁丌不丌不丄丆丟.不丗东且丂丄万丂丁 + 32) + val_5.dateData);
            UnityEngine.PlayerPrefs.Save();
            if(PGCompany.丞丁丌不丌不丄丆丟.且丌丁丌丁不丕上丌 == null)
            {
                    return;
            }
            
            PGCompany.丞丁丌不丌不丄丆丟.且丌丁丌丁不丕上丌.Invoke(arg1:  三万万丒丏丒不丐丙, arg2:  丝丘与且七丏万丅且);
        }
        internal static bool 下丘丘丏专丏三丂丞(out string 丏丞专丏业丗丝七丝)
        {
            var val_18;
            var val_19;
            int val_9 = 0;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_1;
            }
            
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  "hatchSpeedup", 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  string val_7 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_5;
            }
            
            if((PGCompany.丞丁丌不丌不丄丆丟.上一万丟丏七与东丑(丞世不丒下上上丝丑: out  val_9, 东丆丒东不丕丑万丂: out  new System.DateTime())) == false)
            {
                goto label_25;
            }
            
            System.DateTime val_11 = 0.Date;
            System.DateTime val_12 = 0.Date;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_11.dateData}, t2:  new System.DateTime() {dateData = val_12.dateData})) == false)
            {
                goto label_11;
            }
            
            label_25:
            val_18 = 1;
            return (bool)val_18;
            label_1:
            label_28:
            val_18 = 0;
            丏丞专丏业丗丝七丝 = "TryGetServerUniversalTime: false";
            return (bool)val_18;
            label_5:
            val_18 = 0;
            return (bool)val_18;
            label_11:
            System.DateTime val_14 = 0.Date;
            System.DateTime val_15 = 0.Date;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_14.dateData}, t2:  new System.DateTime() {dateData = val_15.dateData})) == false)
            {
                goto label_18;
            }
            
            goto label_28;
            label_18:
            if((2088311176 & 1) != 0)
            {
                    int val_17 = 4194311.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_19 = -2147483648;
            }
            
            var val_18 = val_9;
            val_18 = val_18 + 1;
            if(val_18 < val_19)
            {
                goto label_25;
            }
            
            goto label_28;
        }
        private static bool 上一万丟丏七与东丑(string 下上丐丆丝丟丝丒不, out int 丞世不丒下上上丝丑, out System.DateTime 东丆丒东不丕丑万丂)
        {
            string val_10;
            var val_11;
            var val_12;
            val_10 = 下上丐丆丝丟丝丒不;
            丞世不丒下上上丝丑 = -2147483648;
            东丆丒东不丕丑万丂.dateData = 0;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_10)) != false)
            {
                    string val_2 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_10);
                val_10 = val_2;
                if((System.String.IsNullOrWhiteSpace(value:  val_2)) != true)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = val_10.Split(separator:  PGCompany.丞丁丌不丌不丄丆丟.不丗东且丂丄万丂丁, count:  2, options:  1);
                if(val_4.Length >= 2)
            {
                    if((System.Int32.TryParse(s:  val_10[0], result: out  1152921553940032144)) != false)
            {
                    val_10 = PGCompany.丞丁丌不丌不丄丆丟.丙专丝世不业下丂丈();
                val_12 = System.DateTime.TryParse(s:  val_10[1], provider:  val_10, styles:  16, result: out  new System.DateTime() {dateData = 东丆丒东不丕丑万丂.dateData});
                return (bool)val_12;
            }
            
            }
            
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        private static bool 丁丂专丝丑丗丅业丑(string 业与丑上丒丐且丕丂, out string 丏丞专丏业丗丝七丝)
        {
            丏丞专丏业丗丝七丝 = 业与丑上丒丐且丕丂;
            return false;
        }
        private static 丞丁丌不丌不丄丆丟()
        {
            string[] val_1 = new string[1];
            val_1[0] = ",";
            PGCompany.丞丁丌不丌不丄丆丟.不丗东且丂丄万丂丁 = val_1;
        }
    
    }

}
