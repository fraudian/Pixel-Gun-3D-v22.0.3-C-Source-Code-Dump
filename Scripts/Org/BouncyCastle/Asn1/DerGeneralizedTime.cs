using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerGeneralizedTime : Asn1Object
    {
        // Fields
        private readonly string time;
        
        // Properties
        public string TimeString { get; }
        private bool HasFractionalSeconds { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.DerGeneralizedTime GetInstance(object obj)
        {
            if(obj == null)
            {
                    return (Org.BouncyCastle.Asn1.DerGeneralizedTime)obj;
            }
            
            return (Org.BouncyCastle.Asn1.DerGeneralizedTime)obj;
        }
        public static Org.BouncyCastle.Asn1.DerGeneralizedTime GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
        {
            var val_6;
            object val_7;
            if(obj.obj == null)
            {
                goto label_2;
            }
            
            val_7 = obj.obj;
            if(isExplicit == false)
            {
                goto label_3;
            }
            
            return Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(obj:  val_7);
            label_2:
            val_7 = 0;
            if(isExplicit == true)
            {
                    return Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(obj:  val_7);
            }
            
            label_3:
            if(val_7 != 0)
            {
                    val_6 = null;
                val_6 = 0;
                val_7 = 0;
            }
            
            .time = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  val_7);
            return (Org.BouncyCastle.Asn1.DerGeneralizedTime)new Org.BouncyCastle.Asn1.DerGeneralizedTime();
        }
        public DerGeneralizedTime(string time)
        {
            this = new System.Object();
            this.time = time;
            System.DateTime val_2 = this.ToDateTime();
        }
        public DerGeneralizedTime(System.DateTime time)
        {
            this = new System.Object();
            this.time = time.dateData;
        }
        internal DerGeneralizedTime(byte[] bytes)
        {
            val_1 = new System.Object();
            this.time = Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  bytes);
        }
        public string get_TimeString()
        {
            return (string)this.time;
        }
        public string GetTime()
        {
            var val_25;
            var val_26;
            if(this.time != null)
            {
                    val_25 = this.time.Length;
            }
            else
            {
                    val_25 = 0.Length;
            }
            
            if(((this.time.Chars[val_25 - 1]) & 65535) != 'Z')
            {
                goto label_3;
            }
            
            if(this.time == null)
            {
                goto label_4;
            }
            
            val_26 = this.time.Length;
            return this.time.Substring(startIndex:  0, length:  val_26 - 1)(this.time.Substring(startIndex:  0, length:  val_26 - 1)) + "GMT+00:00"("GMT+00:00");
            label_3:
            int val_7 = this.time.Length;
            int val_8 = val_7 - 5;
            char val_10 = this.time.Chars[val_8] & 65535;
            if(val_10 != ('-'))
            {
                    if(val_10 != ('+'))
            {
                goto label_9;
            }
            
            }
            
            string[] val_11 = new string[5];
            val_11[0] = this.time.Substring(startIndex:  0, length:  val_8);
            val_11[1] = "GMT";
            val_11[2] = this.time.Substring(startIndex:  val_8, length:  3);
            val_11[3] = ":";
            val_11[4] = this.time.Substring(startIndex:  val_7 - 2);
            return +val_11;
            label_4:
            val_26 = 0.Length;
            return this.time.Substring(startIndex:  0, length:  val_26 - 1)(this.time.Substring(startIndex:  0, length:  val_26 - 1)) + "GMT+00:00"("GMT+00:00");
            label_9:
            string val_25 = this.time;
            val_25 = val_25.Length - 3;
            char val_21 = this.time.Chars[val_25] & 65535;
            if(val_21 == ('-'))
            {
                    return this.time.Substring(startIndex:  0, length:  val_25)(this.time.Substring(startIndex:  0, length:  val_25)) + "GMT" + this.time.Substring(startIndex:  val_25)(this.time.Substring(startIndex:  val_25)) + ":00"(":00");
            }
            
            if(val_21 == ('+'))
            {
                    return this.time.Substring(startIndex:  0, length:  val_25)(this.time.Substring(startIndex:  0, length:  val_25)) + "GMT" + this.time.Substring(startIndex:  val_25)(this.time.Substring(startIndex:  val_25)) + ":00"(":00");
            }
            
            string val_24 = this.CalculateGmtOffset();
            return this.time.Substring(startIndex:  0, length:  val_26 - 1)(this.time.Substring(startIndex:  0, length:  val_26 - 1)) + "GMT+00:00"("GMT+00:00");
        }
        private string CalculateGmtOffset()
        {
            var val_17;
            System.DateTime val_1 = this.ToDateTime();
            System.DateTime val_3 = val_1.dateData.ToUniversalTime();
            val_17 = val_1.dateData.Ticks - val_3.dateData.Ticks;
            if((val_17 & 9223372036854775808) != 0)
            {
                    val_17 = -val_17;
            }
            
            long val_6 = (val_17 >> 26) + (val_17 >> 63);
            string[] val_7 = new string[5];
            int val_8 = X21 >> 63;
            var val_10 = X24 >> 32;
            val_8 = (X21 >> 33) + val_8;
            val_7[0] = "GMT";
            val_10 = val_10 + val_6;
            val_7[1] = ;
            val_10 = (val_10 >> 5) + (val_10 >> 31);
            val_7[2] = Org.BouncyCastle.Asn1.DerGeneralizedTime.Convert(time:  val_8);
            val_7[3] = ":";
            val_7[4] = Org.BouncyCastle.Asn1.DerGeneralizedTime.Convert(time:  val_6 - (val_10 * 60));
            return (string)+val_7;
        }
        private static string Convert(int time)
        {
            if(time > 9)
            {
                    return (string)time.ToString();
            }
            
            string val_1 = "0" + time;
            return (string)time.ToString();
        }
        public System.DateTime ToDateTime()
        {
            string val_28;
            var val_29;
            string val_30;
            string val_31;
            var val_32;
            var val_33;
            val_28 = this.time;
            if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  val_28, suffix:  "Z")) == false)
            {
                goto label_3;
            }
            
            if(this.HasFractionalSeconds == false)
            {
                goto label_4;
            }
            
            if(val_28 == null)
            {
                goto label_5;
            }
            
            val_29 = val_28.Length;
            goto label_6;
            label_3:
            val_30 = this.time;
            if((val_30.IndexOf(value:  '-')) > 0)
            {
                goto label_8;
            }
            
            val_30 = this.time;
            if((val_30.IndexOf(value:  '+')) < 1)
            {
                goto label_10;
            }
            
            label_8:
            val_28 = this.GetTime();
            if(this.HasFractionalSeconds == false)
            {
                goto label_11;
            }
            
            int val_9 = val_28.IndexOf(value:  '.');
            val_31 = "yyyyMMddHHmmss." + val_9.FString(count:  ((Org.BouncyCastle.Utilities.Platform.IndexOf(source:  val_28, value:  "GMT")) - 1) - val_9)(val_9.FString(count:  ((Org.BouncyCastle.Utilities.Platform.IndexOf(source:  val_28, value:  "GMT")) - 1) - val_9)) + "\'GMT\'zzz";
            val_32 = 1;
            return val_19.ParseDateString(s:  val_28, format:  val_31 = val_19, makeUniversal:  false);
            label_4:
            label_21:
            val_31 = "yyyyMMddHHmmss\\Z";
            goto label_16;
            label_11:
            val_32 = 1;
            val_31 = "yyyyMMddHHmmss\'GMT\'zzz";
            return val_19.ParseDateString(s:  val_28, format:  val_31, makeUniversal:  false);
            label_5:
            val_29 = 0.Length;
            label_6:
            int val_15 = val_28.IndexOf(value:  '.');
            string val_19 = "yyyyMMddHHmmss." + val_15.FString(count:  (val_29 - 2) - val_15)(val_15.FString(count:  (val_29 - 2) - val_15)) + "\\Z";
            label_22:
            label_16:
            val_32 = 0;
            return val_19.ParseDateString(s:  val_28, format:  val_31, makeUniversal:  false);
            label_10:
            if(this.HasFractionalSeconds == false)
            {
                goto label_21;
            }
            
            if(val_28 != null)
            {
                    val_33 = val_28.Length;
            }
            else
            {
                    val_33 = 0.Length;
            }
            
            int val_23 = val_28.IndexOf(value:  '.');
            string val_27 = "yyyyMMddHHmmss." + val_23.FString(count:  (val_33 - 1) - val_23)(val_23.FString(count:  (val_33 - 1) - val_23));
            goto label_22;
        }
        private string FString(int count)
        {
            var val_3;
            var val_4;
            System.Text.StringBuilder val_1 = null;
            val_3 = 0;
            val_1 = new System.Text.StringBuilder();
            val_4 = 0;
            goto label_1;
            label_3:
            val_3 = 102;
            System.Text.StringBuilder val_2 = val_1.Append(value:  'f');
            val_4 = 1;
            label_1:
            if(val_4 < count)
            {
                goto label_3;
            }
            
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        private System.DateTime ParseDateString(string s, string format, bool makeUniversal)
        {
            System.Globalization.DateTimeStyles val_9;
            if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  format, suffix:  "Z")) != false)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  Org.BouncyCastle.Utilities.Enums.GetEnumValue(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), s:  "AssumeUniversal"));
                val_9 = mem[val_3] | 16;
            }
            else
            {
                    val_9 = 0;
            }
            
            System.DateTime val_5 = System.DateTime.ParseExact(s:  s, format:  format, provider:  System.Globalization.DateTimeFormatInfo.InvariantInfo, style:  val_9);
            if(makeUniversal == false)
            {
                    return (System.DateTime)val_6.dateData;
            }
            
            System.DateTime val_6 = val_5.dateData.ToUniversalTime();
            return (System.DateTime)val_6.dateData;
        }
        private bool get_HasFractionalSeconds()
        {
            return (bool)((this.time.IndexOf(value:  '.')) == 14) ? 1 : 0;
        }
        private byte[] GetOctets()
        {
            return Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.time);
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  24, bytes:  Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  this.time));
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            if(asn1Object == null)
            {
                    return false;
            }
            
            var val_1 = (((Org.BouncyCastle.Asn1.Asn1Object.__il2cppRuntimeField_typeHierarchy + -9223372029372792832) + -8) == 1152921505542840320) ? asn1Object : 0;
            return false;
        }
        protected override int Asn1GetHashCode()
        {
            if(this.time == null)
            {
                
            }
        
        }
    
    }

}
