using UnityEngine;
public class MiniJSON
{
    // Fields
    private const int TOKEN_NONE = 0;
    private const int TOKEN_CURLY_OPEN = 1;
    private const int TOKEN_CURLY_CLOSE = 2;
    private const int TOKEN_SQUARED_OPEN = 3;
    private const int TOKEN_SQUARED_CLOSE = 4;
    private const int TOKEN_COLON = 5;
    private const int TOKEN_COMMA = 6;
    private const int TOKEN_STRING = 7;
    private const int TOKEN_NUMBER = 8;
    private const int TOKEN_TRUE = 9;
    private const int TOKEN_FALSE = 10;
    private const int TOKEN_NULL = 11;
    private const int BUILDER_CAPACITY = 2000;
    protected static int lastErrorIndex;
    protected static string lastDecode;
    
    // Methods
    internal static object jsonDecode(string json)
    {
        string val_5;
        var val_6;
        var val_7;
        val_5 = json;
        val_6 = null;
        val_6 = null;
        MiniJSON.lastDecode = val_5;
        if(val_5 == null)
        {
                return (object)val_5;
        }
        
        int val_2 = 0;
        bool val_3 = true;
        val_5 = MiniJSON.parseValue(json:  val_5.ToCharArray(), index: ref  val_2, success: ref  val_3);
        if(val_3 != 0)
        {
                val_7 = 0;
        }
        else
        {
                val_7 = val_2;
        }
        
