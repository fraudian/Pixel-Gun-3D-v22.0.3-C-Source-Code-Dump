using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerNull : Asn1Null
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.DerNull Instance;
        private byte[] zeroBytes;
        
        // Methods
        public DerNull()
        {
            this.zeroBytes = new byte[0];
            this = new System.Object();
        }
        protected internal DerNull(int dummy)
        {
            this.zeroBytes = new byte[0];
            this = new System.Object();
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            derOut.WriteEncoded(tag:  5, bytes:  this.zeroBytes);
        }
        protected override bool Asn1Equals(Org.BouncyCastle.Asn1.Asn1Object asn1Object)
        {
            var val_2 = 0;
            return (bool);
        }
        protected override int Asn1GetHashCode()
        {
            return 0;
        }
        private static DerNull()
        {
            Org.BouncyCastle.Asn1.DerNull.Instance = new Org.BouncyCastle.Asn1.DerNull(dummy:  0);
        }
    
    }

}
