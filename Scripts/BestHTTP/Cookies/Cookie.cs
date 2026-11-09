using UnityEngine;

namespace BestHTTP.Cookies
{
    public sealed class Cookie : IComparable<BestHTTP.Cookies.Cookie>, IEquatable<BestHTTP.Cookies.Cookie>
    {
        // Fields
        private const int Version = 1;
        private string <Name>k__BackingField;
        private string <Value>k__BackingField;
        private System.DateTime <Date>k__BackingField;
        private System.DateTime <LastAccess>k__BackingField;
        private System.DateTime <Expires>k__BackingField;
        private long <MaxAge>k__BackingField;
        private bool <IsSession>k__BackingField;
        private string <Domain>k__BackingField;
        private string <Path>k__BackingField;
        private bool <IsSecure>k__BackingField;
        private bool <IsHttpOnly>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        public string Value { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime LastAccess { get; set; }
        public System.DateTime Expires { get; set; }
        public long MaxAge { get; set; }
        public bool IsSession { get; set; }
        public string Domain { get; set; }
        public string Path { get; set; }
        public bool IsSecure { get; set; }
        public bool IsHttpOnly { get; set; }
        
        // Methods
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public string get_Value()
        {
            return (string)this.<Value>k__BackingField;
        }
        private void set_Value(string value)
        {
            this.<Value>k__BackingField = value;
        }
        public System.DateTime get_Date()
        {
            return (System.DateTime)this.<Date>k__BackingField;
        }
        internal void set_Date(System.DateTime value)
        {
            this.<Date>k__BackingField = value;
        }
        public System.DateTime get_LastAccess()
        {
            return (System.DateTime)this.<LastAccess>k__BackingField;
        }
        public void set_LastAccess(System.DateTime value)
        {
            this.<LastAccess>k__BackingField = value;
        }
        public System.DateTime get_Expires()
        {
            return (System.DateTime)this.<Expires>k__BackingField;
        }
        private void set_Expires(System.DateTime value)
        {
            this.<Expires>k__BackingField = value;
        }
        public long get_MaxAge()
        {
            return (long)this.<MaxAge>k__BackingField;
        }
        private void set_MaxAge(long value)
        {
            this.<MaxAge>k__BackingField = value;
        }
        public bool get_IsSession()
        {
            return (bool)this.<IsSession>k__BackingField;
        }
        private void set_IsSession(bool value)
        {
            this.<IsSession>k__BackingField = value;
        }
        public string get_Domain()
        {
            return (string)this.<Domain>k__BackingField;
        }
        private void set_Domain(string value)
        {
            this.<Domain>k__BackingField = value;
        }
        public string get_Path()
        {
            return (string)this.<Path>k__BackingField;
        }
        private void set_Path(string value)
        {
            this.<Path>k__BackingField = value;
        }
        public bool get_IsSecure()
        {
            return (bool)this.<IsSecure>k__BackingField;
        }
        private void set_IsSecure(bool value)
        {
            this.<IsSecure>k__BackingField = value;
        }
        public bool get_IsHttpOnly()
        {
            return (bool)this.<IsHttpOnly>k__BackingField;
        }
        private void set_IsHttpOnly(bool value)
        {
            this.<IsHttpOnly>k__BackingField = value;
        }
        public Cookie(string name, string value)
        {
            this.<Name>k__BackingField = name;
            this.<Value>k__BackingField = value;
            this.<Domain>k__BackingField = System.String.alignConst;
            this.<Path>k__BackingField = "/";
        }
        public Cookie(string name, string value, string path)
        {
            this.<Name>k__BackingField = name;
            this.<Value>k__BackingField = value;
            this.<Domain>k__BackingField = System.String.alignConst;
            this.<Path>k__BackingField = path;
        }
        public Cookie(string name, string value, string path, string domain)
        {
            this.<Name>k__BackingField = name;
            this.<Value>k__BackingField = value;
            this.<Domain>k__BackingField = domain;
            this.<Path>k__BackingField = path;
        }
        public Cookie(System.Uri uri, string name, string value, System.DateTime expires, bool isSession = True)
        {
            string val_6;
            if(uri != null)
            {
                    val_6 = uri.AbsolutePath;
            }
            else
            {
                    val_6 = 0.AbsolutePath;
            }
            
            this.<Name>k__BackingField = name;
            this.<Value>k__BackingField = value;
            this.<Domain>k__BackingField = uri.Host;
            this.<Path>k__BackingField = val_6;
            this.<Expires>k__BackingField = expires;
            this.<IsSession>k__BackingField = isSession;
            System.DateTime val_5 = System.DateTime.UtcNow;
            this.<Date>k__BackingField = val_5;
        }
        public Cookie(System.Uri uri, string name, string value, long maxAge = -1, bool isSession = True)
        {
            string val_6;
            if(uri != null)
            {
                    val_6 = uri.AbsolutePath;
            }
            else
            {
                    val_6 = 0.AbsolutePath;
            }
            
            this.<Name>k__BackingField = name;
            this.<Value>k__BackingField = value;
            this.<Domain>k__BackingField = uri.Host;
            this.<Path>k__BackingField = val_6;
            this.<MaxAge>k__BackingField = maxAge;
            this.<IsSession>k__BackingField = isSession;
            System.DateTime val_5 = System.DateTime.UtcNow;
            this.<Date>k__BackingField = val_5;
        }
        internal Cookie()
        {
            this.<IsSession>k__BackingField = true;
            this.<MaxAge>k__BackingField = 0;
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.<LastAccess>k__BackingField = val_1;
        }
        public bool WillExpireInTheFuture()
        {
            System.DateTime val_9;
            ulong val_10;
            val_9 = this;
            if((this.<IsSession>k__BackingField) != false)
            {
                    val_10 = 1;
                return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_6.dateData});
            }
            
