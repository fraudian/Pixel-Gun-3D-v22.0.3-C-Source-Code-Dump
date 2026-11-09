using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class X509DefaultEntryConverter : X509NameEntryConverter
    {
        // Methods
        public override Org.BouncyCastle.Asn1.Asn1Object GetConvertedValue(Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string value)
        {
            string val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_23 = value;
            if(val_23.Length != 0)
            {
                    val_24 = 0;
                char val_2 = val_23.Chars[0];
                if((val_2 & 65535) == '#')
            {
                    val_25 = val_2.ConvertHexEncoded(hexString:  val_23, offset:  1);
                return (Org.BouncyCastle.Asn1.Asn1Object)val_25;
            }
            
            }
            
            if(val_23.Length != 0)
            {
                    val_24 = 0;
                if((val_23.Chars[0] & 65535) == '\')
            {
                    val_24 = 0;
                val_23 = val_23.Substring(startIndex:  1);
            }
            
            }
            
            val_26 = null;
            val_26 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress)) == true)
            {
                goto label_14;
            }
            
            val_27 = null;
            val_27 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.DC)) == false)
            {
                goto label_17;
            }
            
            label_14:
            Org.BouncyCastle.Asn1.DerIA5String val_11 = null;
            val_25 = val_11;
            val_11 = new Org.BouncyCastle.Asn1.DerIA5String(str:  val_23);
            return (Org.BouncyCastle.Asn1.Asn1Object)val_25;
            label_17:
            val_28 = null;
            val_28 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.DateOfBirth)) != false)
            {
                    Org.BouncyCastle.Asn1.DerGeneralizedTime val_13 = new Org.BouncyCastle.Asn1.DerGeneralizedTime(time:  val_23);
                return (Org.BouncyCastle.Asn1.Asn1Object)val_25;
            }
            
            val_29 = null;
            val_29 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.C)) == true)
            {
                goto label_30;
            }
            
            val_30 = null;
            val_30 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.SerialNumber)) == true)
            {
                goto label_30;
            }
            
            val_31 = null;
            val_31 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.DnQualifier)) == true)
            {
                goto label_30;
            }
            
            val_32 = null;
            val_32 = null;
            if((oid.Equals(obj:  Org.BouncyCastle.Asn1.X509.X509Name.TelephoneNumber)) == false)
            {
                goto label_33;
            }
            
            label_30:
            Org.BouncyCastle.Asn1.DerPrintableString val_18 = new Org.BouncyCastle.Asn1.DerPrintableString(str:  val_23);
            return (Org.BouncyCastle.Asn1.Asn1Object)val_25;
            label_33:
            Org.BouncyCastle.Asn1.DerUtf8String val_19 = new Org.BouncyCastle.Asn1.DerUtf8String(str:  val_23);
            return (Org.BouncyCastle.Asn1.Asn1Object)val_25;
        }
        public X509DefaultEntryConverter()
        {
            val_1 = new System.Object();
        }
    
    }

}
