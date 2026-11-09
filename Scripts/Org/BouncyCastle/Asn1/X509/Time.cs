using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class Time : Asn1Encodable, IAsn1Choice
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1Object time;
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.Time GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj:  obj.GetObject());
        }
        public Time(Org.BouncyCastle.Asn1.Asn1Object time)
        {
            var val_4;
            if(time != null)
            {
                    this.time = time;
                return;
            }
            
            System.ArgumentNullException val_3 = null;
            val_4 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "time");
        }
        public Time(System.DateTime date)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_9;
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            string val_2 = date.dateData + "Z";
            if(((System.Int32.Parse(s:  val_2.Substring(startIndex:  0, length:  4))) - 1950) < 100)
            {
                    Org.BouncyCastle.Asn1.DerUtcTime val_7 = null;
                val_9 = val_7;
                val_7 = new Org.BouncyCastle.Asn1.DerUtcTime(time:  val_2.Substring(startIndex:  2));
            }
            else
            {
                    Org.BouncyCastle.Asn1.DerGeneralizedTime val_8 = null;
                val_9 = val_8;
                val_8 = new Org.BouncyCastle.Asn1.DerGeneralizedTime(time:  val_2);
            }
            
            this.time = val_9;
        }
        public static Org.BouncyCastle.Asn1.X509.Time GetInstance(object obj)
        {
            object val_10;
            Org.BouncyCastle.Asn1.Asn1Object val_11;
            var val_12;
            val_10 = obj;
            if(val_10 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.Time)val_12;
            }
            
            val_11 = 0;
            new Org.BouncyCastle.Asn1.X509.Time() = new Org.BouncyCastle.Asn1.X509.Time(time:  val_11);
            val_12 = new Org.BouncyCastle.Asn1.X509.Time();
            return (Org.BouncyCastle.Asn1.X509.Time)val_12;
        }
        public string GetTime()
        {
            Org.BouncyCastle.Asn1.Asn1Object val_6 = this.time;
            if(val_6 != null)
            {
                    val_6 = 0;
                return (string)val_6.GetTime();
            }
            
            return (string)val_6.GetTime();
        }
        public System.DateTime ToDateTime()
        {
            Org.BouncyCastle.Asn1.Asn1Object val_9 = this.time;
            if(val_9 != null)
            {
                
            }
            
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            System.DateTime val_5 = val_9.ToDateTime();
            return (System.DateTime)val_5.dateData;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.time;
        }
        public override string ToString()
        {
            return this.GetTime();
        }
    
    }

}
