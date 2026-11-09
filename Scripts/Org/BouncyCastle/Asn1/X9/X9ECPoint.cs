using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X9ECPoint : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1OctetString encoding;
        private Org.BouncyCastle.Math.EC.ECCurve c;
        private Org.BouncyCastle.Math.EC.ECPoint p;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECPoint Point { get; }
        public bool IsPointCompressed { get; }
        
        // Methods
        public X9ECPoint(Org.BouncyCastle.Math.EC.ECPoint p)
        {
        
        }
        public X9ECPoint(Org.BouncyCastle.Math.EC.ECPoint p, bool compressed)
        {
            this.p = p;
            bool val_1 = compressed;
            this.encoding = new Org.BouncyCastle.Asn1.DerOctetString(str:  p);
        }
        public X9ECPoint(Org.BouncyCastle.Math.EC.ECCurve c, byte[] encoding)
        {
            this.c = c;
            this.encoding = new Org.BouncyCastle.Asn1.DerOctetString(str:  Org.BouncyCastle.Utilities.Arrays.Clone(data:  encoding));
        }
        public X9ECPoint(Org.BouncyCastle.Math.EC.ECCurve c, Org.BouncyCastle.Asn1.Asn1OctetString s)
        {
            if(s != null)
            {
                    return;
            }
        
        }
        public byte[] GetPointEncoding()
        {
            if(this.encoding != null)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.encoding);
            }
            
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.encoding);
        }
        public Org.BouncyCastle.Math.EC.ECPoint get_Point()
        {
            Org.BouncyCastle.Math.EC.ECPoint val_1 = this.p;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            val_1 = this.c;
            this.p = val_1;
            return val_1;
        }
        public bool get_IsPointCompressed()
        {
            Org.BouncyCastle.Asn1.Asn1OctetString val_2 = this.encoding;
            if(val_2 == null)
            {
                    return (bool)(null == 3) ? 1 : 0;
            }
            
            if(null != null)
            {
                    if(null != 2)
            {
                    return (bool)(null == 3) ? 1 : 0;
            }
            
                val_2 = 1;
                return (bool)(null == 3) ? 1 : 0;
            }
            
            val_2 = 0;
            return (bool)(null == 3) ? 1 : 0;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this.encoding;
        }
    
    }

}