            if((this.<MaxAge>k__BackingField) != 1)
            {
                    System.DateTime val_1 = System.DateTime.UtcNow;
                System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime() {dateData = this.<Date>k__BackingField});
                var val_5 = ((System.Math.Max(val1:  0, val2:  (long)val_2._ticks.TotalSeconds)) < (this.<MaxAge>k__BackingField)) ? 1 : 0;
                return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_6.dateData});
            }
            
            val_9 = this.<Expires>k__BackingField;
            System.DateTime val_6 = System.DateTime.UtcNow;
            val_10 = val_9;
            return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_6.dateData});
        }
        public uint GuessSize()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if((this.<Name>k__BackingField) != null)
            {
                    val_10 = ((this.<Name>k__BackingField.Length) << 1) + 35;
            }
            else
            {
                    val_10 = 35;
            }
            
            if((this.<Value>k__BackingField) != null)
            {
                    val_11 = (this.<Value>k__BackingField.Length) << 1;
            }
            else
            {
                    val_11 = 0;
            }
            
            if((this.<Domain>k__BackingField) != null)
            {
                    val_12 = (this.<Domain>k__BackingField.Length) << 1;
            }
            else
            {
                    val_12 = 0;
            }
            
            if((this.<Path>k__BackingField) != null)
            {
                    val_13 = (this.<Path>k__BackingField.Length) << 1;
            }
            else
            {
                    val_13 = 0;
            }
            
            var val_6 = 35 + val_11;
            val_6 = val_6 + val_12;
            return (uint)val_6 + val_13;
        }
        public static BestHTTP.Cookies.Cookie Parse(string header, System.Uri defaultDomain)
        {
            var val_5;
            var val_40;
            string val_41;
            string val_42;
            var val_43;
            var val_44;
            BestHTTP.Cookies.Cookie val_1 = null;
            val_40 = val_1;
            val_1 = new BestHTTP.Cookies.Cookie();
            List.Enumerator<T> val_3 = BestHTTP.Cookies.Cookie.ParseCookieHeader(str:  header).GetEnumerator();
            goto label_51;
            label_54:
            string val_6 = val_5.丐丏七丌丕丗业且上();
            string val_8 = val_6.Key.ToLowerInvariant();
            if((System.String.op_Equality(a:  val_8, b:  "path")) == true)
            {
                goto label_5;
            }
            
            if((System.String.op_Equality(a:  val_8, b:  "domain")) == true)
            {
                goto label_6;
            }
            
            if((System.String.op_Equality(a:  val_8, b:  "expires")) == false)
            {
                goto label_7;
            }
            
            System.DateTime val_13 = System.DateTime.FromBinary(dateData:  0);
            System.DateTime val_14 = BestHTTP.Extensions.Extensions.ToDateTime(str:  val_6.Value, defaultValue:  new System.DateTime() {dateData = val_13.dateData});
            if(val_40 == null)
            {
                goto label_13;
            }
            
            .<Expires>k__BackingField = val_14;
            goto label_24;
            label_7:
            if((System.String.op_Equality(a:  val_8, b:  "max-age")) == false)
            {
                goto label_15;
            }
            
            long val_17 = BestHTTP.Extensions.Extensions.ToInt64(str:  val_6.Value, defaultValue:  0);
            if(val_40 == null)
            {
                goto label_19;
            }
            
            .<MaxAge>k__BackingField = val_17;
            goto label_24;
            label_15:
            if((System.String.op_Equality(a:  val_8, b:  "secure")) == false)
            {
                goto label_21;
            }
            
            .<IsSecure>k__BackingField = true;
            goto label_51;
            label_13:
            .<Expires>k__BackingField = val_14;
            goto label_24;
            label_21:
            if((System.String.op_Equality(a:  val_8, b:  "httponly")) == false)
            {
                goto label_25;
            }
            
            .<IsHttpOnly>k__BackingField = true;
            goto label_51;
            label_19:
            .<MaxAge>k__BackingField = val_17;
            label_24:
            .<IsSession>k__BackingField = false;
            goto label_51;
            label_25:
            .<Name>k__BackingField = val_6.Key;
            .<Value>k__BackingField = val_6.Value;
            goto label_51;
            label_5:
            if(((System.String.IsNullOrEmpty(value:  val_6.Value)) == true) || ((val_6.Value.StartsWith(value:  "/")) == false))
            {
                goto label_37;
            }
            
            val_41 = val_6.Value;
            .<Path>k__BackingField = val_41;
            if(val_40 != null)
            {
                goto label_50;
            }
            
            goto label_41;
            label_6:
            if((System.String.IsNullOrEmpty(value:  val_6.Value)) == true)
            {
                goto label_56;
            }
            
            if((val_6.Value.StartsWith(value:  ".")) == false)
            {
                goto label_46;
            }
            
            val_42 = val_6.Value.Substring(startIndex:  1);
            goto label_49;
            label_37:
            val_41 = "/";
            if(val_40 != null)
            {
                goto label_50;
            }
            
            label_41:
            label_50:
            .<Path>k__BackingField = val_41;
            goto label_51;
            label_46:
            val_42 = val_6.Value;
            label_49:
            .<Domain>k__BackingField = val_42;
            label_51:
            if((1995934688 & 1) != 0)
            {
                goto label_54;
            }
            
            label_56:
            val_43 = 0;
            val_44 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_97;
            }
            
            if(403 != 496)
            {
                goto label_98;
            }
            
            val_40 = 0;
            return (BestHTTP.Cookies.Cookie)val_40;
            label_97:
            if( == true)
            {
                goto label_100;
            }
            
            goto label_103;
            label_98:
            if(( == false) || (403 == 403))
            {
                goto label_103;
            }
            
            label_100:
            label_103:
            if(BestHTTP.HTTPManager.EnablePrivateBrowsing != false)
            {
                    .<IsSession>k__BackingField = true;
            }
            
            if((System.String.IsNullOrEmpty(value:  (BestHTTP.Cookies.Cookie)[1152921553847474240].<Domain>k__BackingField)) != false)
            {
                    .<Domain>k__BackingField = defaultDomain.Host;
            }
            
            if((System.String.IsNullOrEmpty(value:  (BestHTTP.Cookies.Cookie)[1152921553847474240].<Path>k__BackingField)) != false)
            {
                    .<Path>k__BackingField = defaultDomain.AbsolutePath;
            }
            
            System.DateTime val_39 = System.DateTime.UtcNow;
            .<Date>k__BackingField = val_39;
            .<LastAccess>k__BackingField = val_39;
            return (BestHTTP.Cookies.Cookie)val_40;
        }
        internal void SaveTo(System.IO.BinaryWriter stream)
        {
            if((this.<Path>k__BackingField) != null)
            {
                    return;
            }
        
        }
        internal void LoadFrom(System.IO.BinaryReader stream)
        {
            if(stream != null)
            {
                    this.<Name>k__BackingField = stream;
            }
            else
            {
                    this.<Name>k__BackingField = stream;
            }
            
            this.<Value>k__BackingField = stream;
            System.DateTime val_1 = System.DateTime.FromBinary(dateData:  stream);
            this.<Date>k__BackingField = val_1;
            System.DateTime val_2 = System.DateTime.FromBinary(dateData:  stream);
            this.<LastAccess>k__BackingField = val_2;
            System.DateTime val_3 = System.DateTime.FromBinary(dateData:  stream);
            this.<Expires>k__BackingField = val_3;
            this.<MaxAge>k__BackingField = stream;
            this.<IsSession>k__BackingField = stream & 1;
            this.<Domain>k__BackingField = stream;
            this.<Path>k__BackingField = stream;
            this.<IsSecure>k__BackingField = stream & 1;
            this.<IsHttpOnly>k__BackingField = stream & 1;
        }
        public override string ToString()
        {
            return this.<Name>k__BackingField(this.<Name>k__BackingField) + "="("=") + this.<Value>k__BackingField(this.<Value>k__BackingField);
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return false;
            }
            
            obj = (null == null) ? obj : 0;
            return this.Equals(cookie:  obj);
        }
        public bool Equals(BestHTTP.Cookies.Cookie cookie)
        {
            string val_3;
            string val_4;
            var val_5;
            val_3 = cookie;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            if(this == val_3)
            {
                goto label_8;
            }
            
            val_4 = this.<Name>k__BackingField;
            if((val_4.Equals(value:  cookie.<Name>k__BackingField, comparisonType:  4)) == false)
            {
                goto label_6;
            }
            
            val_4 = this.<Domain>k__BackingField;
            if(val_4 == null)
            {
                    if((cookie.<Domain>k__BackingField) == null)
            {
                goto label_5;
            }
            
            }
            
            if((val_4.Equals(value:  cookie.<Domain>k__BackingField, comparisonType:  4)) == false)
            {
                goto label_6;
            }
            
            label_5:
            val_3 = cookie.<Path>k__BackingField;
            if((this.<Path>k__BackingField) != null)
            {
                    return this.<Path>k__BackingField.Equals(value:  val_3, comparisonType:  4);
            }
            
            if(val_3 == null)
            {
                goto label_8;
            }
            
            return this.<Path>k__BackingField.Equals(value:  val_3, comparisonType:  4);
            label_6:
            val_5 = 0;
            return (bool)val_5;
            label_8:
            val_5 = 1;
            return (bool)val_5;
        }
        public override int GetHashCode()
        {
            if(this == null)
            {
                
            }
        
        }
        private static string ReadValue(string str, ref int pos)
        {
            if(str == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  1152921553848487536, block:  ';', needResult:  true);
        }
        private static System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> ParseCookieHeader(string str)
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
                val_15 = Cookie.<>c.<>9__61_0;
                if(val_15 == null)
            {
                    System.Func<System.Char, System.Boolean> val_3 = null;
                val_15 = val_3;
                val_3 = new System.Func<System.Char, System.Boolean>(object:  Cookie.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Cookie.<>c::<ParseCookieHeader>b__61_0(char ch));
                Cookie.<>c.<>9__61_0 = val_15;
            }
            
                BestHTTP.Extensions.HeaderValue val_7 = new BestHTTP.Extensions.HeaderValue(key:  BestHTTP.Extensions.Extensions.Read(str:  str, pos: ref  val_4, block:  val_3, needResult:  true).Trim());
                if(0 < str.Length)
            {
                    if(((str.Chars[-1]) & 65535) == ('='))
            {
                    val_7.Value = BestHTTP.Cookies.Cookie.ReadValue(str:  str, pos: ref  val_4);
            }
            
            }
            
                val_1.Add(item:  val_7);
            }
            while(0 < str.Length);
            
            return val_1;
        }
        public int CompareTo(BestHTTP.Cookies.Cookie other)
        {
            if(other != null)
            {
                    return 1997246760;
            }
            
            return 1997246760;
        }
    
    }

}
