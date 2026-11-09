using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X962Parameters : Asn1Encodable, IAsn1Choice
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1Object _params;
        
        // Properties
        public bool IsNamedCurve { get; }
        public bool IsImplicitlyCA { get; }
        public Org.BouncyCastle.Asn1.Asn1Object Parameters { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.X962Parameters GetInstance(object obj)
        {
            var val_10;
            string val_11;
            System.Byte[] val_12;
            Org.BouncyCastle.Asn1.Asn1Encodable val_13;
            var val_15;
            var val_16;
            string val_17;
            val_10 = obj;
            if(val_10 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X962Parameters)val_13;
            }
            
            val_11 = 1152921505721910208;
            if(val_10 != null)
            {
                    val_12 = val_10;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
                val_13 = new Org.BouncyCastle.Asn1.X9.X962Parameters();
                val_13 = new Org.BouncyCastle.Asn1.Asn1Encodable();
                ._params = Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(data:  val_12);
                return (Org.BouncyCastle.Asn1.X9.X962Parameters)val_13;
            }
            
            val_15 = 1152921553485321056;
            val_16 = new System.ArgumentException(message:  "unknown object in getInstance()");
            mem[8] = null;
            val_17 = 8;
        }
        public X962Parameters(Org.BouncyCastle.Asn1.X9.X9ECParameters ecParameters)
        {
            this._params = ecParameters;
        }
        public X962Parameters(Org.BouncyCastle.Asn1.DerObjectIdentifier namedCurve)
        {
            this._params = namedCurve;
        }
        public X962Parameters(Org.BouncyCastle.Asn1.Asn1Object obj)
        {
            this._params = obj;
        }
        public bool get_IsNamedCurve()
        {
            var val_2 = 0;
            return (bool);
        }
        public bool get_IsImplicitlyCA()
        {
            var val_2 = 0;
            return (bool);
        }
        public Org.BouncyCastle.Asn1.Asn1Object get_Parameters()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this._params;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            return (Org.BouncyCastle.Asn1.Asn1Object)this._params;
        }
    
    }

}
