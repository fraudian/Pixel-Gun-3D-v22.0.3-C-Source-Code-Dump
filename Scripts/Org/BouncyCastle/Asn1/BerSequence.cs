using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerSequence : DerSequence
    {
        // Fields
        public static readonly Org.BouncyCastle.Asn1.BerSequence Empty;
        
        // Methods
        public static Org.BouncyCastle.Asn1.BerSequence FromVector(Org.BouncyCastle.Asn1.Asn1EncodableVector v)
        {
            var val_3;
            Org.BouncyCastle.Asn1.BerSequence val_4;
            val_3 = null;
            if(v.Count >= 1)
            {
                    Org.BouncyCastle.Asn1.BerSequence val_2 = null;
                val_4 = val_2;
                val_2 = new Org.BouncyCastle.Asn1.BerSequence(v:  v);
                return val_4;
            }
            
            val_3 = null;
            val_4 = Org.BouncyCastle.Asn1.BerSequence.Empty;
            return val_4;
        }
        public BerSequence()
        {
        
        }
        public BerSequence(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        public BerSequence(Org.BouncyCastle.Asn1.Asn1Encodable[] v)
        {
        
        }
        public BerSequence(Org.BouncyCastle.Asn1.Asn1EncodableVector v)
        {
        
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            var val_10;
            var val_11;
            var val_12;
            this.Encode(derOut:  derOut);
            return;
            label_20:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = Current;
            if(val_10 == null)
            {
                goto label_20;
            }
            
            val_10 = 0;
            goto label_20;
            label_11:
            val_11 = 0;
            val_12 = 0;
            if( != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                Dispose();
            }
            
            derOut.WriteByte(value:  0);
            derOut.WriteByte(value:  0);
        }
        private static BerSequence()
        {
            Org.BouncyCastle.Asn1.BerSequence.Empty = new Org.BouncyCastle.Asn1.BerSequence();
        }
    
    }

}
