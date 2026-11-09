using UnityEngine;
public sealed class Load : MonoBehaviour
{
    // Methods
    internal static void 不三与万七丁丙丁七(string 丒丘丏上丙丟丑丕丈, UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        var val_11;
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) != true)
        {
                下丐三丆丝与不丗丕.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        char[] val_4 = new char[1];
        val_11 = "&";
        if(("&") == null)
        {
                val_11 = "&";
        }
        
        val_4[0] = Chars[0];
        System.String[] val_6 = UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈).Split(separator:  val_4);
        float val_7 = System.Single.Parse(s:  val_6[0]);
        float val_8 = System.Single.Parse(s:  val_6[1]);
        float val_9 = System.Single.Parse(s:  val_6[2]);
        下丐三丆丝与不丗丕.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static string 丑丏丌丟丂丙不丄丞(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return "";
        }
        
        return UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈);
    }
    internal static string[] 万丌丗丁丕万一丕丛(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈);
            char[] val_3 = new char[1];
            val_3[0] = '#';
            if(val_2 != null)
        {
                return val_2.Split(separator:  val_3);
        }
        
            return val_2.Split(separator:  val_3);
        }
        
        UnityEngine.Debug.Log(message:  "LoadStringArray(): Cannot find key "("LoadStringArray(): Cannot find key ") + 丒丘丏上丙丟丑丕丈);
        return 0;
    }
    internal static string[] 万丌丗丁丕万一丕丛(string 丒丘丏上丙丟丑丕丈, char 专丙丏下丂业丘东丕)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈);
        char[] val_3 = new char[1];
        val_3[0] = 专丙丏下丂业丘东丕;
        if(val_2 != null)
        {
                return val_2.Split(separator:  val_3);
        }
        
        return val_2.Split(separator:  val_3);
    }
    internal static int 丙丄七且丄与丆万世(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return UnityEngine.PlayerPrefs.GetInt(key:  丒丘丏上丙丟丑丕丈);
    }
    internal static int[] 丞业丗且丌丆丑东丝(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Int32[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new int[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Int32[])val_12;
        }
        
        do
        {
            val_14 = System.Convert.ToInt32(value:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Int32[])val_12;
    }
    internal static uint 专丙丟与丗世业丛丟(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.UInt32.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static uint[] 东世业丌丟丄丕下丟(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.UInt32[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new uint[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.UInt32[])val_12;
        }
        
        do
        {
            val_14 = System.Convert.ToUInt32(value:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.UInt32[])val_12;
    }
    internal static long 丝丛世丘丂丝丟丂东(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.Int64.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static long[] 万且丟世丁丟丗丏丑(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Int64[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new long[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Int64[])val_12;
        }
        
        do
        {
            val_14 = System.Int64.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Int64[])val_12;
    }
    internal static ulong 上且丈丆丛与上丑丟(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.UInt64.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static ulong[] 丐丛业丙丙下且业丗(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.UInt64[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new ulong[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.UInt64[])val_12;
        }
        
        do
        {
            val_14 = System.UInt64.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.UInt64[])val_12;
    }
    internal static short 世业丅丆丆丌丌丝业(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.Int16.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static short[] 一丝一丟上一丐万丙(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Int16[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new short[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Int16[])val_12;
        }
        
        do
        {
            val_14 = System.Int16.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Int16[])val_12;
    }
    internal static ushort 丘丙业业丕且丒丛丑(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.UInt16.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static ushort[] 业丑丑万丌丙丘专丄(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.UInt16[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new ushort[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.UInt16[])val_12;
        }
        
        do
        {
            val_14 = System.UInt16.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.UInt16[])val_12;
    }
    internal static float 丅丁丕业丏丆丐丄三(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0f;
        }
        
        return UnityEngine.PlayerPrefs.GetFloat(key:  丒丘丏上丙丟丑丕丈);
    }
    internal static float[] 上丄丄丕丈丄且世专(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Single[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_3[0] = Chars[0];
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new float[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Single[])val_12;
        }
        
        do
        {
            val_12[0] = System.Single.Parse(s:  val_11[0]);
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Single[])val_12;
    }
    internal static double 世业一东下丂丅丂丝(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.Double.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static double[] 丞业业七上业丕丈丑(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Double[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new double[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Double[])val_12;
        }
        
        do
        {
            val_14 = val_11[0];
            val_12[0] = System.Double.Parse(s:  val_14);
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Double[])val_12;
    }
    internal static bool 丗七与业丄万丗不丌(string 丒丘丏上丙丟丑丕丈)
    {
        string val_6;
        var val_7;
        val_6 = 丒丘丏上丙丟丑丕丈;
        bool val_3 = false;
        val_7 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_6)) == false)
        {
                return (bool)val_7;
        }
        
        val_6 = UnityEngine.PlayerPrefs.GetString(key:  val_6);
        if((System.Boolean.TryParse(value:  val_6, result: out  val_3)) != false)
        {
                var val_5 = (val_3 != 0) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    internal static bool[] 业丒七丟丏丘丞一丛(string 丒丘丏上丙丟丑丕丈)
    {
        string val_12;
        var val_13;
        var val_14;
        char val_15;
        val_12 = 丒丘丏上丙丟丑丕丈;
        val_13 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_12)) == false)
        {
                return (System.Boolean[])val_13;
        }
        
        char[] val_3 = new char[1];
        val_14 = "#";
        if("#" == null)
        {
                val_14 = "#";
        }
        
        val_15 = Chars[0];
        val_3[0] = val_15;
        val_12 = UnityEngine.PlayerPrefs.GetString(key:  val_12).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_13 = new bool[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Boolean[])val_13;
        }
        
        do
        {
            val_15 = System.Boolean.Parse(value:  val_12[0]);
            val_13[0] = val_15;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Boolean[])val_13;
    }
    internal static char 丐一与专丂丂不东三(string 丒丘丏上丙丟丑丕丈)
    {
        string val_5;
        var val_6;
        val_5 = 丒丘丏上丙丟丑丕丈;
        val_6 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_5)) == false)
        {
                return (char)val_6;
        }
        
        char val_3 = 0;
        val_5 = UnityEngine.PlayerPrefs.GetString(key:  val_5);
        bool val_4 = System.Char.TryParse(s:  val_5, result: out  val_3);
        val_6 = val_3;
        return (char)val_6;
    }
    internal static char[] 丕丘丑丆万丐三丏丒(string 丒丘丏上丙丟丑丕丈)
    {
        string val_12;
        var val_13;
        var val_14;
        char val_15;
        val_12 = 丒丘丏上丙丟丑丕丈;
        val_13 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_12)) == false)
        {
                return (System.Char[])val_13;
        }
        
        char[] val_3 = new char[1];
        val_14 = "#";
        if("#" == null)
        {
                val_14 = "#";
        }
        
        val_15 = Chars[0];
        val_3[0] = val_15;
        val_12 = UnityEngine.PlayerPrefs.GetString(key:  val_12).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_13 = new char[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Char[])val_13;
        }
        
        do
        {
            val_15 = val_12[0];
            bool val_10 = System.Char.TryParse(s:  val_15, result: out  val_13[0][32]);
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Char[])val_13;
    }
    internal static decimal 丌专七丞丗丛丅专三(string 丒丘丏上丙丟丑丕丈)
    {
        var val_3;
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) != false)
        {
                return System.Decimal.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
        }
        
        val_3 = null;
        val_3 = null;
        return new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0};
    }
    internal static System.Decimal[] 一下丏万且丌丟丑且(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Decimal[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new decimal[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Decimal[])val_12;
        }
        
        do
        {
            decimal val_9 = System.Decimal.Parse(s:  val_11[0]);
            val_14 = val_9.flags;
            val_12[0] = val_9;
            val_12[0] = val_9.lo;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Decimal[])val_12;
    }
    internal static byte 丘且丂丄丞丂三丙专(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.Byte.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static byte[] 丒丂丒不丄丗丄专七(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.Byte[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new byte[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.Byte[])val_12;
        }
        
        do
        {
            val_14 = System.Byte.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.Byte[])val_12;
    }
    internal static sbyte 丅与一丐丌丝东东万(string 丒丘丏上丙丟丑丕丈)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  丒丘丏上丙丟丑丕丈)) == false)
        {
                return 0;
        }
        
        return System.SByte.Parse(s:  UnityEngine.PlayerPrefs.GetString(key:  丒丘丏上丙丟丑丕丈));
    }
    internal static sbyte[] 丝丞不下丑丟丏丙丗(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        var val_12;
        var val_13;
        char val_14;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return (System.SByte[])val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "#";
        if("#" == null)
        {
                val_13 = "#";
        }
        
        val_14 = Chars[0];
        val_3[0] = val_14;
        val_11 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_12 = new sbyte[0];
        if((val_5.Length - 1) < 1)
        {
                return (System.SByte[])val_12;
        }
        
        do
        {
            val_14 = System.SByte.Parse(s:  val_11[0]);
            val_12[0] = val_14;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (System.SByte[])val_12;
    }
    internal static UnityEngine.Vector4 且丘丑丂东丞且丛丟(string 丒丘丏上丙丟丑丕丈)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_10)) != false)
        {
                char[] val_3 = new char[1];
            val_11 = "&";
            if(("&") == null)
        {
                val_11 = "&";
        }
        
            val_3[0] = Chars[0];
            val_10 = UnityEngine.PlayerPrefs.GetString(key:  val_10).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_10[0]);
            float val_8 = System.Single.Parse(s:  val_10[2]);
            val_12 = System.Single.Parse(s:  val_10[3]);
            val_13 = System.Single.Parse(s:  val_10[1]);
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        
        val_13 = 0f;
        val_12 = 0f;
        return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    internal static UnityEngine.Vector4[] 东丕一三丅丗丘丆丁(string 丒丘丏上丙丟丑丕丈)
    {
        string val_17;
        var val_18;
        var val_19;
        char val_20;
        var val_21;
        val_17 = 丒丘丏上丙丟丑丕丈;
        val_18 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_17)) == false)
        {
                return (UnityEngine.Vector4[])val_18;
        }
        
        char[] val_3 = new char[1];
        val_19 = "#";
        if("#" == null)
        {
                val_19 = "#";
        }
        
        val_20 = Chars[0];
        val_3[0] = val_20;
        val_17 = UnityEngine.PlayerPrefs.GetString(key:  val_17).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_18 = new UnityEngine.Vector4[0];
        if((val_5.Length - 1) < 1)
        {
                return (UnityEngine.Vector4[])val_18;
        }
        
        do
        {
            char[] val_9 = new char[1];
            val_21 = "&";
            if(("&") == null)
        {
                val_21 = "&";
        }
        
            val_9[0] = Chars[0];
            System.String[] val_11 = val_17[0].Split(separator:  val_9);
            float val_12 = System.Single.Parse(s:  val_11[0]);
            float val_13 = System.Single.Parse(s:  val_11[1]);
            float val_14 = System.Single.Parse(s:  val_11[2]);
            float val_15 = System.Single.Parse(s:  val_11[3]);
            val_20 = 0;
            val_18[0] = val_20;
            val_18[0] = 0;
            val_18[0] = 0;
            val_18[0] = 0;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (UnityEngine.Vector4[])val_18;
    }
    internal static UnityEngine.Vector3 丕七丁丏三丘东世丞(string 丒丘丏上丙丟丑丕丈)
    {
        string val_9;
        var val_10;
        var val_11;
        val_9 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_9)) != false)
        {
                char[] val_3 = new char[1];
            val_10 = "&";
            if(("&") == null)
        {
                val_10 = "&";
        }
        
            val_3[0] = Chars[0];
            val_9 = UnityEngine.PlayerPrefs.GetString(key:  val_9).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_9[0]);
            float val_8 = System.Single.Parse(s:  val_9[2]);
            val_11 = System.Single.Parse(s:  val_9[1]);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_11 = 0f;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static UnityEngine.Vector3[] 丏丙上丞丏丆丏丙不(string 丒丘丏上丙丟丑丕丈)
    {
        string val_14;
        var val_15;
        val_14 = 丒丘丏上丙丟丑丕丈;
        val_15 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_14)) == false)
        {
                return (UnityEngine.Vector3[])val_15;
        }
        
        char[] val_3 = new char[1];
        val_3[0] = '#';
        val_14 = UnityEngine.PlayerPrefs.GetString(key:  val_14).Split(separator:  val_3);
        int val_5 = val_4.Length - 1;
        val_15 = new UnityEngine.Vector3[0];
        if((val_4.Length - 1) < 1)
        {
                return (UnityEngine.Vector3[])val_15;
        }
        
        do
        {
            char[] val_8 = new char[1];
            val_8[0] = '&';
            System.String[] val_9 = val_14[0].Split(separator:  val_8);
            float val_10 = System.Single.Parse(s:  val_9[0]);
            float val_11 = System.Single.Parse(s:  val_9[1]);
            float val_12 = System.Single.Parse(s:  val_9[2]);
            var val_13 = val_15 + (0 * 12);
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        while((0 + 1) < (val_4.Length - 1));
        
        return (UnityEngine.Vector3[])val_15;
    }
    internal static UnityEngine.Vector2 丛与丌丂专丕专三丟(string 丒丘丏上丙丟丑丕丈)
    {
        string val_9;
        var val_10;
        float val_11;
        val_9 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_9)) != false)
        {
                char[] val_3 = new char[1];
            val_10 = "&";
            if(("&") == null)
        {
                val_10 = "&";
        }
        
            val_3[0] = Chars[0];
            val_9 = UnityEngine.PlayerPrefs.GetString(key:  val_9).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_9[0]);
            val_11 = System.Single.Parse(s:  val_9[1]);
        }
        else
        {
                val_11 = 0f;
        }
        
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  0f, y:  val_11);
        return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
    }
    internal static UnityEngine.Vector2[] 丘三丞三丞三世丏丛(string 丒丘丏上丙丟丑丕丈)
    {
        string val_16;
        var val_17;
        var val_18;
        char val_19;
        var val_20;
        val_16 = 丒丘丏上丙丟丑丕丈;
        val_17 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_16)) == false)
        {
                return (UnityEngine.Vector2[])val_17;
        }
        
        char[] val_3 = new char[1];
        val_18 = "#";
        if("#" == null)
        {
                val_18 = "#";
        }
        
        val_19 = Chars[0];
        val_3[0] = val_19;
        val_16 = UnityEngine.PlayerPrefs.GetString(key:  val_16).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_17 = new UnityEngine.Vector2[0];
        if((val_5.Length - 1) < 1)
        {
                return (UnityEngine.Vector2[])val_17;
        }
        
        do
        {
            char[] val_9 = new char[1];
            val_20 = "&";
            if(("&") == null)
        {
                val_20 = "&";
        }
        
            val_9[0] = Chars[0];
            System.String[] val_11 = val_16[0].Split(separator:  val_9);
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  System.Single.Parse(s:  val_11[0]), y:  System.Single.Parse(s:  val_11[1]));
            val_19 = val_14.y;
            val_17[0] = val_14.x;
            val_17[0] = val_19;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (UnityEngine.Vector2[])val_17;
    }
    internal static UnityEngine.Quaternion 三丙不与不且丙丅万(string 丒丘丏上丙丟丑丕丈)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_10)) != false)
        {
                char[] val_3 = new char[1];
            val_11 = "&";
            if(("&") == null)
        {
                val_11 = "&";
        }
        
            val_3[0] = Chars[0];
            val_10 = UnityEngine.PlayerPrefs.GetString(key:  val_10).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_10[0]);
            float val_8 = System.Single.Parse(s:  val_10[2]);
            val_12 = System.Single.Parse(s:  val_10[3]);
            val_13 = System.Single.Parse(s:  val_10[1]);
            return new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        
        val_13 = 0f;
        val_12 = 0f;
        return new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    internal static UnityEngine.Quaternion[] 业下且丄丏专不下丏(string 丒丘丏上丙丟丑丕丈)
    {
        string val_17;
        var val_18;
        var val_19;
        char val_20;
        var val_21;
        val_17 = 丒丘丏上丙丟丑丕丈;
        val_18 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_17)) == false)
        {
                return (UnityEngine.Quaternion[])val_18;
        }
        
        char[] val_3 = new char[1];
        val_19 = "#";
        if("#" == null)
        {
                val_19 = "#";
        }
        
        val_20 = Chars[0];
        val_3[0] = val_20;
        val_17 = UnityEngine.PlayerPrefs.GetString(key:  val_17).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_18 = new UnityEngine.Quaternion[0];
        if((val_5.Length - 1) < 1)
        {
                return (UnityEngine.Quaternion[])val_18;
        }
        
        do
        {
            char[] val_9 = new char[1];
            val_21 = "&";
            if(("&") == null)
        {
                val_21 = "&";
        }
        
            val_9[0] = Chars[0];
            System.String[] val_11 = val_17[0].Split(separator:  val_9);
            float val_12 = System.Single.Parse(s:  val_11[0]);
            float val_13 = System.Single.Parse(s:  val_11[1]);
            float val_14 = System.Single.Parse(s:  val_11[2]);
            float val_15 = System.Single.Parse(s:  val_11[3]);
            val_20 = 0;
            val_18[0] = val_20;
            val_18[0] = 0;
            val_18[0] = 0;
            val_18[0] = 0;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (UnityEngine.Quaternion[])val_18;
    }
    internal static UnityEngine.Color 万丗七世与丁丙丄丁(string 丒丘丏上丙丟丑丕丈)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_10)) != false)
        {
                char[] val_3 = new char[1];
            val_11 = "&";
            if(("&") == null)
        {
                val_11 = "&";
        }
        
            val_3[0] = Chars[0];
            val_10 = UnityEngine.PlayerPrefs.GetString(key:  val_10).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_10[0]);
            float val_8 = System.Single.Parse(s:  val_10[2]);
            val_12 = System.Single.Parse(s:  val_10[3]);
            val_13 = System.Single.Parse(s:  val_10[1]);
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        val_13 = 0f;
        val_12 = 0f;
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    internal static UnityEngine.Color[] 丌丕三七丏七上且丞(string 丒丘丏上丙丟丑丕丈)
    {
        string val_17;
        var val_18;
        var val_19;
        char val_20;
        var val_21;
        val_17 = 丒丘丏上丙丟丑丕丈;
        val_18 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_17)) == false)
        {
                return (UnityEngine.Color[])val_18;
        }
        
        char[] val_3 = new char[1];
        val_19 = "#";
        if("#" == null)
        {
                val_19 = "#";
        }
        
        val_20 = Chars[0];
        val_3[0] = val_20;
        val_17 = UnityEngine.PlayerPrefs.GetString(key:  val_17).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_18 = new UnityEngine.Color[0];
        if((val_5.Length - 1) < 1)
        {
                return (UnityEngine.Color[])val_18;
        }
        
        do
        {
            char[] val_9 = new char[1];
            val_21 = "&";
            if(("&") == null)
        {
                val_21 = "&";
        }
        
            val_9[0] = Chars[0];
            System.String[] val_11 = val_17[0].Split(separator:  val_9);
            float val_12 = System.Single.Parse(s:  val_11[0]);
            float val_13 = System.Single.Parse(s:  val_11[1]);
            float val_14 = System.Single.Parse(s:  val_11[2]);
            float val_15 = System.Single.Parse(s:  val_11[3]);
            val_20 = 0;
            val_18[0] = val_20;
            val_18[0] = 0;
            val_18[0] = 0;
            val_18[0] = 0;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (UnityEngine.Color[])val_18;
    }
    internal static UnityEngine.KeyCode 一丈专世世丄业丏丁(string 丒丘丏上丙丟丑丕丈)
    {
        string val_5;
        var val_6;
        val_5 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_5)) != false)
        {
                val_5 = UnityEngine.PlayerPrefs.GetString(key:  val_5);
            object val_4 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_5);
            return (UnityEngine.KeyCode)val_6;
        }
        
        val_6 = 32;
        return (UnityEngine.KeyCode)val_6;
    }
    internal static UnityEngine.KeyCode[] 上丏不丗丅下丝不不(string 丒丘丏上丙丟丑丕丈)
    {
        string val_10;
        var val_11;
        var val_12;
        char val_13;
        val_10 = 丒丘丏上丙丟丑丕丈;
        val_11 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_10)) == false)
        {
                return (UnityEngine.KeyCode[])val_11;
        }
        
        char[] val_3 = new char[1];
        val_12 = "#";
        if("#" == null)
        {
                val_12 = "#";
        }
        
        val_13 = Chars[0];
        val_3[0] = val_13;
        val_10 = UnityEngine.PlayerPrefs.GetString(key:  val_10).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        int val_10 = val_5.Length;
        val_11 = new UnityEngine.KeyCode[0];
        val_10 = val_10 - 1;
        if(val_10 < 1)
        {
                return (UnityEngine.KeyCode[])val_11;
        }
        
        var val_12 = 0;
        do
        {
            object val_9 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_10[0]);
            val_11[0] = null;
            int val_13 = val_5.Length;
            val_12 = val_12 + 1;
            val_13 = val_13 - 1;
        }
        while(val_12 < val_13);
        
        return (UnityEngine.KeyCode[])val_11;
    }
    internal static UnityEngine.Rect 七丞东业专七丟丐丛(string 丒丘丏上丙丟丑丕丈)
    {
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = 丒丘丏上丙丟丑丕丈;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_10)) != false)
        {
                char[] val_3 = new char[1];
            val_11 = "&";
            if(("&") == null)
        {
                val_11 = "&";
        }
        
            val_3[0] = Chars[0];
            val_10 = UnityEngine.PlayerPrefs.GetString(key:  val_10).Split(separator:  val_3);
            float val_6 = System.Single.Parse(s:  val_10[0]);
            float val_8 = System.Single.Parse(s:  val_10[2]);
            val_12 = System.Single.Parse(s:  val_10[3]);
            val_13 = System.Single.Parse(s:  val_10[1]);
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        
        val_13 = 0f;
        val_12 = 0f;
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    internal static UnityEngine.Rect[] 与丗丙丆丙丒丘丕世(string 丒丘丏上丙丟丑丕丈)
    {
        string val_17;
        var val_18;
        var val_19;
        char val_20;
        var val_21;
        val_17 = 丒丘丏上丙丟丑丕丈;
        val_18 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_17)) == false)
        {
                return (UnityEngine.Rect[])val_18;
        }
        
        char[] val_3 = new char[1];
        val_19 = "#";
        if("#" == null)
        {
                val_19 = "#";
        }
        
        val_20 = Chars[0];
        val_3[0] = val_20;
        val_17 = UnityEngine.PlayerPrefs.GetString(key:  val_17).Split(separator:  val_3);
        int val_6 = val_5.Length - 1;
        val_18 = new UnityEngine.Rect[0];
        if((val_5.Length - 1) < 1)
        {
                return (UnityEngine.Rect[])val_18;
        }
        
        do
        {
            char[] val_9 = new char[1];
            val_21 = "&";
            if(("&") == null)
        {
                val_21 = "&";
        }
        
            val_9[0] = Chars[0];
            System.String[] val_11 = val_17[0].Split(separator:  val_9);
            float val_12 = System.Single.Parse(s:  val_11[0]);
            float val_13 = System.Single.Parse(s:  val_11[1]);
            float val_14 = System.Single.Parse(s:  val_11[2]);
            float val_15 = System.Single.Parse(s:  val_11[3]);
            val_20 = 0;
            val_18[0] = val_20;
            val_18[0] = 0;
            val_18[0] = 0;
            val_18[0] = 0;
        }
        while((0 + 1) < (val_5.Length - 1));
        
        return (UnityEngine.Rect[])val_18;
    }
    internal static UnityEngine.Texture2D 丆万丌丟三下丗丏丄(string 丒丘丏上丙丟丑丕丈)
    {
        string val_11;
        UnityEngine.Texture2D val_12;
        var val_13;
        val_11 = 丒丘丏上丙丟丑丕丈;
        val_12 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_11)) == false)
        {
                return val_12;
        }
        
        char[] val_3 = new char[1];
        val_13 = "&";
        if(("&") == null)
        {
                val_13 = "&";
        }
        
        val_3[0] = Chars[0];
        System.String[] val_5 = UnityEngine.PlayerPrefs.GetString(key:  val_11).Split(separator:  val_3);
        val_11 = System.Int32.Parse(s:  val_5[1]);
        UnityEngine.Texture2D val_9 = null;
        val_12 = val_9;
        val_9 = new UnityEngine.Texture2D(width:  System.Int32.Parse(s:  val_5[0]), height:  val_11);
        bool val_10 = UnityEngine.ImageConversion.LoadImage(tex:  val_9, data:  System.Convert.FromBase64String(s:  val_5[2]));
        return val_12;
    }
    public Load()
    {
    
    }

}