        MiniJSON.lastErrorIndex = 0;
        return (object)val_5;
    }
    internal static string jsonEncode(object json)
    {
        System.Text.StringBuilder val_7;
        System.Text.StringBuilder val_1 = null;
        val_7 = val_1;
        val_1 = new System.Text.StringBuilder(capacity:  208);
        if((MiniJSON.serializeValue(value:  json, builder:  val_1)) == false)
        {
                return 0;
        }
        
        val_7 = ???;
        goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
    }
    internal static bool lastDecodeSuccessful()
    {
        null = null;
        return (bool)(MiniJSON.lastErrorIndex == 1) ? 1 : 0;
    }
    internal static int getLastErrorIndex()
    {
        null = null;
        return (int)MiniJSON.lastErrorIndex;
    }
    internal static string getLastErrorSnippet()
    {
        var val_7;
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = null;
        val_7 = null;
        val_9 = MiniJSON.lastErrorIndex;
        if(val_9 == 1)
        {
                return "";
        }
        
        val_10 =  + 15;
         =  - 5;
        if(val_10 >= MiniJSON.lastDecode.Length)
        {
                val_11 = null;
            val_11 = null;
            val_10 = MiniJSON.lastDecode.Length - 1;
        }
        
        val_12 = null;
        int val_3 =  & (~( >> 31));
        val_12 = null;
        var val_5 = 1;
        val_5 = val_5 - val_3;
        return MiniJSON.lastDecode.Substring(startIndex:  val_3, length:  val_5 + val_10);
    }
    protected static System.Collections.Hashtable parseObject(char[] json, ref int index)
    {
        var val_16;
        System.Collections.Hashtable val_1 = null;
        val_16 = val_1;
        val_1 = new System.Collections.Hashtable();
        int val_3 = MiniJSON.nextToken(json:  json, index: ref  1152921524095643936);
        goto label_14;
        label_21:
        if(((MiniJSON.parseString(json:  json, index: ref  1152921524095643936)) == null) || ((MiniJSON.nextToken(json:  json, index: ref  1152921524095643936)) != 5))
        {
            goto label_20;
        }
        
        bool val_9 = true;
        object val_10 = MiniJSON.parseValue(json:  json, index: ref  1152921524095643936, success: ref  val_9);
        if(val_9 == 0)
        {
            goto label_20;
        }
        
        if(val_16 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_19:
        int val_12 = MiniJSON.nextToken(json:  json, index: ref  1152921524095643936);
        label_14:
        int val_13 = MiniJSON.lookAhead(json:  json, index:  index);
        if(val_13 == 6)
        {
            goto label_19;
        }
        
        if(val_13 == 0)
        {
            goto label_20;
        }
        
        if(val_13 != 2)
        {
            goto label_21;
        }
        
        int val_15 = MiniJSON.nextToken(json:  json, index: ref  1152921524095643936);
        return (System.Collections.Hashtable)val_16;
        label_20:
        val_16 = 0;
        return (System.Collections.Hashtable)val_16;
    }
    protected static System.Collections.ArrayList parseArray(char[] json, ref int index)
    {
        var val_12;
        System.Collections.ArrayList val_1 = null;
        val_12 = val_1;
        val_1 = new System.Collections.ArrayList();
        int val_3 = MiniJSON.nextToken(json:  json, index: ref  1152921524095858176);
        goto label_8;
        label_15:
        bool val_5 = true;
        object val_6 = MiniJSON.parseValue(json:  json, index: ref  1152921524095858176, success: ref  val_5);
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        if(val_12 != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_13:
        int val_8 = MiniJSON.nextToken(json:  json, index: ref  1152921524095858176);
        label_8:
        int val_9 = MiniJSON.lookAhead(json:  json, index:  index);
        if(val_9 == 6)
        {
            goto label_13;
        }
        
        if(val_9 == 0)
        {
            goto label_14;
        }
        
        if(val_9 != 4)
        {
            goto label_15;
        }
        
        int val_11 = MiniJSON.nextToken(json:  json, index: ref  1152921524095858176);
        return (System.Collections.ArrayList)val_12;
        label_14:
        val_12 = 0;
        return (System.Collections.ArrayList)val_12;
    }
    protected static object parseValue(char[] json, ref int index, ref bool success)
    {
        int val_21;
        var val_22;
        val_21 = 1152921524096084656;
        if(((MiniJSON.lookAhead(json:  json, index:  index)) - 1) <= 10)
        {
                var val_21 = 100675756 + ((val_1 - 1)) << 2;
            val_21 = val_21 + 100675756;
        }
        else
        {
                val_22 = 0;
            success = false;
            return (object);
        }
    
    }
    protected static string parseString(char[] json, ref int index)
    {
        string val_12;
        int val_13;
        var val_14;
        string val_15;
        val_12 = "";
        MiniJSON.eatWhitespace(json:  json, index: ref  1152921524096323456);
        index = index + 1;
        val_13 = json.Length;
        if(index >= val_13)
        {
                val_13 = json.Length;
        }
        
        char val_12 = json[(index) << 1];
        if(index == val_13)
        {
            goto label_26;
        }
        
        label_30:
        index = index + 1;
        char val_13 = json[((long)(int)((index + 1))) << 1];
        if(val_13 == '\')
        {
            goto label_7;
        }
        
        if(val_13 == '"')
        {
                return (string)val_12;
        }
        
        val_14;
        goto label_25;
        label_7:
        if(index == json.Length)
        {
            goto label_26;
        }
        
        index = index + 1;
        char val_14 = json[(((index + 1) + 1)) << 1];
        if(val_14 > 'a')
        {
            goto label_12;
        }
        
        if(val_14 == '"')
        {
            goto label_13;
        }
        
        if(val_14 == ('/'))
        {
            goto label_14;
        }
        
        if(val_14 != '\')
        {
            goto label_29;
        }
        
        val_14 = "\\";
        goto label_25;
        label_12:
        if((val_14 - 110) > '')
        {
            goto label_17;
        }
        
        var val_15 = 100675900 + ((json[(((index + 1) + 1)) << 1][0] - 110)) << 2;
        val_15 = val_15 + 100675900;
        goto (100675900 + ((json[(((index + 1) + 1)) << 1][0] - 110)) << 2 + 100675900);
        label_13:
        val_14 = "\"";
        goto label_25;
        label_14:
        val_14 = "/";
        goto label_25;
        label_17:
        if(val_14 == 'b')
        {
            goto label_21;
        }
        
        if(val_14 != 'f')
        {
            goto label_29;
        }
        
        val_15 = "\f";
        goto label_24;
        label_21:
        val_15 = "\b";
        label_24:
        label_25:
        string val_11 = val_12 + val_15;
        label_29:
        if( != json.Length)
        {
            goto label_30;
        }
        
        label_26:
        val_12 = 0;
        return (string)val_12;
    }
    protected static double parseNumber(char[] json, ref int index)
    {
        MiniJSON.eatWhitespace(json:  json, index: ref  1152921524096545920);
        int val_2 = MiniJSON.getLastIndexOfNumber(json:  json, index:  index);
        int val_7 = index;
        val_7 = val_2 - val_7;
        char[] val_4 = new char[0];
        System.Array.Copy(sourceArray:  json, sourceIndex:  index, destinationArray:  val_4, destinationIndex:  0, length:  val_7 + 1);
        index = val_2 + 1;
        return System.Double.Parse(s:  0.CreateString(val:  val_4));
    }
    protected static int getLastIndexOfNumber(char[] json, int index)
    {
        char val_3;
        var val_4;
        var val_5;
        val_4 = index;
        goto label_1;
        label_6:
        val_3 = json[((long)(int)(index)) << 1];
        val_5 = "0123456789+-.eE";
        if(("0123456789+-.eE") == null)
        {
                val_5 = "0123456789+-.eE";
        }
        
        if((IndexOf(value:  val_3)) == 1)
        {
                return (int)val_4 - 1;
        }
        
        val_4 = val_4 + 1;
        label_1:
        if(val_4 < json.Length)
        {
            goto label_6;
        }
        
        return (int)val_4 - 1;
    }
    protected static void eatWhitespace(char[] json, ref int index)
    {
        int val_3;
        var val_4;
        val_3 = index;
        goto label_1;
        label_6:
        val_4 = " \t\n\r";
        val_3 = json[(index) << 1];
        if(" \t\n\r" == null)
        {
                val_4 = " \t\n\r";
        }
        
        if((IndexOf(value:  val_3)) == 1)
        {
                return;
        }
        
        val_3 = index + 1;
        index = val_3;
        label_1:
        if(val_3 < json.Length)
        {
            goto label_6;
        }
    
    }
    protected static int lookAhead(char[] json, int index)
    {
        return (int)MiniJSON.nextToken(json:  json, index: ref  index);
    }
    protected static int nextToken(char[] json, ref int index)
    {
        var val_5;
        int val_6;
        int val_7;
        MiniJSON.eatWhitespace(json:  json, index: ref  1152921524097313088);
        if(index != json.Length)
        {
            goto label_4;
        }
        
        label_48:
        val_5 = 0;
        return 5;
        label_4:
        val_6 = index;
        if(val_6 >= json.Length)
        {
                val_6 = index;
        }
        
        char val_5 = json[((long)(int)(index)) << 1];
        index = val_6 + 1;
        if(val_5 > '[')
        {
            goto label_7;
        }
        
        if((val_5 - 34) > '')
        {
            goto label_8;
        }
        
        var val_6 = 100675800;
        val_6 = (100675800 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2) + val_6;
        goto (100675800 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2 + 100675800);
        label_7:
        if(val_5 == ']')
        {
            goto label_10;
        }
        
        if(val_5 == '{')
        {
            goto label_11;
        }
        
        if(val_5 != '}')
        {
            goto label_16;
        }
        
        val_5 = 2;
        return 5;
        label_10:
        val_5 = 4;
        return 5;
        label_11:
        val_5 = 1;
        return 5;
        label_8:
        if(val_5 == '[')
        {
                val_5 = 3;
            return 5;
        }
        
        label_16:
        index = val_6;
        int val_4 = json.Length - val_6;
        if(val_4 >= 5)
        {
            goto label_18;
        }
        
        if(val_4 != 4)
        {
            goto label_48;
        }
        
        goto label_30;
        label_18:
        if((json[((long)(int)(index)) << 1]) == 'f')
        {
                int val_8 = index;
            val_8 = val_8 + 1;
            if((json[((long)(int)((index + 1))) << 1]) == 'a')
        {
                int val_10 = index;
            val_10 = val_10 + 2;
            if((json[((long)(int)((index + 2))) << 1]) == 'l')
        {
                int val_12 = index;
            val_12 = val_12 + 3;
            if((json[((long)(int)((index + 3))) << 1]) == 's')
        {
                int val_14 = index;
            val_14 = val_14 + 4;
            if((json[((long)(int)((index + 4))) << 1]) == 'e')
        {
                int val_16 = index;
            val_5 = 10;
            val_16 = val_16 + 5;
            index = val_16;
            return 5;
        }
        
        }
        
        }
        
        }
        
        }
        
        label_30:
        if((json[((index + 5)) << 1]) != 't')
        {
            goto label_39;
        }
        
        int val_18 = index;
        val_18 = val_18 + 1;
        if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'r')
        {
            goto label_39;
        }
        
        int val_20 = index;
        val_20 = val_20 + 2;
        if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'u')
        {
            goto label_39;
        }
        
        int val_22 = index;
        val_22 = val_22 + 3;
        if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'e')
        {
            goto label_39;
        }
        
        val_7 = index;
        val_5 = 9;
        goto label_40;
        label_39:
        if((json[((index + 5)) << 1]) != 'n')
        {
            goto label_48;
        }
        
        int val_25 = index;
        val_25 = val_25 + 1;
        if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'u')
        {
            goto label_48;
        }
        
        int val_27 = index;
        val_27 = val_27 + 2;
        if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'l')
        {
            goto label_48;
        }
        
