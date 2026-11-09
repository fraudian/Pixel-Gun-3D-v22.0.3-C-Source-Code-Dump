using UnityEngine;
public static class 上七丈七三七七且丛
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, string> 丒不丈上丗丆业世专;
    private static System.Collections.Generic.Dictionary<string, int> 且丈七丌且丙丌与不;
    private static System.Security.Cryptography.HashAlgorithm 不丕丙丑丅三专不一;
    private static System.Collections.Generic.Dictionary<string, System.Security.Cryptography.SymmetricAlgorithm> 丝丄丅丌丞且丁丂丐;
    private static int 一不丑七万万丁不丌;
    private static string 丁丑且丘与丒丗丂世;
    private static bool 与万一丆丂丘业丞与;
    private static bool 丛丝丂上下东万丞下;
    
    // Properties
    private static System.Security.Cryptography.HashAlgorithm 丏丏丕丛丟丛丄丒且 { get; }
    private static string 丁万丒丘丑丆丑丑丝 { get; }
    
    // Methods
    public static bool 丌丟三丘世下与丆丘(string 下上丐丆丝丟丝丒不)
    {
        return UnityEngine.PlayerPrefs.HasKey(key:  上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
    }
    public static void 丟下三不一丌三三丟(string 下上丐丆丝丟丝丒不)
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不));
    }
    public static void 丗丞丘一下丞万不丘()
    {
        UnityEngine.PlayerPrefs.DeleteAll();
    }
    public static void 丂且不业丂专丛丆东()
    {
        UnityEngine.PlayerPrefs.Save();
    }
    public static void 丂丟丝与上丌丆丅东(string 下上丐丆丝丟丝丒不, int 下下丏一丙不丘丌丞)
    {
        int val_6;
        var val_7;
        val_6 = 下下丏一丙不丘丌丞;
        string val_1 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        val_7 = null;
        if(上七丈七三七七且丛.丛丝丂上下东万丞下 != false)
        {
                int val_2 = 上七丈七三七七且丛.不专丂丈七丘丙丟一(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 世丂专且万丆七丛丙:  val_1);
            val_7 = null;
            int val_3 = val_2 & (val_2 << 1);
            val_3 = val_3 + val_6;
            val_6 = val_3 ^ val_2;
        }
        
        val_7 = null;
        if(上七丈七三七七且丛.与万一丆丂丘业丞与 != false)
        {
                val_6 = val_6.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  val_1, value:  上七丈七三七七且丛.东丈不且丁丞丙业业(丘万丝丁丁一下丁丘:  val_1, 一丐丗丁丞丆丅丟丄:  val_6));
            return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  val_1, value:  val_6);
    }
    public static void 丒且与丙丂丈丏七丁(string 下上丐丆丝丟丝丒不, long 下下丏一丙不丘丌丞)
    {
        上七丈七三七七且丛.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.ToString());
    }
    public static void 丞丅丁与丞丒丗下丟(string 下上丐丆丝丟丝丒不, string 下下丏一丙不丘丌丞)
    {
        var val_9;
        var val_10;
        string val_11;
        string val_12;
        string val_13;
        string val_1 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        val_9 = null;
        if(上七丈七三七七且丛.丛丝丂上下东万丞下 == false)
        {
            goto label_3;
        }
        
        int val_2 = 上七丈七三七七且丛.不专丂丈七丘丙丟一(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 世丂专且万丆七丛丙:  val_1);
        val_10 = 0;
        val_11 = "";
        goto label_6;
        label_9:
        int val_5 = (val_2 & (val_2 << 1)) + 下下丏一丙不丘丌丞.Chars[0];
        val_5 = val_5 ^ val_2;
        val_11 = val_11 + val_5;
        val_10 = 1;
        label_6:
        if(val_10 < 下下丏一丙不丘丌丞.Length)
        {
            goto label_9;
        }
        
        val_9 = null;
        goto label_10;
        label_3:
        val_11 = 下下丏一丙不丘丌丞;
        label_10:
        val_9 = null;
        if(上七丈七三七七且丛.与万一丆丂丘业丞与 != false)
        {
                val_12 = 上七丈七三七七且丛.东丈不且丁丞丙业业(丘万丝丁丁一下丁丘:  val_1, 一丐丗丁丞丆丅丟丄:  val_11);
            val_13 = val_1;
        }
        else
        {
                val_13 = val_1;
            val_12 = val_11;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  val_13, value:  val_12);
    }
    public static void 丝丕丘不丘东专一下(string 下上丐丆丝丟丝丒不, float 下下丏一丙不丘丌丞)
    {
        上七丈七三七七且丛.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.ToString());
    }
    public static int 与上万业专丘三丅万(string 下上丐丆丝丟丝丒不, int 专不三上丏专丄且丞 = 0)
    {
        var val_9;
        var val_10;
        string val_11;
        var val_12;
        val_9 = 专不三上丏专丄且丞;
        string val_1 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) == false)
        {
                return (int)val_9;
        }
        
        val_10 = null;
        val_10 = null;
        if(上七丈七三七七且丛.与万一丆丂丘业丞与 != false)
        {
                int val_4 = System.Int32.Parse(s:  上七丈七三七七且丛.丘丂丄丈丆七丁丘丈(丘万丝丁丁一下丁丘:  val_1));
        }
        else
        {
                val_11 = val_1;
        }
        
        val_9 = UnityEngine.PlayerPrefs.GetInt(key:  val_11);
        val_12 = null;
        val_12 = null;
        if(上七丈七三七七且丛.丛丝丂上下东万丞下 == false)
        {
                return (int)val_9;
        }
        
        int val_6 = 上七丈七三七七且丛.不专丂丈七丘丙丟一(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 世丂专且万丆七丛丙:  val_1);
        val_9 = val_6 ^ val_9 - (val_6 & (val_6 << 1));
        return (int)val_9;
    }
    public static long 丁东丝专丘丈东世专(string 下上丐丆丝丟丝丒不, long 专不三上丏专丄且丞 = 0)
    {
        return (long)System.Int64.Parse(s:  上七丈七三七七且丛.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 专不三上丏专丄且丞:  专不三上丏专丄且丞.ToString()));
    }
    public static string 丒丙丝丆丄丆丄且专(string 下上丐丆丝丟丝丒不, string 专不三上丏专丄且丞 = "")
    {
        var val_11;
        string val_12;
        var val_13;
        var val_15;
        string val_16;
        val_11 = 专不三上丏专丄且丞;
        string val_1 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        val_12 = val_1;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_1)) == false)
        {
                return (string)val_11;
        }
        
        val_13 = null;
        val_13 = null;
        if(上七丈七三七七且丛.与万一丆丂丘业丞与 != false)
        {
                string val_3 = 上七丈七三七七且丛.丘丂丄丈丆七丁丘丈(丘万丝丁丁一下丁丘:  val_12);
        }
        
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_12);
        val_15 = null;
        val_15 = null;
        if(上七丈七三七七且丛.丛丝丂上下东万丞下 == false)
        {
                return (string)val_11;
        }
        
        int val_5 = 上七丈七三七七且丛.不专丂丈七丘丙丟一(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 世丂专且万丆七丛丙:  val_12);
        val_12 = 0;
        val_16 = "";
        goto label_15;
        label_18:
        int val_8 = val_5 ^ val_11.Chars[0];
        val_8 = val_8 - (val_5 & (val_5 << 1));
        val_16 = val_16 + val_8;
        val_12 = 1;
        label_15:
        if(val_12 < val_11.Length)
        {
            goto label_18;
        }
        
        val_11 = val_16;
        return (string)val_11;
    }
    public static float 丗且丄丛丏丁万七丄(string 下上丐丆丝丟丝丒不, float 专不三上丏专丄且丞 = 0)
    {
        return (float)System.Single.Parse(s:  上七丈七三七七且丛.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 专不三上丏专丄且丞:  专不三上丏专丄且丞.ToString()));
    }
    private static string 东丈不且丁丞丙业业(string 丘万丝丁丁一下丁丘, string 一丐丗丁丞丆丅丟丄)
    {
        return 上七丈七三七七且丛.丂世丏丒丌丙七丗不(东丛丐东丐且丏丅丁:  一丐丗丁丞丆丅丟丄, 不专且丑丐丗丆丝专:  上七丈七三七七且丛.三丘丟丑丄世业丅丘(不一丅丟丐一丐东丘:  丘万丝丁丁一下丁丘));
    }
    private static string 丘丂丄丈丆七丁丘丈(string 丘万丝丁丁一下丁丘)
    {
        return 上七丈七三七七且丛.丄丝丘丐万丙丌丆丄(丈且丅丄丑丐丌丄丈:  UnityEngine.PlayerPrefs.GetString(key:  丘万丝丁丁一下丁丘), 不专且丑丐丗丆丝专:  上七丈七三七七且丛.三丘丟丑丄世业丅丘(不一丅丟丐一丐东丘:  丘万丝丁丁一下丁丘));
    }
    private static string 七与丆丒丞且专丏丟(string 下上丐丆丝丟丝丒不)
    {
        var val_5;
        var val_6;
        string val_7;
        string val_2 = 0;
        val_5 = null;
        val_5 = null;
        if(上七丈七三七七且丛.丒不丈上丗丆业世专 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_6 = null;
            val_6 = null;
            上七丈七三七七且丛.丒不丈上丗丆业世专 = val_1;
            val_5 = null;
        }
        
        val_5 = null;
        if((val_1.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_2)) != false)
        {
                val_7 = val_2;
            return val_7;
        }
        
        val_7 = 上七丈七三七七且丛.丁丘万一丝一与专丁(与丙丘专东专丟世丕:  下上丐丆丝丟丝丒不);
        val_1.Add(key:  下上丐丆丝丟丝丒不, value:  val_7);
        return val_7;
    }
    private static int 不专丂丈七丘丙丟一(string 下上丐丆丝丟丝丒不, string 世丂专且万丆七丛丙)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        string val_5 = 世丂专且万丆七丛丙;
        val_5 = null;
        val_5 = null;
        if(上七丈七三七七且丛.且丈七丌且丙丌与不 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_5 = null;
            val_5 = null;
            上七丈七三七七且丛.且丈七丌且丙丌与不 = val_1;
        }
        
        val_5 = null;
        if((val_1.ContainsKey(key:  下上丐丆丝丟丝丒不)) != false)
        {
                val_6 = null;
            val_6 = null;
            if(上七丈七三七七且丛.且丈七丌且丙丌与不 != null)
        {
                return val_1.Item[下上丐丆丝丟丝丒不];
        }
        
            return val_1.Item[下上丐丆丝丟丝丒不];
        }
        
        val_7 = 0;
        val_8 = 0;
        goto label_13;
        label_16:
        val_8 = val_8 + val_5.Chars[0];
        val_7 = 1;
        label_13:
        if(val_7 < val_5.Length)
        {
            goto label_16;
        }
        
        val_9 = null;
        val_9 = null;
        val_5 = 上七丈七三七七且丛.一不丑七万万丁不丌 + val_8;
        val_1.Add(key:  下上丐丆丝丟丝丒不, value:  val_5);
        return val_5;
    }
    private static int 丅业不丄丏丄一不丕(int 东上与丐丙万丑七丈)
    {
        东上与丐丙万丑七丈 = 东上与丐丙万丑七丈 & (东上与丐丙万丑七丈 << 1);
        return (int)东上与丐丙万丑七丈;
    }
    private static System.Security.Cryptography.HashAlgorithm 世丄世丏东丗丂丞丛()
    {
        System.Security.Cryptography.MD5CryptoServiceProvider val_2;
        var val_3 = null;
        if(上七丈七三七七且丛.不丕丙丑丅三专不一 == null)
        {
                System.Security.Cryptography.MD5CryptoServiceProvider val_1 = null;
            val_2 = val_1;
            val_1 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            val_3 = null;
            val_3 = null;
            上七丈七三七七且丛.不丕丙丑丅三专不一 = val_2;
        }
        
        val_3 = null;
        return (System.Security.Cryptography.HashAlgorithm)上七丈七三七七且丛.不丕丙丑丅三专不一;
    }
    public static string 丁丘万一丝一与专丁(string 与丙丘专东专丟世丕)
    {
        string val_9;
        var val_10;
        System.Text.StringBuilder val_4 = null;
        val_9 = 32;
        val_4 = new System.Text.StringBuilder(capacity:  32);
        val_10 = 0;
        goto label_5;
        label_12:
        val_9 = System.Convert.ToString(value:  上七丈七三七七且丛.世丄世丏东丗丂丞丛().ComputeHash(buffer:  System.Text.Encoding.UTF8)[0], toBase:  16).PadLeft(totalWidth:  2, paddingChar:  '0');
        System.Text.StringBuilder val_7 = val_4.Append(value:  val_9);
        val_10 = 1;
        label_5:
        if(val_10 < val_3.Length)
        {
            goto label_12;
        }
        
        if(val_4.Length > 31)
        {
                return (string)val_4;
        }
        
        if(val_4 != null)
        {
                return val_4.PadLeft(totalWidth:  32, paddingChar:  '0');
        }
        
        return val_4.PadLeft(totalWidth:  32, paddingChar:  '0');
    }
    private static byte[] 丂世丏丒丌丙七丗不(byte[] 东丛丐东丐且丏丅丁, System.Security.Cryptography.SymmetricAlgorithm 丏业丒下下丛丄丞丌)
    {
        var val_5;
        var val_6;
        System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
        new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  val_1, transform:  丏业丒下下丛丄丞丌, mode:  1);
        new System.Security.Cryptography.CryptoStream().Close();
        val_5 = 0;
        val_6 = 0;
        var val_5 = 0;
        val_5 = val_5 + 1;
        new System.Security.Cryptography.CryptoStream().Dispose();
        if(val_6 == 1)
        {
                if(val_5 != 0)
        {
                val_5 = 0;
        }
        
            val_6 = 0;
        }
        
        if(val_1 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
        }
        
        if(val_6 != 1)
        {
                return (System.Byte[])val_1;
        }
        
        if(val_5 == 0)
        {
                return (System.Byte[])val_1;
        }
        
        return (System.Byte[])val_1;
    }
    private static string 丂世丏丒丌丙七丗不(string 东丛丐东丐且丏丅丁, string 不专且丑丐丗丆丝专)
    {
        return System.Convert.ToBase64String(inArray:  上七丈七三七七且丛.丂世丏丒丌丙七丗不(东丛丐东丐且丏丅丁:  System.Text.Encoding.Unicode, 丏业丒下下丛丄丞丌:  上七丈七三七七且丛.丂丗丆丐丟丞上丒专(下上丐丆丝丟丝丒不:  不专且丑丐丗丆丝专)));
    }
    private static byte[] 丄丝丘丐万丙丌丆丄(byte[] 业丟丘丑丝三丄丑丟, System.Security.Cryptography.SymmetricAlgorithm 丏业丒下下丛丄丞丌)
    {
        var val_5;
        var val_6;
        System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
        new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  val_1, transform:  丏业丒下下丛丄丞丌, mode:  1);
        new System.Security.Cryptography.CryptoStream().Close();
        val_5 = 0;
        val_6 = 0;
        var val_5 = 0;
        val_5 = val_5 + 1;
        new System.Security.Cryptography.CryptoStream().Dispose();
        if(val_6 == 1)
        {
                if(val_5 != 0)
        {
                val_5 = 0;
        }
        
            val_6 = 0;
        }
        
        if(val_1 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
        }
        
        if(val_6 != 1)
        {
                return (System.Byte[])val_1;
        }
        
        if(val_5 == 0)
        {
                return (System.Byte[])val_1;
        }
        
        return (System.Byte[])val_1;
    }
    private static string 丄丝丘丐万丙丌丆丄(string 丈且丅丄丑丐丌丄丈, string 不专且丑丐丗丆丝专)
    {
        System.Collections.Generic.Dictionary<TKey, TValue> val_6;
        var val_7;
        var val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        if(上七丈七三七七且丛.丝丄丅丌丞且丁丂丐 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.Security.Cryptography.SymmetricAlgorithm> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Security.Cryptography.SymmetricAlgorithm>();
            val_8 = null;
            val_8 = null;
            上七丈七三七七且丛.丝丄丅丌丞且丁丂丐 = val_6;
        }
        
        val_9 = System.Text.Encoding.Unicode;
        if((上七丈七三七七且丛.丄丝丘丐万丙丌丆丄(业丟丘丑丝三丄丑丟:  System.Convert.FromBase64String(s:  丈且丅丄丑丐丌丄丈), 丏业丒下下丛丄丞丌:  上七丈七三七七且丛.丂丗丆丐丟丞上丒专(下上丐丆丝丟丝丒不:  不专且丑丐丗丆丝专))) == null)
        {
            goto label_10;
        }
        
        label_13:
        val_9 = ???;
        goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
        label_10:
        if(val_9 != 0)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private static System.Security.Cryptography.SymmetricAlgorithm 丂丗丆丐丟丞上丒专(string 下上丐丆丝丟丝丒不)
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if(上七丈七三七七且丛.丝丄丅丌丞且丁丂丐 == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.Security.Cryptography.SymmetricAlgorithm> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Security.Cryptography.SymmetricAlgorithm>();
            val_7 = null;
            val_7 = null;
            上七丈七三七七且丛.丝丄丅丌丞且丁丂丐 = val_1;
        }
        
        val_7 = null;
        if((val_1.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  0)) == true)
        {
                return (System.Security.Cryptography.SymmetricAlgorithm)val_6;
        }
        
        System.Security.Cryptography.Rfc2898DeriveBytes val_5 = new System.Security.Cryptography.Rfc2898DeriveBytes(password:  下上丐丆丝丟丝丒不, salt:  new byte[13] {73, 97, 110, 32, 77, 100, 118, 101, 101, 100, 101, 118, 118});
        System.Security.Cryptography.Rijndael val_6 = System.Security.Cryptography.Rijndael.Create();
        val_8 = null;
        val_8 = null;
        val_1.Add(key:  下上丐丆丝丟丝丒不, value:  val_6);
        return (System.Security.Cryptography.SymmetricAlgorithm)val_6;
    }
    private static string 三丘丟丑丄世业丅丘(string 不一丅丟丐一丐东丘)
    {
        return 上七丈七三七七且丛.丁丘万一丝一与专丁(与丙丘专东专丟世丕:  不一丅丟丐一丐东丘 + 上七丈七三七七且丛.丅丘与不丄丂一万东());
    }
    private static bool 丂丝世丗丏丐丂丕万(bool 三丏丕丑丛丑丈丐世, bool 丙丈专丞三丝丑万世)
    {
        null = null;
        上七丈七三七七且丛.丙丞七万世丅丅丕丐(丘丈不丐丒丘一丐一:  三丏丕丑丛丑丈丐世);
        上七丈七三七七且丛.东丈万万七丅丈一丞(丘丈不丐丒丘一丐一:  丙丈专丞三丝丑万世);
        string val_3 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_int");
        上七丈七三七七且丛.丂丟丝与上丌丆丅东(下上丐丆丝丟丝丒不:  "cryptotest_int", 下下丏一丙不丘丌丞:  0);
        int val_4 = 上七丈七三七七且丛.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  "cryptotest_int", 专不三上丏专丄且丞:  0);
        UnityEngine.Debug.Log(message:  "INT Bordertest Zero: "("INT Bordertest Zero: ") + (val_4 == 0) ? "ok" : "fail"((val_4 == 0) ? "ok" : "fail"));
        object[] val_7 = new object[11];
        val_7[0] = "(Key: ";
        val_7[1] = "cryptotest_int";
        val_7[2] = "; Crypted Key: ";
        val_7[3] = val_3;
        val_7[4] = "; Input value: ";
        val_7[5] = 0;
        val_7[6] = "; Saved value: ";
        val_7[7] = UnityEngine.PlayerPrefs.GetString(key:  val_3);
        val_7[8] = "; Return value: ";
        val_7[9] = val_4;
        val_7[10] = ")";
        UnityEngine.Debug.Log(message:  +val_7);
        string val_11 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_intmax");
        上七丈七三七七且丛.丂丟丝与上丌丆丅东(下上丐丆丝丟丝丒不:  "cryptotest_intmax", 下下丏一丙不丘丌丞:  2147483647);
        int val_12 = 上七丈七三七七且丛.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  "cryptotest_intmax", 专不三上丏专丄且丞:  0);
        UnityEngine.Debug.Log(message:  "INT Bordertest Max: "("INT Bordertest Max: ") + (val_12 == 2147483647) ? "ok" : "fail"((val_12 == 2147483647) ? "ok" : "fail"));
        object[] val_16 = new object[11];
        val_16[0] = "(Key: ";
        val_16[1] = "cryptotest_intmax";
        val_16[2] = "; Crypted Key: ";
        val_16[3] = val_11;
        val_16[4] = "; Input value: ";
        val_16[5] = 2147483647;
        val_16[6] = "; Saved value: ";
        val_16[7] = UnityEngine.PlayerPrefs.GetString(key:  val_11);
        val_16[8] = "; Return value: ";
        val_16[9] = val_12;
        val_16[10] = ")";
        UnityEngine.Debug.Log(message:  +val_16);
        string val_19 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_intmin");
        上七丈七三七七且丛.丂丟丝与上丌丆丅东(下上丐丆丝丟丝丒不:  "cryptotest_intmin", 下下丏一丙不丘丌丞:  -2147483648);
        int val_20 = 上七丈七三七七且丛.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  "cryptotest_intmin", 专不三上丏专丄且丞:  0);
        UnityEngine.Debug.Log(message:  "INT Bordertest Min: "("INT Bordertest Min: ") + (val_20 == (-2147483648)) ? "ok" : "fail"((val_20 == (-2147483648)) ? "ok" : "fail"));
        object[] val_24 = new object[11];
        val_24[0] = "(Key: ";
        val_24[1] = "cryptotest_intmin";
        val_24[2] = "; Crypted Key: ";
        val_24[3] = val_19;
        val_24[4] = "; Input value: ";
        val_24[5] = -2147483648;
        val_24[6] = "; Saved value: ";
        val_24[7] = UnityEngine.PlayerPrefs.GetString(key:  val_19);
        val_24[8] = "; Return value: ";
        val_24[9] = val_20;
        var val_27 = (((val_4 == 0) ? 1 : 0) & ((val_12 == 2147483647) ? 1 : 0)) & ((val_20 == (-2147483648)) ? 1 : 0);
        val_24[10] = ")";
        UnityEngine.Debug.Log(message:  +val_24);
        string val_29 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_intrand");
        var val_83 = 1;
        do
        {
            int val_30 = UnityEngine.Random.Range(min:  -2147483648, max:  2147483647);
            上七丈七三七七且丛.丂丟丝与上丌丆丅东(下上丐丆丝丟丝丒不:  "cryptotest_intrand", 下下丏一丙不丘丌丞:  val_30);
            var val_32 = (val_30 == (上七丈七三七七且丛.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  "cryptotest_intrand", 专不三上丏专丄且丞:  0))) ? 1 : 0;
            val_83 = val_83 & val_32;
            val_27 = val_27 & val_32;
        }
        while((100 - 1) != 0);
        
        UnityEngine.Debug.Log(message:  "INT Test Random: "("INT Test Random: ") + (val_83 != 0) ? "ok" : "fail"((val_83 != 0) ? "ok" : "fail"));
        string val_36 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_float");
        上七丈七三七七且丛.丝丕丘不丘东专一下(下上丐丆丝丟丝丒不:  "cryptotest_float", 下下丏一丙不丘丌丞:  0f);
        float val_37 = 上七丈七三七七且丛.丗且丄丛丏丁万七丄(下上丐丆丝丟丝丒不:  "cryptotest_float", 专不三上丏专丄且丞:  0f);
        bool val_40 = 0f.ToString().Equals(value:  val_37.ToString());
        UnityEngine.Debug.Log(message:  "FLOAT Bordertest Zero: "("FLOAT Bordertest Zero: ") + (val_40 != true) ? "ok" : "fail"((val_40 != true) ? "ok" : "fail"));
        object[] val_43 = new object[11];
        val_43[0] = "(Key: ";
        val_43[1] = "cryptotest_float";
        val_43[2] = "; Crypted Key: ";
        val_43[3] = val_36;
        val_43[4] = "; Input value: ";
        val_43[5] = 0f;
        val_43[6] = "; Saved value: ";
        val_43[7] = UnityEngine.PlayerPrefs.GetString(key:  val_36);
        val_43[8] = "; Return value: ";
        val_43[9] = val_37;
        val_43[10] = ")";
        UnityEngine.Debug.Log(message:  +val_43);
        string val_46 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_floatmax");
        上七丈七三七七且丛.丝丕丘不丘东专一下(下上丐丆丝丟丝丒不:  "cryptotest_floatmax", 下下丏一丙不丘丌丞:  -1.175494E-38f);
        float val_47 = 上七丈七三七七且丛.丗且丄丛丏丁万七丄(下上丐丆丝丟丝丒不:  "cryptotest_floatmax", 专不三上丏专丄且丞:  0f);
        bool val_50 = -1.175494E-38f.ToString().Equals(value:  val_47.ToString());
        UnityEngine.Debug.Log(message:  "FLOAT Bordertest Max: "("FLOAT Bordertest Max: ") + (val_50 != true) ? "ok" : "fail"((val_50 != true) ? "ok" : "fail"));
        object[] val_53 = new object[11];
        val_53[0] = "(Key: ";
        val_53[1] = "cryptotest_floatmax";
        val_53[2] = 102897760;
        val_53[3] = val_46;
        val_53[4] = "; Input value: ";
        val_53[5] = -1.175494E-38f;
        val_53[6] = "; Saved value: ";
        val_53[7] = UnityEngine.PlayerPrefs.GetString(key:  val_46);
        val_53[8] = "; Return value: ";
        val_53[9] = val_47;
        val_53[10] = ")";
        UnityEngine.Debug.Log(message:  +val_53);
        string val_56 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_floatmin");
        上七丈七三七七且丛.丝丕丘不丘东专一下(下上丐丆丝丟丝丒不:  "cryptotest_floatmin", 下下丏一丙不丘丌丞:  -3.402823E+38f);
        float val_57 = 上七丈七三七七且丛.丗且丄丛丏丁万七丄(下上丐丆丝丟丝丒不:  "cryptotest_floatmin", 专不三上丏专丄且丞:  0f);
        bool val_60 = -3.402823E+38f.ToString().Equals(value:  val_57.ToString());
        UnityEngine.Debug.Log(message:  "FLOAT Bordertest Min: "("FLOAT Bordertest Min: ") + (val_60 != true) ? "ok" : "fail"((val_60 != true) ? "ok" : "fail"));
        object[] val_63 = new object[11];
        val_63[0] = "(Key: ";
        val_63[1] = "cryptotest_floatmin";
        val_63[2] = "; Crypted Key: ";
        val_63[3] = val_56;
        val_63[4] = "; Input value: ";
        val_63[5] = -3.402823E+38f;
        val_63[6] = "; Saved value: ";
        val_63[7] = UnityEngine.PlayerPrefs.GetString(key:  val_56);
        val_63[8] = "; Return value: ";
        val_63[9] = val_57;
        bool val_65 = val_27 & val_40;
        val_65 = val_65 & val_50;
        val_63[10] = ")";
        UnityEngine.Debug.Log(message:  +val_63);
        string val_68 = 上七丈七三七七且丛.七与丆丒丞且专丏丟(下上丐丆丝丟丝丒不:  "cryptotest_floatrand");
        var val_84 = 1;
        do
        {
            float val_71 = UnityEngine.Random.value * ((float)UnityEngine.Random.Range(min:  -2147483648, max:  2147483647));
            上七丈七三七七且丛.丝丕丘不丘东专一下(下上丐丆丝丟丝丒不:  "cryptotest_floatrand", 下下丏一丙不丘丌丞:  val_71);
            val_84 = val_84 & (val_71.ToString().Equals(value:  上七丈七三七七且丛.丗且丄丛丏丁万七丄(下上丐丆丝丟丝丒不:  "cryptotest_floatrand", 专不三上丏专丄且丞:  0f).ToString()));
        }
        while((100 - 1) != 0);
        
        UnityEngine.Debug.Log(message:  "FLOAT Test Random: "("FLOAT Test Random: ") + (val_84 != true) ? "ok" : "fail"((val_84 != true) ? "ok" : "fail"));
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_int");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_intmax");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_intmin");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_intrandom");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_float");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_floatmax");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_floatmin");
        上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  "cryptotest_floatrandom");
        上七丈七三七七且丛.丙丞七万世丅丅丕丐(丘丈不丐丒丘一丐一:  (上七丈七三七七且丛.与万一丆丂丘业丞与 == true) ? 1 : 0);
        上七丈七三七七且丛.东丈万万七丅丈一丞(丘丈不丐丒丘一丐一:  (上七丈七三七七且丛.丛丝丂上下东万丞下 == true) ? 1 : 0);
        return (bool)val_65 & val_60;
    }
    public static bool 丂丝世丗丏丐丂丕万()
    {
        bool val_5 = 上七丈七三七七且丛.丂丝世丗丏丐丂丕万(三丏丕丑丛丑丈丐世:  false, 丙丈专丞三丝丑万世:  false);
        bool val_6 = ((上七丈七三七七且丛.丂丝世丗丏丐丂丕万(三丏丕丑丛丑丈丐世:  true, 丙丈专丞三丝丑万世:  true)) & (上七丈七三七七且丛.丂丝世丗丏丐丂丕万(三丏丕丑丛丑丈丐世:  true, 丙丈专丞三丝丑万世:  false))) & (上七丈七三七七且丛.丂丝世丗丏丐丂丕万(三丏丕丑丛丑丈丐世:  false, 丙丈专丞三丝丑万世:  true));
        val_6 = val_6 & val_5;
        val_5 = val_6;
        return (bool)val_5;
    }
    private static string 丅丘与不丄丂一万东()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        if((System.String.IsNullOrEmpty(value:  上七丈七三七七且丛.丁丑且丘与丒丗丂世)) != false)
        {
                val_5 = null;
            val_6 = null;
            上七丈七三七七且丛.丁丑且丘与丒丗丂世 = ToString();
        }
        
        val_6 = null;
        return (string)上七丈七三七七且丛.丁丑且丘与丒丗丂世;
    }
    public static void 七丐丟业丄丞丛丞丘(int 丏丛与丅丛丌万专丌)
    {
        null = null;
        上七丈七三七七且丛.一不丑七万万丁不丌 = 丏丛与丅丛丌万专丌;
        上七丈七三七七且丛.丁丑且丘与丒丗丂世 = 丏丛与丅丛丌万专丌.ToString();
    }
    public static void 丙丞七万世丅丅丕丐(bool 丘丈不丐丒丘一丐一)
    {
        null = null;
        上七丈七三七七且丛.与万一丆丂丘业丞与 = 丘丈不丐丒丘一丐一;
    }
    public static void 东丈万万七丅丈一丞(bool 丘丈不丐丒丘一丐一)
    {
        null = null;
        上七丈七三七七且丛.丛丝丂上下东万丞下 = 丘丈不丐丒丘一丐一;
    }
    private static 上七丈七三七七且丛()
    {
        上七丈七三七七且丛.不丕丙丑丅三专不一 = 0;
        上七丈七三七七且丛.一不丑七万万丁不丌 = 2147483647;
        上七丈七三七七且丛.与万一丆丂丘业丞与 = true;
        上七丈七三七七且丛.丛丝丂上下东万丞下 = true;
    }

}
