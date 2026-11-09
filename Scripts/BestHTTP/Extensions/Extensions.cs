using UnityEngine;

namespace BestHTTP.Extensions
{
    public static class Extensions
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex validIpV4AddressRegex;
        
        // Methods
        public static string AsciiToString(byte[] bytes)
        {
            int val_4;
            System.Text.StringBuilder val_1 = null;
            val_4 = bytes.Length;
            val_1 = new System.Text.StringBuilder(capacity:  val_4);
            if(bytes.Length >= 1)
            {
                    do
            {
                byte val_5 = bytes[0];
                System.Text.StringBuilder val_3 = val_1.Append(value:  (((int)val_5 & 255) >= 0) ? (val_5) : 63);
            }
            while((0 + 1) < bytes.Length);
            
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        public static byte[] GetASCIIBytes(string str)
        {
            var val_7;
            int val_1 = str.Length;
            byte[] val_2 = new byte[0];
            val_7 = 0;
            goto label_2;
            label_7:
            char val_3 = str.Chars[0];
            val_7 = 1;
            val_2[0] = ((val_3 & 65535) < '') ? (val_3) : 63;
            label_2:
            if(val_7 < str.Length)
            {
                goto label_7;
            }
            
            return (System.Byte[])val_2;
        }
        public static void SendAsASCII(System.IO.BinaryWriter stream, string str)
        {
            goto label_0;
            label_4:
            char val_1 = str.Chars[0];
            var val_3 = ((val_1 & 65535) < '') ? (val_1) : 63;
            0 = 1;
            label_0:
            if(0 < str.Length)
            {
                goto label_4;
            }
        
        }
        public static void WriteLine(System.IO.FileStream fs)
        {
            null = null;
            if(fs == null)
            {
                
            }
        
        }
        public static void WriteLine(System.IO.FileStream fs, string line)
        {
            if((BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  line)) == null)
            {
                goto label_3;
            }
            
            label_6:
            BestHTTP.Extensions.Extensions.WriteLine(fs:  fs);
            return;
            label_3:
            if(fs != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public static void WriteLine(System.IO.FileStream fs, string format, object[] values)
        {
            if((BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  System.String.Format(format:  format, args:  values))) == null)
            {
                goto label_3;
            }
            
            label_6:
            BestHTTP.Extensions.Extensions.WriteLine(fs:  fs);
            return;
            label_3:
            if(fs != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public static string GetRequestPathAndQueryURL(System.Uri uri)
        {
            string val_1 = uri.GetComponents(components:  48, format:  1);
            return (string)((System.String.IsNullOrEmpty(value:  val_1)) != true) ? "/" : (val_1);
        }
        public static string[] FindOption(string str, string option)
        {
            System.Char[] val_7;
            var val_8;
            char[] val_2 = new char[1];
            val_7 = val_2;
            val_7[0] = ',';
            val_8 = 0;
            goto label_6;
            label_11:
            val_7 = str.ToLower().Split(separator:  val_2, options:  1)[0];
            if((val_7.Contains(value:  option.ToLower())) == true)
            {
                goto label_9;
            }
            
            val_8 = 1;
            label_6:
            if(val_8 < val_3.Length)
            {
                goto label_11;
            }
            
            return 0;
            label_9:
            char[] val_6 = new char[1];
            val_6[0] = '=';
            if((val_3[0x0] + 32) != 0)
            {
                    return val_3[0x0] + 32.Split(separator:  val_6, options:  1);
            }
            
            return val_3[0x0] + 32.Split(separator:  val_6, options:  1);
        }
        public static void WriteArray(System.IO.Stream stream, byte[] array)
        {
            if(array == null)
            {
                goto label_0;
            }
            
            label_3:
            stream = ???;
            goto typeof(System.IO.Stream).__il2cppRuntimeField_328;
            label_0:
            if(stream != 0)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public static bool IsHostIsAnIPAddress(System.Uri uri)
        {
            var val_5;
            if((System.Uri.op_Equality(uri1:  uri, uri2:  0)) != false)
            {
                    val_5 = 0;
                return (bool)val_5;
            }
            
            if((BestHTTP.Extensions.Extensions.IsIpV4AddressValid(address:  uri.Host)) == false)
            {
                    return BestHTTP.Extensions.Extensions.IsIpV6AddressValid(address:  uri.Host);
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        public static bool IsIpV4AddressValid(string address)
        {
            var val_3;
            if((System.String.IsNullOrEmpty(value:  address)) != false)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            if(BestHTTP.Extensions.Extensions.validIpV4AddressRegex != null)
            {
                    return BestHTTP.Extensions.Extensions.validIpV4AddressRegex.IsMatch(input:  address.Trim());
            }
            
            return BestHTTP.Extensions.Extensions.validIpV4AddressRegex.IsMatch(input:  address.Trim());
        }
        public static bool IsIpV6AddressValid(string address)
        {
            string val_6;
            var val_7;
            val_6 = address;
            System.Net.IPAddress val_2 = 0;
            if((System.String.IsNullOrEmpty(value:  val_6)) != true)
            {
                    if((System.Net.IPAddress.TryParse(ipString:  val_6, address: out  val_2)) != false)
            {
                    val_6 = val_2;
                var val_5 = (val_6.AddressFamily == 23) ? 1 : 0;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public static int ToInt32(string str, int defaultValue = 0)
        {
            if(str == null)
            {
                    return (int)defaultValue;
            }
            
            defaultValue = System.Int32.Parse(s:  str);
            return (int)defaultValue;
        }
        public static long ToInt64(string str, long defaultValue = 0)
        {
            if(str == null)
            {
                    return (long)defaultValue;
            }
            
            defaultValue = System.Int64.Parse(s:  str);
            return (long)defaultValue;
        }
        public static System.DateTime ToDateTime(string str, System.DateTime defaultValue)
        {
            ulong val_3 = defaultValue.dateData;
            if(str == null)
            {
                    return (System.DateTime)val_3;
            }
            
            bool val_1 = System.DateTime.TryParse(s:  str, result: out  new System.DateTime() {dateData = val_3});
            System.DateTime val_2 = val_3.ToUniversalTime();
            val_3 = val_2.dateData;
            return (System.DateTime)val_3;
        }
        public static string ToStrOrEmpty(string str)
        {
            string val_1 = str;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public static string CalculateMD5Hash(string input)
        {
            return BestHTTP.Extensions.Extensions.CalculateMD5Hash(input:  BestHTTP.Extensions.Extensions.GetASCIIBytes(str:  input));
        }
        public static string CalculateMD5Hash(byte[] input)
        {
            string val_6;
            var val_7;
            System.Text.StringBuilder val_3 = null;
            val_6 = 0;
            val_3 = new System.Text.StringBuilder();
            val_7 = 0;
            goto label_2;
            label_6:
            val_6 = System.Security.Cryptography.MD5.Create().ComputeHash(buffer:  input)[0].ToString(format:  "x2");
            System.Text.StringBuilder val_5 = val_3.Append(value:  val_6);
            val_7 = 1;
            label_2:
            if(val_7 < val_2.Length)
            {
                goto label_6;
            }
            
            if(val_3 != null)
            {
                    return (string)val_3;
            }
            
            return (string)val_3;
        }
        internal static string Read(string str, ref int pos, char block, bool needResult = True)
        {
            .block = block;
            return BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775348384, block:  new System.Func<System.Char, System.Boolean>(object:  new Extensions.<>c__DisplayClass19_0(), method:  System.Boolean Extensions.<>c__DisplayClass19_0::<Read>b__0(char ch)), needResult:  needResult);
        }
        internal static string Read(string str, ref int pos, System.Func<char, bool> block, bool needResult = True)
        {
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            val_9 = needResult;
            val_10 = pos;
            if(val_10 >= str.Length)
            {
                goto label_2;
            }
            
            BestHTTP.Extensions.Extensions.SkipWhiteSpace(str:  str, pos: ref  1152921553775494048);
            val_10 = pos;
            val_11 = val_10;
            goto label_5;
            label_10:
            if((block.Invoke(arg:  str.Chars[pos])) == false)
            {
                goto label_8;
            }
            
            val_11 = pos + 1;
            pos = val_11;
            label_5:
            if(val_11 < str.Length)
            {
                goto label_10;
            }
            
            label_8:
            if(val_9 == false)
            {
                goto label_11;
            }
            
            val_9 = pos;
            string val_7 = str.Substring(startIndex:  val_10, length:  val_9 - val_10);
            goto label_13;
            label_2:
            val_12 = System.String.alignConst;
            return (string)val_12;
            label_11:
            val_12 = 0;
            label_13:
            int val_8 = pos;
            val_8 = val_8 + 1;
            pos = val_8;
            return (string)val_12;
        }
        internal static string ReadPossibleQuotedText(string str, ref int pos)
        {
            var val_11;
            int val_12;
            var val_13;
            System.Func<System.Char, System.Boolean> val_15;
            if(str == null)
            {
                goto label_1;
            }
            
            if((str.Chars[pos] & 65535) != '"')
            {
                goto label_2;
            }
            
            string val_4 = BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775647888, block:  '"', needResult:  false);
            val_11 = BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775647888, block:  '"', needResult:  true);
            string val_8 = BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775647888, block:  ',', needResult:  false);
            val_12 = val_11;
            return (string)val_12;
            label_1:
            val_12 = System.String.alignConst;
            return (string)val_12;
            label_2:
            val_13 = null;
            val_13 = null;
            val_15 = Extensions.<>c.<>9__21_0;
            if(val_15 != null)
            {
                    return BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775647888, block:  System.Func<System.Char, System.Boolean> val_9 = null, needResult:  true);
            }
            
            val_15 = val_9;
            val_9 = new System.Func<System.Char, System.Boolean>(object:  Extensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Extensions.<>c::<ReadPossibleQuotedText>b__21_0(char ch));
            Extensions.<>c.<>9__21_0 = val_15;
            return BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553775647888, block:  val_9, needResult:  true);
        }
        internal static void SkipWhiteSpace(string str, ref int pos)
        {
            int val_6 = pos;
            if(val_6 >= str.Length)
            {
                    return;
            }
            
            val_6 = pos;
            goto label_3;
            label_9:
            val_6 = pos + 1;
            pos = val_6;
            label_3:
            if(val_6 >= str.Length)
            {
                    return;
            }
            
            val_6 = str.Chars[pos];
            if((System.Char.IsWhiteSpace(c:  val_6)) == true)
            {
                goto label_9;
            }
        
        }
        internal static string TrimAndLower(string str)
        {
            var val_9;
            char val_10;
            if(str == null)
            {
                    return 0;
            }
            
            int val_1 = str.Length;
            char[] val_2 = new char[0];
            if(str.Length >= 1)
            {
                    val_9 = 0;
                var val_10 = 0;
                do
            {
                val_10 = str.Chars[0];
                if((System.Char.IsWhiteSpace(c:  val_10)) != true)
            {
                    if((System.Char.IsControl(c:  val_10)) != true)
            {
                    val_10 = System.Char.ToLowerInvariant(c:  val_10);
                val_9 = val_9 + 1;
                val_2[0] = val_10;
            }
            
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < str.Length);
            
                return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
            }
            
            val_9 = 0;
            return 0.CreateString(val:  val_2, startIndex:  0, length:  0);
        }
        internal static System.Nullable<char> Peek(string str, int pos)
        {
            var val_3;
            if((pos & 2147483648) == 0)
            {
                    if(str.Length > pos)
            {
                    char val_2 = str.Chars[pos];
                val_3 = 0;
                return (System.Nullable<System.Char>)val_3;
            }
            
            }
            
            val_3 = 0;
            return (System.Nullable<System.Char>)val_3;
        }
        internal static System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> ParseOptionalHeader(string str)
        {
            var val_12;
            System.Func<System.Char, System.Boolean> val_14;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_1 = new System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>();
            if(str == null)
            {
                    return val_1;
            }
            
            int val_4 = 0;
            if(str.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                val_12 = null;
                val_12 = null;
                val_14 = Extensions.<>c.<>9__25_0;
                if(val_14 == null)
            {
                    System.Func<System.Char, System.Boolean> val_3 = null;
                val_14 = val_3;
                val_3 = new System.Func<System.Char, System.Boolean>(object:  Extensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Extensions.<>c::<ParseOptionalHeader>b__25_0(char ch));
                Extensions.<>c.<>9__25_0 = val_14;
            }
            
                .<Key>k__BackingField = BestHTTP.Extensions.Extensions.TrimAndLower(str:  BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_4, block:  val_3, needResult:  true));
                if(((str.Chars[-1]) & 65535) == ('='))
            {
                    .<Value>k__BackingField = BestHTTP.Extensions.Extensions.ReadPossibleQuotedText(str:  str, pos: ref  val_4);
            }
            
                val_1.Add(item:  new BestHTTP.Extensions.HeaderValue());
            }
            while(0 < str.Length);
            
            return val_1;
        }
        internal static System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> ParseQualityParams(string str)
        {
            var val_13;
            System.Func<System.Char, System.Boolean> val_15;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_1 = new System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>();
            if(str == null)
            {
                    return val_1;
            }
            
            int val_4 = 0;
            if(str.Length < 1)
            {
                    return val_1;
            }
            
            do
            {
                val_13 = null;
                val_13 = null;
                val_15 = Extensions.<>c.<>9__26_0;
                if(val_15 == null)
            {
                    System.Func<System.Char, System.Boolean> val_3 = null;
                val_15 = val_3;
                val_3 = new System.Func<System.Char, System.Boolean>(object:  Extensions.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Extensions.<>c::<ParseQualityParams>b__26_0(char ch));
                Extensions.<>c.<>9__26_0 = val_15;
            }
            
                .<Key>k__BackingField = BestHTTP.Extensions.Extensions.TrimAndLower(str:  BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_4, block:  val_3, needResult:  true));
                if(((str.Chars[-1]) & 65535) == ';')
            {
                    string val_10 = BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_4, block:  '=', needResult:  false);
                .<Value>k__BackingField = BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_4, block:  ',', needResult:  true);
            }
            
                val_1.Add(item:  new BestHTTP.Extensions.HeaderValue());
            }
            while(0 < str.Length);
            
            return val_1;
        }
        public static void ReadBuffer(System.IO.Stream stream, byte[] buffer)
        {
            goto label_7;
            label_4:
            if(stream != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_7:
            if(buffer == null)
            {
                goto label_4;
            }
            
            label_3:
            int val_1 = buffer.Length - 0;
            if(stream <= 0)
            {
                goto label_6;
            }
            
            if(null < buffer.Length)
            {
                goto label_7;
            }
            
            return;
            label_6:
            System.Exception val_2 = BestHTTP.Extensions.ExceptionHelper.ServerClosedTCPStream();
        }
        public static void WriteAll(System.IO.MemoryStream ms, byte[] buffer)
        {
            if(buffer == null)
            {
                goto label_0;
            }
            
            label_3:
            ms = ???;
            goto typeof(System.IO.MemoryStream).__il2cppRuntimeField_328;
            label_0:
            if(ms != 0)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public static void WriteString(System.IO.MemoryStream ms, string str)
        {
            BestHTTP.Extensions.Extensions.WriteAll(ms:  ms, buffer:  System.Text.Encoding.UTF8);
        }
        public static void WriteLine(System.IO.MemoryStream ms)
        {
            null = null;
            BestHTTP.Extensions.Extensions.WriteAll(ms:  ms, buffer:  BestHTTP.HTTPRequest.EOL);
        }
        public static void WriteLine(System.IO.MemoryStream ms, string str)
        {
            BestHTTP.Extensions.Extensions.WriteString(ms:  ms, str:  str);
            BestHTTP.Extensions.Extensions.WriteLine(ms:  ms);
        }
        private static Extensions()
        {
            BestHTTP.Extensions.Extensions.validIpV4AddressRegex = new System.Text.RegularExpressions.Regex(pattern:  "\\b(?:\\d{1,3}\\.){3}\\d{1,3}\\b", options:  1);
        }
    
    }

}
