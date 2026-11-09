using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public abstract class X509NameEntryConverter
    {
        // Methods
        protected Org.BouncyCastle.Asn1.Asn1Object ConvertHexEncoded(string hexString, int offset)
        {
            return Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  hexString.Substring(startIndex:  offset)));
        }
        protected bool CanBePrintable(string str)
        {
            return Org.BouncyCastle.Asn1.DerPrintableString.IsPrintableString(str:  str);
        }
        public abstract Org.BouncyCastle.Asn1.Asn1Object GetConvertedValue(Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string value); // 0
        protected X509NameEntryConverter()
        {
        
        }
    
    }

}
