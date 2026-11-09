using UnityEngine;

namespace PGCompany.Messaging
{
    internal static class 上丒专丆世一丅丅一
    {
        // Fields
        private const string 下丞且丐丒七世丗丑 = "Messaging.TokenMetadata-";
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        
        // Methods
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private static string 与业丄万不丝不丗丗(string 丞丅上丏丂且下丅与)
        {
            return "Messaging.TokenMetadata-"("Messaging.TokenMetadata-") + 丞丅上丏丂且下丅与;
        }
        internal static bool 东丕丘东丄下丗丟丅(string 丄丒且丙三丆丟与丏, string 丌丈不丄丝七丕万专, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, out string 丁丂丕与丁丒丕丟丞)
        {
            PGCompany.Messaging.上丙且丙丂上丁丕下 val_7;
            PGCompany.Messaging.上丙且丙丂上丁丕下 val_3 = 0;
            if((PGCompany.Messaging.上丙且丙丂上丁丕下.东一万丈丘业丂丂丑(丏丛与丅丛丌万专丌:  UnityEngine.PlayerPrefs.GetString(key:  PGCompany.Messaging.上丒专丆世一丅丅一.与业丄万不丝不丗丗(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏), defaultValue:  System.String.alignConst), 下上不丄丕丙万丞丌: out  val_3)) != false)
            {
                    val_7 = val_3;
                bool val_6 = PGCompany.Messaging.上丒专丆世一丅丅一.丆丅丝上丌七丒三丅(丘专专三丒丝上且丄:  val_7, 丌丈不丄丝七丕万专:  丌丈不丄丝七丕万专, 一丏一世丘丐丁丄丟:  new System.DateTime() {dateData = 一丏一世丘丐丁丄丟.dateData}, 丞丞丐丝丝丏丐丛丞:  丞丞丐丝丝丏丐丛丞, 三世东丅丁世且专不:  三世东丅丁世且专不, 丁丂丕与丁丒丕丟丞: out  string val_5 = 丁丂丕与丁丒丕丟丞);
            }
            else
            {
                    val_7 = 0;
                丁丂丕与丁丒丕丟丞 = "TryParse";
            }
            
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        internal static bool 东丕丘东丄下丗丟丅(PGCompany.Messaging.上丙且丙丂上丁丕下 丘专专三丒丝上且丄, string 丌丈不丄丝七丕万专, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, out string 丁丂丕与丁丒丕丟丞)
        {
            if(丘专专三丒丝上且丄 != null)
            {
                    return PGCompany.Messaging.上丒专丆世一丅丅一.丆丅丝上丌七丒三丅(丘专专三丒丝上且丄:  丘专专三丒丝上且丄, 丌丈不丄丝七丕万专:  丌丈不丄丝七丕万专, 一丏一世丘丐丁丄丟:  new System.DateTime() {dateData = 一丏一世丘丐丁丄丟.dateData}, 丞丞丐丝丝丏丐丛丞:  丞丞丐丝丝丏丐丛丞, 三世东丅丁世且专不:  三世东丅丁世且专不, 丁丂丕与丁丒丕丟丞: out  string val_1 = 丁丂丕与丁丒丕丟丞);
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "tokenMetadata");
        }
        private static bool 丆丅丝上丌七丒三丅(PGCompany.Messaging.上丙且丙丂上丁丕下 丘专专三丒丝上且丄, string 丌丈不丄丝七丕万专, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, out string 丁丂丕与丁丒丕丟丞)
        {
            string val_15;
            string val_16;
            string val_17;
            string val_18;
            string val_19;
            var val_20;
            var val_21;
            string val_22;
            val_15 = 丞丞丐丝丝丏丐丛丞;
            System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 一丏一世丘丐丁丄丟.dateData}, d2:  new System.DateTime() {dateData = 丘专专三丒丝上且丄.<丞丌三丌丝一丕丌三>k__BackingField});
            System.TimeSpan val_2 = System.TimeSpan.FromDays(value:  2);
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_1._ticks}, t2:  new System.TimeSpan() {_ticks = val_2._ticks})) == false)
            {
                goto label_6;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_9;
            }
            
            System.Globalization.CultureInfo val_5 = PGCompany.Messaging.上丒专丆世一丅丅一.丙专丝世不业下丂丈();
            val_15;
            System.Globalization.CultureInfo val_6 = PGCompany.Messaging.上丒专丆世一丅丅一.丙专丝世不业下丂丈();
            label_28:
            val_16;
            val_17 = ", old: ";
            val_18 = "timestamp: ";
            label_23:
            val_19 = val_15;
            goto label_10;
            label_6:
            if((System.String.Equals(a:  丌丈不丄丝七丕万专, b:  丘专专三丒丝上且丄.<丏丗丙丄丛丌下丌丒>k__BackingField, comparisonType:  4)) == false)
            {
                goto label_11;
            }
            
            if((System.String.Equals(a:  val_15, b:  丘专专三丒丝上且丄.<丆一丙世丘三丅丙丆>k__BackingField, comparisonType:  5)) == false)
            {
                goto label_12;
            }
            
            if((丘专专三丒丝上且丄.<丂丗丕下丏不丗丂丏>k__BackingField) != 三世东丅丁世且专不)
            {
                goto label_13;
            }
            
            val_20 = 0;
            val_21 = 1;
            goto label_14;
            label_9:
            val_22 = "timestamp";
            goto label_29;
            label_11:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_18;
            }
            
            val_16 = 丘专专三丒丝上且丄.<丏丗丙丄丛丌下丌丒>k__BackingField;
            val_19 = 丌丈不丄丝七丕万专;
            val_18 = "version: ";
            val_17 = ", old: ";
            label_10:
            string val_10 = val_18 + val_19 + val_17 + val_16;
            goto label_19;
            label_12:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_22;
            }
            
            goto label_23;
            label_18:
            val_22 = "version";
            goto label_29;
            label_13:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_27;
            }
            
            string val_13 = 三世东丅丁世且专不.ToString();
            string val_14 = 丘专专三丒丝上且丄.<丂丗丕下丏不丗丂丏>k__BackingField.ToString();
            goto label_28;
            label_22:
            val_22 = "language";
            goto label_29;
            label_27:
            val_22 = "timeZone";
            label_29:
            label_19:
            val_21 = 0;
            label_14:
            丁丂丕与丁丒丕丟丞 = val_22;
            return (bool)val_21;
        }
        internal static bool 丂丐且业丁丑丆与丆(out string 不丒三业下丑不丞业)
        {
            var val_6;
            string val_1 = 0;
            不丒三业下丑不丞业 = 0;
            if((PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_1)) != false)
            {
                    if((PGCompany.Messaging.上丒专丆世一丅丅一.丂东丐丁丅丙丐丙丛(丄丒且丙三丆丟与丏:  val_1, 丘专专三丒丝上且丄: out  0)) != false)
            {
                    不丒三业下丑不丞业 = 11993091;
                var val_5 = (11993091 != 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        internal static bool 丂东丐丁丅丙丐丙丛(string 丄丒且丙三丆丟与丏, out PGCompany.Messaging.上丙且丙丂上丁丕下 丘专专三丒丝上且丄)
        {
            return PGCompany.Messaging.上丙且丙丂上丁丕下.东一万丈丘业丂丂丑(丏丛与丅丛丌万专丌:  UnityEngine.PlayerPrefs.GetString(key:  PGCompany.Messaging.上丒专丆世一丅丅一.与业丄万不丝不丗丗(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏), defaultValue:  null), 下上不丄丕丙万丞丌: out  PGCompany.Messaging.上丙且丙丂上丁丕下 val_3 = 丘专专三丒丝上且丄);
        }
        internal static void 东与丒丞丞丈七丆丘(string 丄丒且丙三丆丟与丏, PGCompany.Messaging.上丙且丙丂上丁丕下 丘专专三丒丝上且丄)
        {
            string val_2;
            if(丘专专三丒丝上且丄 != null)
            {
                    val_2 = 丘专专三丒丝上且丄;
            }
            else
            {
                    val_2 = 0;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  PGCompany.Messaging.上丒专丆世一丅丅一.与业丄万不丝不丗丗(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏), value:  val_2);
            UnityEngine.PlayerPrefs.Save();
        }
        internal static void 丙丗丂丑丘丞业丙世(string 丄丒且丙三丆丟与丏)
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  PGCompany.Messaging.上丒专丆世一丅丅一.与业丄万不丝不丗丗(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏));
            UnityEngine.PlayerPrefs.Save();
        }
    
    }

}