        int val_29 = index;
        val_29 = val_29 + 3;
        if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'l')
        {
            goto label_48;
        }
        
        val_7 = index;
        val_5 = 11;
        label_40:
        val_7 = val_7 + 4;
        index = val_7;
        return 5;
    }
    protected static bool serializeObjectOrArray(object objectOrArray, System.Text.StringBuilder builder)
    {
        var val_4;
        var val_6;
        var val_9;
        val_4 = objectOrArray;
        if(val_4 != null)
        {
                val_6 = null;
            val_9 = null;
        }
        
        var val_4 = 0;
        val_4 = val_4 & 1;
        return (bool)val_4;
    }
    protected static bool serializeObject(System.Collections.Hashtable anObject, System.Text.StringBuilder builder)
    {
        string val_10;
        var val_14;
        System.Text.StringBuilder val_1 = builder.Append(value:  "{");
        label_25:
        var val_12 = 0;
        val_12 = val_12 + 1;
        if(anObject.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_10 = anObject.Key;
        var val_14 = 0;
        val_14 = val_14 + 1;
        if((1 & 1) == 0)
        {
                System.Text.StringBuilder val_8 = builder.Append(value:  ", ");
        }
        
        MiniJSON.serializeString(aString:  val_10, builder:  builder);
        System.Text.StringBuilder val_9 = builder.Append(value:  ":");
        val_14 = 0;
        if((MiniJSON.serializeValue(value:  anObject.Value, builder:  builder)) == true)
        {
            goto label_25;
        }
        
        return (bool)val_14;
        label_8:
        System.Text.StringBuilder val_11 = builder.Append(value:  "}");
        val_14 = 1;
        return (bool)val_14;
    }
    protected static bool serializeDictionary(System.Collections.Generic.Dictionary<string, string> dict, System.Text.StringBuilder builder)
    {
        System.Text.StringBuilder val_1 = builder.Append(value:  "{");
        Dictionary.Enumerator<TKey, TValue> val_2 = dict.GetEnumerator();
        label_9:
        if(((-1983967896) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        if((1 & 1) == 0)
        {
                System.Text.StringBuilder val_4 = builder.Append(value:  ", ");
        }
        
        MiniJSON.serializeString(aString:  val_3._value._obj.丐丏七丌丕丗业且上(), builder:  builder);
        System.Text.StringBuilder val_6 = builder.Append(value:  ":");
        MiniJSON.serializeString(aString:  val_3._value._obj, builder:  builder);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Text.StringBuilder val_7 = builder.Append(value:  "}");
        return true;
    }
    protected static bool serializeArray(System.Collections.ArrayList anArray, System.Text.StringBuilder builder)
    {
        var val_5;
        var val_6;
        System.Text.StringBuilder val_1 = builder.Append(value:  "[");
        val_5 = 0;
        label_8:
        if(val_5 >= anArray)
        {
            goto label_3;
        }
        
        if((1 & 1) == 0)
        {
                System.Text.StringBuilder val_2 = builder.Append(value:  ", ");
        }
        
        val_6 = 0;
        val_5 = val_5 + 1;
        if((MiniJSON.serializeValue(value:  anArray, builder:  builder)) == true)
        {
            goto label_8;
        }
        
        return (bool)val_6;
        label_3:
        System.Text.StringBuilder val_4 = builder.Append(value:  "]");
        val_6 = 1;
        return (bool)val_6;
    }
    protected static bool serializeValue(object value, System.Text.StringBuilder builder)
    {
        System.Collections.ArrayList val_14;
        object val_15;
        System.Collections.ICollection val_16;
        var val_19;
        var val_21;
        var val_23;
        string val_25;
        var val_27;
        val_15 = value;
        if(val_15 == null)
        {
            goto label_1;
        }
        
        if(val_15.GetType().IsArray == false)
        {
            goto label_3;
        }
        
        val_14 = new System.Collections.ArrayList();
        val_16 = val_15;
        if(val_16 == null)
        {
                val_16 = 0;
        }
        
        val_14 = new System.Collections.ArrayList(c:  val_16);
        bool val_5 = MiniJSON.serializeArray(anArray:  new System.Collections.ArrayList(), builder:  builder);
        return true;
        label_1:
        label_61:
        System.Text.StringBuilder val_6 = builder.Append(value:  "null");
        return true;
        label_3:
        val_14 = 1152921504624312320;
        if(null == null)
        {
            goto label_10;
        }
        
        val_14 = 1152921504617869312;
        if(null == null)
        {
            goto label_11;
        }
        
        val_14 = 1152921504618881024;
        if(null == null)
        {
            goto label_12;
        }
        
        val_19 = null;
        val_21 = null;
        val_23 = null;
        if(null == null)
        {
            goto label_19;
        }
        
        label_59:
        if(null == null)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        val_14 = val_15.GetType();
        if(val_14.IsPrimitive == false)
        {
                return true;
        }
        
        MiniJSON.serializeNumber(number:  System.Convert.ToDouble(value:  val_15), builder:  builder);
        return true;
        label_10:
        if(null == null)
        {
            goto label_39;
        }
        
        val_25 = 0;
        goto label_39;
        label_11:
        string val_10 = System.Convert.ToString(value:  '');
        goto label_35;
        label_12:
        val_27 = null;
        label_35:
        val_25 = System.Convert.ToString(value:  new System.Decimal() {flags = 21884928, hi = 268435456, lo = 12034048, mid = 268435456});
        label_39:
        MiniJSON.serializeString(aString:  val_25, builder:  builder);
        return true;
        label_19:
        if(null == null)
        {
            goto label_59;
        }
        
        if(builder != null)
        {
            goto label_61;
        }
        
        goto label_61;
        label_21:
        if(builder != null)
        {
            goto label_61;
        }
        
        goto label_61;
    }
    protected static void serializeString(string aString, System.Text.StringBuilder builder)
    {
        char val_11;
        var val_12;
        string val_13;
        var val_14;
        System.Text.StringBuilder val_1 = builder.Append(value:  "\"");
        val_12 = 0;
        goto label_29;
        label_33:
        val_11 = aString.ToCharArray()[0];
        aString.ToCharArray()[0] = val_11 - 8;
        if(aString.ToCharArray()[0] > '')
        {
            goto label_5;
        }
        
        var val_11 = 100675932 + ((val_2[0x0][0] - 8)) << 2;
        val_11 = val_11 + 100675932;
        goto (100675932 + ((val_2[0x0][0] - 8)) << 2 + 100675932);
        label_5:
        if(val_11 == '\')
        {
            goto label_8;
        }
        
        if(val_11 != '"')
        {
            goto label_9;
        }
        
        val_13 = "\\\"";
        goto label_21;
        label_9:
        int val_3 = System.Convert.ToInt32(value:  val_11);
        if((val_3 - 32) <= 94)
        {
            goto label_14;
        }
        
        val_11 = "\\u" + System.Convert.ToString(value:  val_3, toBase:  16).PadLeft(totalWidth:  4, paddingChar:  '0')(System.Convert.ToString(value:  val_3, toBase:  16).PadLeft(totalWidth:  4, paddingChar:  '0'));
        val_14 = val_11;
        goto label_19;
        label_8:
        val_13 = "\\\\";
        label_21:
        label_19:
        System.Text.StringBuilder val_8 = builder.Append(value:  val_13);
        label_31:
        val_12 = 1;
        goto label_29;
        label_14:
        System.Text.StringBuilder val_9 = builder.Append(value:  val_11);
        goto label_31;
        label_29:
        if(val_12 < val_2.Length)
        {
            goto label_33;
        }
        
        System.Text.StringBuilder val_10 = builder.Append(value:  "\"");
    }
    protected static void serializeNumber(double number, System.Text.StringBuilder builder)
    {
        System.Text.StringBuilder val_2 = builder.Append(value:  System.Convert.ToString(value:  number));
    }
    public MiniJSON()
    {
    
    }
    private static MiniJSON()
    {
        MiniJSON.lastErrorIndex = 0;
        MiniJSON.lastDecode = "";
    }

}
