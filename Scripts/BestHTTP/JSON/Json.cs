using UnityEngine;

namespace BestHTTP.JSON
{
    public class Json
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
        
        // Methods
        public static object Decode(string json)
        {
            return (object)BestHTTP.JSON.Json.Decode(json:  json, success: ref  true);
        }
        public static object Decode(string json, ref bool success)
        {
            success = true;
            if(json == null)
            {
                    return (object)BestHTTP.JSON.Json.ParseValue(json:  json.ToCharArray(), index: ref  0, success: ref  true);
            }
            
            return (object)BestHTTP.JSON.Json.ParseValue(json:  json.ToCharArray(), index: ref  0, success: ref  true);
        }
        public static string Encode(object json)
        {
            System.Text.StringBuilder val_7;
            System.Text.StringBuilder val_1 = null;
            val_7 = val_1;
            val_1 = new System.Text.StringBuilder(capacity:  208);
            if((BestHTTP.JSON.Json.SerializeValue(value:  json, builder:  val_1)) == false)
            {
                    return 0;
            }
            
            val_7 = ???;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        protected static System.Collections.Generic.Dictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
        {
            var val_18;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
            val_18 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            int val_3 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756354960);
            goto label_6;
            label_9:
            if(((success == false) || ((BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756354960)) != 5)) || (success == false))
            {
                goto label_8;
            }
            
