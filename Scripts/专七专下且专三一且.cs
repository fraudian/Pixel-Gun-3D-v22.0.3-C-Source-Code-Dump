using UnityEngine;
public static class 专七专下且专三一且
{
    // Fields
    private const int 丞丈丕且不东世丈丛 = 86400;
    private static readonly System.Text.StringBuilder 丕丒东丅东业丅且丟;
    private static System.Collections.Generic.Dictionary<string, string> 丅丄世不丞上与上丞;
    internal static readonly UnityEngine.Color 下丑丐丞下丐专丗丙;
    
    // Properties
    internal static System.DateTime 丟丑丗专不丒世丄丏 { get; }
    internal static long 一东丘丟丒丄三丑丂 { get; }
    
    // Methods
    internal static System.DateTime 丐世丈专与东丏丛丑()
    {
        return 0;
    }
    internal static long 上且一丈丐三丄一丆()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
        return (long)(long)val_2._ticks.TotalSeconds;
    }
    internal static System.DateTime 丆丁丑东专与丁七丞(int 丌丕三丌丈且丞且丆)
    {
        return 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (long)丌丕三丌丈且丞且丆);
    }
    internal static System.DateTime 丆丁丑东专与丁七丞(long 丌丕三丌丈且丞且丆)
    {
        System.DateTime val_1 = 0.AddSeconds(value:  (double)丌丕三丌丈且丞且丆);
        return (System.DateTime)val_1.dateData;
    }
    internal static long 丅丛下丐东专万七丑(System.DateTime 七三丗丙丏丘丘丅上)
    {
        System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 七三丗丙丏丘丘丅上.dateData}, d2:  new System.DateTime());
        return (long)(long)val_1._ticks.TotalSeconds;
    }
    internal static bool 丑下丟上丂丏丘丒丄(string 专丄三与丙丛上万丄, out System.DateTime 丘丗丝丄东万丌丟丙)
    {
        return System.DateTime.TryParse(s:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  专丄三与丙丛上万丄), result: out  new System.DateTime() {dateData = 丘丗丝丄东万丌丟丙.dateData});
    }
    internal static System.DateTime 下上且七专丁丛与丄(string 业丄万丁丒上丛东丛)
    {
        if((System.DateTime.TryParseExact(s:  业丄万丁丒上丛东丛, format:  "yyyy-MM-dd\'T\'HH:mm:ss.fff\'Z\'", provider:  System.Globalization.CultureInfo.InvariantCulture, style:  80, result: out  new System.DateTime())) == true)
        {
                return (System.DateTime)val_5.dateData;
        }
        
        System.DateTime val_4 = System.Convert.ToDateTime(value:  业丄万丁丒上丛东丛, provider:  System.Globalization.CultureInfo.InvariantCulture);
        System.DateTime val_5 = val_4.dateData.ToUniversalTime();
        return (System.DateTime)val_5.dateData;
    }
    internal static string 丞丄一丌丟业世丏七(System.DateTime 且丆丝世上丐上不万, string 丞丞丐丝丝丏丐丛丞)
    {
        string val_3;
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        var val_9;
        val_3 = 丞丞丐丝丝丏丐丛丞;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if((专七专下且专三一且.丅丄世不丞上与上丞.ContainsKey(key:  val_3)) != false)
        {
                val_6 = null;
            val_7 = val_3;
            val_8 = public System.String System.Collections.Generic.Dictionary<System.String, System.String>::get_Item(System.String key);
        }
        else
        {
                val_9 = null;
            val_3 = 专七专下且专三一且.丅丄世不丞上与上丞;
            val_7 = "English";
            val_8 = public System.String System.Collections.Generic.Dictionary<System.String, System.String>::get_Item(System.String key);
        }
        
        string val_2 = val_3.Item[val_7];
        return 587771304;
    }
    internal static string 丒下丒丄且且丂丟丘(System.TimeSpan 丄专万丏丘上丑与一, bool 丒且下丘丅丘丛丆且, UILabel 七丐丞丑丑丕世丙七, UnityEngine.TextMesh 专丘一丕专业七专丏)
    {
        var val_5;
        var val_6;
        丒且下丘丅丘丛丆且 = 丒且下丘丅丘丛丆且;
        if(七丐丞丑丑丕世丙七 != 0)
        {
                val_5 = null;
            val_5 = null;
            专七专下且专三一且.丏上丟万丆七东上丒(七丐丞丑丑丕世丙七:  七丐丞丑丑丕世丙七, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = 丄专万丏丘上丑与一._ticks}, 丟丛丝丑专丏丐且不:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            return (string)专七专下且专三一且.丟丌三丛丒业万丙丆(丙丒七丄上与丏丙丙:  new System.TimeSpan() {_ticks = 丄专万丏丘上丑与一._ticks}, 丒且下丘丅丘丛丆且:  丒且下丘丅丘丛丆且);
        }
        
        if(专丘一丕专业七专丏 == 0)
        {
                return (string)专七专下且专三一且.丟丌三丛丒业万丙丆(丙丒七丄上与丏丙丙:  new System.TimeSpan() {_ticks = 丄专万丏丘上丑与一._ticks}, 丒且下丘丅丘丛丆且:  丒且下丘丅丘丛丆且);
        }
        
        val_6 = null;
        val_6 = null;
        专七专下且专三一且.丏上丟万丆七东上丒(丗上丘下三丛丈三丏:  专丘一丕专业七专丏, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = 丄专万丏丘上丑与一._ticks}, 丟丛丝丑专丏丐且不:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        return (string)专七专下且专三一且.丟丌三丛丒业万丙丆(丙丒七丄上与丏丙丙:  new System.TimeSpan() {_ticks = 丄专万丏丘上丑与一._ticks}, 丒且下丘丅丘丛丆且:  丒且下丘丅丘丛丆且);
    }
    internal static string 丒下丒丄且且丂丟丘(int 丆丐七丅丆丗丛上与, bool 丒且下丘丅丘丛丆且, UILabel 七丐丞丑丑丕世丙七, UnityEngine.TextMesh 专丘一丕专业七专丏)
    {
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)丆丐七丅丆丗丛上与);
        丒且下丘丅丘丛丆且 = 丒且下丘丅丘丛丆且;
        return 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_1._ticks}, 丒且下丘丅丘丛丆且:  丒且下丘丅丘丛丆且, 七丐丞丑丑丕世丙七:  七丐丞丑丑丕世丙七, 专丘一丕专业七专丏:  专丘一丕专业七专丏);
    }
    internal static void 丏上丟万丆七东上丒(UILabel 七丐丞丑丑丕世丙七, System.TimeSpan 丄专万丏丘上丑与一, System.Nullable<UnityEngine.Color> 丟丛丝丑专丏丐且不)
    {
        if(七丐丞丑丑丕世丙七 == 0)
        {
                return;
        }
        
        if(丟丛丝丑专丏丐且不.HasValue.HasValue == false)
        {
                return;
        }
        
        double val_3 = 丄专万丏丘上丑与一._ticks.TotalSeconds;
        if(val_3 > 10)
        {
                return;
        }
        
        七丐丞丑丑丕世丙七.color = new UnityEngine.Color() {r = val_3, g = 10, b = V2.16B, a = V3.16B};
    }
    internal static void 丏上丟万丆七东上丒(UnityEngine.TextMesh 丗上丘下三丛丈三丏, System.TimeSpan 丄专万丏丘上丑与一, System.Nullable<UnityEngine.Color> 丟丛丝丑专丏丐且不)
    {
        if(丗上丘下三丛丈三丏 == 0)
        {
                return;
        }
        
        if(丟丛丝丑专丏丐且不.HasValue.HasValue == false)
        {
                return;
        }
        
        double val_3 = 丄专万丏丘上丑与一._ticks.TotalSeconds;
        if(val_3 > 10)
        {
                return;
        }
        
        丗上丘下三丛丈三丏.color = new UnityEngine.Color() {r = val_3, g = 10, b = V2.16B, a = V3.16B};
    }
    private static bool 下下丒丅丄不与业万(System.TimeSpan 丄专万丏丘上丑与一)
    {
        return (bool)(丄专万丏丘上丑与一._ticks.TotalSeconds <= 10) ? 1 : 0;
    }
    private static string 丟丌三丛丒业万丙丆(System.TimeSpan 丙丒七丄上与丏丙丙, bool 丒且下丘丅丘丛丆且)
    {
        var val_42;
        var val_43;
        object val_44;
        var val_45;
        object val_46;
        object val_47;
        var val_48;
        var val_49;
        System.Text.StringBuilder val_50;
        object val_51;
        string val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_42 = null;
        val_42 = null;
        System.Text.StringBuilder val_1 = 专七专下且专三一且.丕丒东丅东业丅且丟.Clear();
        if(丙丒七丄上与丏丙丙._ticks.TotalHours <= 36)
        {
            goto label_4;
        }
        
        val_43 = null;
        val_43 = null;
        int val_3 = 丙丒七丄上与丏丙丙._ticks.Days;
        var val_42 = 0;
        val_42 = val_42 + (int)丙丒七丄上与丏丙丙._ticks.TotalSeconds;
        val_42 = (val_42 >> 16) + (val_42 >> 31);
        val_42 = (int)丙丒七丄上与丏丙丙._ticks.TotalSeconds - (val_42 * 86400);
        val_44 = (val_42 != 0) ? (val_3 + 1) : (val_3).ToString();
        val_45 = "{0}{1}";
        val_46 = val_44;
        val_47 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7282");
        goto label_10;
        label_4:
        if(丙丒七丄上与丏丙丙._ticks.Days < 1)
        {
            goto label_11;
        }
        
        val_48 = null;
        val_48 = null;
        val_44 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7282");
        System.Text.StringBuilder val_13 = 专七专下且专三一且.丕丒东丅东业丅且丟.AppendFormat(format:  "{0}{1}", arg0:  丙丒七丄上与丏丙丙._ticks.Days.ToString(), arg1:  val_44);
        val_45 = 0;
        if(丙丒七丄上与丏丙丙._ticks.Hours < 1)
        {
            goto label_53;
        }
        
        val_49 = null;
        val_49 = null;
        val_50 = 专七专下且专三一且.丕丒东丅东业丅且丟;
        val_51 = 丙丒七丄上与丏丙丙._ticks.Hours.ToString();
        label_36:
        val_44 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7281");
        val_52 = " {0}{1}";
        goto label_23;
        label_11:
        if(丙丒七丄上与丏丙丙._ticks.Hours > 1)
        {
            goto label_24;
        }
        
        if(丙丒七丄上与丏丙丙._ticks.Hours < 1)
        {
            goto label_25;
        }
        
        val_53 = null;
        val_53 = null;
        val_44 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7281");
        System.Text.StringBuilder val_23 = 专七专下且专三一且.丕丒东丅东业丅且丟.AppendFormat(format:  "{0}{1}", arg0:  丙丒七丄上与丏丙丙._ticks.Hours.ToString(), arg1:  val_44);
        val_45 = 0;
        if(丙丒七丄上与丏丙丙._ticks.Minutes < 1)
        {
            goto label_53;
        }
        
        val_54 = null;
        val_54 = null;
        string val_26 = 丙丒七丄上与丏丙丙._ticks.Minutes.ToString();
        goto label_36;
        label_24:
        val_55 = null;
        val_55 = null;
        val_50 = 专七专下且专三一且.丕丒东丅东业丅且丟;
        val_51 = 丙丒七丄上与丏丙丙._ticks.Hours.ToString();
        label_63:
        val_44 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7281");
        val_52 = "{0}{1}";
        label_23:
        val_46 = val_51;
        val_47 = val_44;
        label_10:
        System.Text.StringBuilder val_30 = val_50.AppendFormat(format:  val_52, arg0:  val_46, arg1:  val_47);
        label_53:
        val_56 = null;
        val_56 = null;
        if(专七专下且专三一且.丕丒东丅东业丅且丟 != null)
        {
                return (string)专七专下且专三一且.丕丒东丅东业丅且丟;
        }
        
        return (string)专七专下且专三一且.丕丒东丅东业丅且丟;
        label_25:
        if(丙丒七丄上与丏丙丙._ticks.Minutes >= 10)
        {
            goto label_45;
        }
        
        if(丙丒七丄上与丏丙丙._ticks.Minutes >= 1)
        {
                val_57 = null;
            val_57 = null;
            System.Text.StringBuilder val_36 = 专七专下且专三一且.丕丒东丅东业丅且丟.AppendFormat(format:  "{0}{1} ", arg0:  丙丒七丄上与丏丙丙._ticks.Minutes.ToString(), arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7279"));
        }
        
        if(丒且下丘丅丘丛丆且 != true)
        {
                if(丙丒七丄上与丏丙丙._ticks.Seconds < 1)
        {
            goto label_53;
        }
        
        }
        
        val_58 = null;
        val_58 = null;
        string val_39 = 丙丒七丄上与丏丙丙._ticks.Seconds.ToString();
        goto label_63;
        label_45:
        val_59 = null;
        val_59 = null;
        string val_41 = 丙丒七丄上与丏丙丙._ticks.Minutes.ToString();
        goto label_63;
    }
    internal static long 丘东下下丒三丒丌丈()
    {
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_2 = val_1.dateData.AddDays(value:  1);
        System.TimeSpan val_4 = val_1.dateData.TimeOfDay;
        return (long)(丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_2.dateData})) - (long)val_4._ticks.TotalSeconds;
    }
    private static 专七专下且专三一且()
    {
        专七专下且专三一且.丕丒东丅东业丅且丟 = new System.Text.StringBuilder();
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_2 != null)
        {
                val_2.Add(key:  "English", value:  "dd-MM-yy");
        }
        else
        {
                val_2.Add(key:  "English", value:  "dd-MM-yy");
        }
        
        val_2.Add(key:  "Russian", value:  "dd.MM.yy");
        if(val_2 != null)
        {
                val_2.Add(key:  "German", value:  "dd.MM.yyyy");
        }
        else
        {
                val_2.Add(key:  "German", value:  "dd.MM.yyyy");
        }
        
        val_2.Add(key:  "Portuguese (brazil)", value:  "dd-MM-yyyy");
        if(val_2 != null)
        {
                val_2.Add(key:  "Chinese (chinese)", value:  "yyyy-MM-dd");
        }
        else
        {
                val_2.Add(key:  "Chinese (chinese)", value:  "yyyy-MM-dd");
        }
        
        val_2.Add(key:  "ChineseTraditional", value:  "yyyy-MM-dd");
        if(val_2 != null)
        {
                val_2.Add(key:  "Spanish", value:  "dd/MM/yy");
        }
        else
        {
                val_2.Add(key:  "Spanish", value:  "dd/MM/yy");
        }
        
        val_2.Add(key:  "Korean", value:  "yyyy.MM.dd");
        if(val_2 != null)
        {
                val_2.Add(key:  "French", value:  "dd.MM.yyyy");
        }
        else
        {
                val_2.Add(key:  "French", value:  "dd.MM.yyyy");
        }
        
        val_2.Add(key:  "Japanese", value:  "yyyy.MM.dd");
        专七专下且专三一且.丅丄世不丞上与上丞 = val_2;
        UnityEngine.Color val_3 = UnityEngine.Color.red;
        专七专下且专三一且.下丑丐丞下丐专丗丙 = val_3.r;
        专七专下且专三一且.丕丒东丅东业丅且丟.__il2cppRuntimeField_14 = val_3.g;
        专七专下且专三一且.丕丒东丅东业丅且丟.__il2cppRuntimeField_18 = val_3.b;
        专七专下且专三一且.丕丒东丅东业丅且丟.__il2cppRuntimeField_1C = val_3.a;
    }

}
