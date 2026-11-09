using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerUtcTime : Asn1Object
    {
        // Fields
        private readonly string time;
        
        // Properties
        public string TimeString { get; }
        public string AdjustedTime { get; }
        public string AdjustedTimeString { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerUtcTime GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerUtcTime)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerUtcTime)obj;
        }
        public static Org.BouncyCastle.Asn1.DerUtcTime GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            var val_7;
            object val_8;
            val_7 = 0;
            val_8 = obj.GetObject();
            if(isExplicit != false)
            {
                    return Org.BouncyCastle.Asn1.DerUtcTime.GetInstance(obj:  val_8);
            }
            
            if(val_8 != null)
            {
                    val_7 = null;
                val_7 = 0;
                val_8 = 0;
            }
            
            .time = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  val_8);
            return (Org.BouncyCastle.Asn1.DerUtcTime)new Org.BouncyCastle.Asn1.DerUtcTime();
        }
        public DerUtcTime(string time)
        {
            var val_6;
            if(time != null)
            {
                    this.time = time;
                System.DateTime val_1 = this.ToDateTime();
                return;
            }
            
            label_4:
            val_6 = new System.ArgumentNullException(paramName:  "time");
            if(0 != 1)
            {
                goto label_2;
            }
            
            if((null & 1) == 0)
            {
                goto label_3;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "invalid date string: "("invalid date string: ") + 1152921504617017344.Message);
            goto label_4;
            label_3:
            mem[8] = null;
            val_6 = 8;
            label_2:
        }
        public DerUtcTime(System.DateTime time)
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            this.time = time.dateData + "Z";
        }
        internal DerUtcTime(byte[] bytes)
        {
            this.time = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  bytes);
        }
        public System.DateTime ToDateTime()
        {
            string val_1 = this.TimeString;
            return val_1.ParseDateString(dateStr:  val_1, formatStr:  "yyMMddHHmmss\'GMT\'zzz");
        }
        public System.DateTime ToAdjustedDateTime()
        {
            string val_1 = this.AdjustedTimeString;
            return val_1.ParseDateString(dateStr:  val_1, formatStr:  "yyyyMMddHHmmss\'GMT\'zzz");
        }
        private System.DateTime ParseDateString(string dateStr, string formatStr)
        {
            System.DateTime val_2 = System.DateTime.ParseExact(s:  dateStr, format:  formatStr, provider:  System.Globalization.DateTimeFormatInfo.InvariantInfo);
            System.DateTime val_3 = val_2.dateData.ToUniversalTime();
            return (System.DateTime)val_3.dateData;
        }
        public string get_TimeString()
        {
            var val_17;
            string val_18;
            var val_19;
            string val_21;
            if(((this.time.IndexOf(value:  '-')) & 2147483648) != 0)
            {
                    if(((this.time.IndexOf(value:  '+')) & 2147483648) != 0)
            {
                goto label_4;
            }
            
            }
            
            val_17 = this.time.IndexOf(value:  '-');
            if((val_17 & 2147483648) != 0)
            {
                    val_17 = this.time.IndexOf(value:  '+');
            }
            
            val_18 = this.time;
            if(val_17 == (val_18.Length - 3))
            {
                    val_18 = val_18 + "00";
            }
            
            string[] val_8 = new string[5];
            if(val_17 == 10)
            {
                    val_8[0] = val_18.Substring(startIndex:  0, length:  10);
                val_8[1] = "00GMT";
                val_8[2] = val_18.Substring(startIndex:  10, length:  3);
                val_8[3] = ":";
                val_19 = 13;
            }
            else
            {
                    val_8[0] = val_18.Substring(startIndex:  0, length:  12);
                val_8[1] = "GMT";
                val_8[2] = val_18.Substring(startIndex:  12, length:  3);
                val_8[3] = ":";
                val_19 = 15;
            }
            
            val_8[4] = val_18.Substring(startIndex:  15, length:  2);
            return +val_8;
            label_4:
            if(this.time.Length == 11)
            {
                    string val_15 = this.time.Substring(startIndex:  0, length:  10);
                val_21 = "00GMT+00:00";
                return this.time.Substring(startIndex:  0, length:  12)(this.time.Substring(startIndex:  0, length:  12)) + val_21;
            }
            
            val_21 = "GMT+00:00";
            return this.time.Substring(startIndex:  0, length:  12)(this.time.Substring(startIndex:  0, length:  12)) + val_21;
        }
        public string get_AdjustedTime()
        {
            return this.AdjustedTimeString;
        }
        public string get_AdjustedTimeString()
        {
            string val_1 = this.TimeString;
            return ((val_1.Chars[0] & 65535) < '5') ? "20" : "19"(((val_1.Chars[0] & 65535) < '5') ? "20" : "19") + val_1;
        }
        private byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.time);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  23, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.time));
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Asn1.DerUtcTime.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? asn1Object : 0;
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            if(this.time == null)
            {
                
            }
        
        }
        public override string ToString()
        {
            return (string)this.time;
        }
    
    }

}