            val_1.set_Item(key:  BestHTTP.JSON.Json.ParseString(json:  json, index: ref  1152921553756354960, success: ref  true), value:  BestHTTP.JSON.Json.ParseValue(json:  json, index: ref  1152921553756354960, success: ref  true));
            goto label_6;
            label_7:
            int val_13 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756354960);
            label_6:
            int val_15 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  index);
            if(val_15 == 6)
            {
                goto label_7;
            }
            
            if(val_15 == 0)
            {
                goto label_8;
            }
            
            if(val_15 != 2)
            {
                goto label_9;
            }
            
            int val_17 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756354960);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_18;
            label_8:
            val_18 = 0;
            success = false;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_18;
        }
        protected static System.Collections.Generic.List<object> ParseArray(char[] json, ref int index, ref bool success)
        {
            var val_13;
            System.Collections.Generic.List<System.Object> val_1 = null;
            val_13 = val_1;
            val_1 = new System.Collections.Generic.List<System.Object>();
            int val_3 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756577296);
            goto label_3;
            label_7:
            val_1.Add(item:  X23);
            goto label_3;
            label_4:
            int val_5 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756577296);
            label_3:
            int val_7 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  index);
            if(val_7 == 6)
            {
                goto label_4;
            }
            
            if(val_7 == 0)
            {
                goto label_5;
            }
            
            if(val_7 == 4)
            {
                goto label_6;
            }
            
            object val_10 = BestHTTP.JSON.Json.ParseValue(json:  json, index: ref  1152921553756577296, success: ref  true);
            if(success == true)
            {
                goto label_7;
            }
            
            val_13 = 0;
            return (System.Collections.Generic.List<System.Object>)val_13;
            label_5:
            val_13 = 0;
            success = false;
            return (System.Collections.Generic.List<System.Object>)val_13;
            label_6:
            int val_12 = BestHTTP.JSON.Json.NextToken(json:  json, index: ref  1152921553756577296);
            return (System.Collections.Generic.List<System.Object>)val_13;
        }
        protected static object ParseValue(char[] json, ref int index, ref bool success)
        {
            var val_21;
            int val_21 = index;
            val_21 = (BestHTTP.JSON.Json.NextToken(json:  json, index: ref  val_21)) - 1;
            if(val_21 <= 10)
            {
                    var val_22 = 106066328 + ((val_2 - 1)) << 2;
                val_22 = val_22 + 106066328;
            }
            else
            {
                    val_21 = 0;
                success = false;
                return (object)true;
            }
        
        }
        protected static string ParseString(char[] json, ref int index, ref bool success)
        {
            int val_17;
            int val_18;
            int val_19;
            var val_20;
            var val_21;
            uint val_8 = 0;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  208);
            val_17 = 1152921553757048592;
            BestHTTP.JSON.Json.EatWhitespace(json:  json, index: ref  val_17);
            val_18 = index;
            index = val_18 + 1;
            val_19 = json.Length;
            if(val_18 >= val_19)
            {
                    val_17 = 0;
                val_19 = json.Length;
            }
            
            if(index == val_19)
            {
                goto label_32;
            }
            
            label_47:
            index = index + 1;
            if(index >= json.Length)
            {
                    val_17 = 0;
            }
            
            val_18 = json[((long)(int)((index + 1))) << 1];
            if(val_18 == '\')
            {
                goto label_5;
            }
            
            if(val_18 == '"')
            {
                goto label_6;
            }
            
            val_20 = val_18;
            goto label_8;
            label_5:
            val_18 = index;
            if(val_18 == json.Length)
            {
                goto label_32;
            }
            
            index = val_18 + 1;
            char val_16 = json[(((index + 1) + 1)) << 1];
            if(val_16 > 'a')
            {
                goto label_11;
            }
            
            if(val_16 == '"')
            {
                goto label_12;
            }
            
            if(val_16 == ('/'))
            {
                goto label_13;
            }
            
            if(val_16 != '\')
            {
                goto label_45;
            }
            
            val_20 = 92;
            goto label_31;
            label_11:
            if((val_16 - 110) > '')
            {
                goto label_17;
            }
            
            var val_17 = 106066472 + ((json[(((index + 1) + 1)) << 1][0] - 110)) << 2;
            val_17 = val_17 + 106066472;
            goto (106066472 + ((json[(((index + 1) + 1)) << 1][0] - 110)) << 2 + 106066472);
            label_12:
            val_20 = 34;
            goto label_31;
            label_13:
            val_20 = 47;
            goto label_31;
            label_17:
            if(val_16 == 'b')
            {
                goto label_24;
            }
            
            if(val_16 != 'f')
            {
                goto label_45;
            }
            
            val_20 = 12;
            goto label_31;
            label_24:
            val_20 = 8;
            label_31:
            label_8:
            System.Text.StringBuilder val_15 = val_1.Append(value:  '');
            label_45:
            if( != json.Length)
            {
                goto label_47;
            }
            
            label_32:
            val_21 = 0;
            success = false;
            return (string)val_21;
            label_6:
            val_21 = val_1;
            return (string)val_21;
        }
        protected static double ParseNumber(char[] json, ref int index, ref bool success)
        {
            BestHTTP.JSON.Json.EatWhitespace(json:  json, index: ref  1152921553757283216);
            int val_3 = (BestHTTP.JSON.Json.GetLastIndexOfNumber(json:  json, index:  index)) + 1;
            success = System.Double.TryParse(s:  0.CreateString(val:  json, startIndex:  index, length:  val_3 - index), style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_7 = 1.28824381310661E-231);
            index = val_3;
            return 0;
        }
        protected static int GetLastIndexOfNumber(char[] json, int index)
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
        protected static void EatWhitespace(char[] json, ref int index)
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
        protected static int LookAhead(char[] json, int index)
        {
            return (int)BestHTTP.JSON.Json.NextToken(json:  json, index: ref  index);
        }
        protected static int NextToken(char[] json, ref int index)
        {
            var val_5;
            int val_6;
            int val_7;
            BestHTTP.JSON.Json.EatWhitespace(json:  json, index: ref  int val_1 = index);
            if(index != json.Length)
            {
                goto label_1;
            }
            
            label_45:
            val_5 = 0;
            return 5;
            label_1:
            val_6 = index;
            if(val_6 >= json.Length)
            {
                    val_6 = index;
            }
            
            char val_5 = json[((long)(int)(index)) << 1];
            index = val_6 + 1;
            if(val_5 > '[')
            {
                goto label_4;
            }
            
            if((val_5 - 34) > '')
            {
                goto label_5;
            }
            
            var val_6 = 106066372;
            val_6 = (106066372 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2) + val_6;
            goto (106066372 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2 + 106066372);
            label_4:
            if(val_5 == ']')
            {
                goto label_7;
            }
            
            if(val_5 == '{')
            {
                goto label_8;
            }
            
            if(val_5 != '}')
            {
                goto label_13;
            }
            
            val_5 = 2;
            return 5;
            label_7:
            val_5 = 4;
            return 5;
            label_8:
            val_5 = 1;
            return 5;
            label_5:
            if(val_5 == '[')
            {
                    val_5 = 3;
                return 5;
            }
            
            label_13:
            index = val_6;
            int val_4 = json.Length - val_6;
            if(val_4 >= 5)
            {
                goto label_15;
            }
            
            if(val_4 != 4)
            {
                goto label_45;
            }
            
            goto label_27;
            label_15:
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
            
            label_27:
            if((json[((index + 5)) << 1]) != 't')
            {
                goto label_36;
            }
            
            int val_18 = index;
            val_18 = val_18 + 1;
            if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'r')
            {
                goto label_36;
            }
            
            int val_20 = index;
            val_20 = val_20 + 2;
            if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'u')
            {
                goto label_36;
            }
            
            int val_22 = index;
            val_22 = val_22 + 3;
            if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'e')
            {
                goto label_36;
            }
            
            val_7 = index;
            val_5 = 9;
            goto label_37;
            label_36:
            if((json[((index + 5)) << 1]) != 'n')
            {
                goto label_45;
            }
            
            int val_25 = index;
            val_25 = val_25 + 1;
            if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'u')
            {
                goto label_45;
            }
            
            int val_27 = index;
            val_27 = val_27 + 2;
            if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'l')
            {
                goto label_45;
            }
            
            int val_29 = index;
            val_29 = val_29 + 3;
            if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'l')
            {
                goto label_45;
            }
            
            val_7 = index;
            val_5 = 11;
            label_37:
            val_7 = val_7 + 4;
            index = val_7;
            return 5;
        }
        protected static bool SerializeValue(object value, System.Text.StringBuilder builder)
        {
            System.Collections.IDictionary val_10;
            string val_12;
            if(value != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            if(value == null)
            {
                goto label_3;
            }
            
            if(value == null)
            {
                goto label_4;
            }
            
            val_10 = value;
            if(val_10 != null)
            {
                goto label_5;
            }
            
            label_4:
            val_10 = 0;
            label_5:
            bool val_2 = BestHTTP.JSON.Json.SerializeObject(anObject:  val_10, builder:  builder);
            goto label_17;
            label_3:
            if(value == null)
            {
                goto label_7;
            }
            
            val_10 = value;
            bool val_3 = BestHTTP.JSON.Json.SerializeArray(anArray:  val_10, builder:  builder);
            goto label_17;
            label_2:
            bool val_4 = BestHTTP.JSON.Json.SerializeString(aString:  value, builder:  builder);
            goto label_28;
            label_7:
            if(value == null)
            {
                goto label_10;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            label_26:
            if(null == null)
            {
                    if(null == null)
            {
                goto label_13;
            }
            
            }
            
            if(null == null)
            {
                goto label_14;
            }
            
            val_10 = 0;
            goto label_17;
            label_10:
            val_12 = "null";
            goto label_22;
            label_11:
            if(null == null)
            {
                goto label_26;
            }
            
            val_12 = "true";
            goto label_22;
            label_14:
            double val_6 = System.Convert.ToDouble(value:  1906651440);
            goto label_25;
            label_13:
            val_12 = "false";
            label_22:
            System.Text.StringBuilder val_7 = builder.Append(value:  val_12);
            goto label_28;
            label_25:
            bool val_9 = BestHTTP.JSON.Json.SerializeNumber(number:  null, builder:  builder);
            label_28:
            val_10 = 1;
            label_17:
            val_10 = val_10 & 1;
            return (bool)val_10;
        }
        protected static bool SerializeObject(System.Collections.IDictionary anObject, System.Text.StringBuilder builder)
        {
            string val_11;
            var val_16;
            System.Text.StringBuilder val_1 = builder.Append(value:  "{");
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.IDictionaryEnumerator val_3 = anObject.GetEnumerator();
            label_27:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_11 = val_3.Key;
            var val_18 = 0;
            val_18 = val_18 + 1;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_10 = builder.Append(value:  ", ");
            }
            
            bool val_11 = BestHTTP.JSON.Json.SerializeString(aString:  val_11, builder:  builder);
            System.Text.StringBuilder val_12 = builder.Append(value:  ":");
            val_16 = 0;
            if((BestHTTP.JSON.Json.SerializeValue(value:  val_3.Value, builder:  builder)) == true)
            {
                goto label_27;
            }
            
            return (bool)val_16;
            label_12:
            System.Text.StringBuilder val_14 = builder.Append(value:  "}");
            val_16 = 1;
            return (bool)val_16;
        }
        protected static bool SerializeArray(System.Collections.IList anArray, System.Text.StringBuilder builder)
        {
            var val_7;
            var val_8;
            var val_11;
            val_7 = 0;
            System.Text.StringBuilder val_1 = builder.Append(value:  "[");
            val_8 = 0;
            label_15:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_7 = 1;
            if(val_8 >= anArray.Count)
            {
                goto label_7;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = 0;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_6 = builder.Append(value:  ", ");
            }
            
            val_11 = 0;
            val_8 = val_8 + 1;
            if((BestHTTP.JSON.Json.SerializeValue(value:  anArray.Item[0], builder:  builder)) == true)
            {
                goto label_15;
            }
            
            return (bool)val_11;
            label_7:
            System.Text.StringBuilder val_8 = builder.Append(value:  "]");
            val_11 = 1;
            return (bool)val_11;
        }
        protected static bool SerializeString(string aString, System.Text.StringBuilder builder)
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
            
            var val_11 = 106066504 + ((val_2[0x0][0] - 8)) << 2;
            val_11 = val_11 + 106066504;
            goto (106066504 + ((val_2[0x0][0] - 8)) << 2 + 106066504);
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
            return true;
        }
        protected static bool SerializeNumber(double number, System.Text.StringBuilder builder)
        {
            System.Text.StringBuilder val_3 = builder.Append(value:  System.Convert.ToString(value:  number, provider:  System.Globalization.CultureInfo.InvariantCulture));
            return true;
        }
        public Json()
        {
        
        }
    
    }

}
