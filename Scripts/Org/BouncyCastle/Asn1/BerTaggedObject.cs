using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class BerTaggedObject : DerTaggedObject
    {
        // Methods
        public BerTaggedObject(int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        public BerTaggedObject(bool explicitly, int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            bool val_1 = explicitly;
        }
        public BerTaggedObject(int tagNo)
        {
            null = null;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            var val_13;
            var val_18;
            var val_19;
            var val_20;
            this.Encode(derOut:  derOut);
            return;
            label_34:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(MoveNext() == false)
            {
                goto label_25;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = Current;
            if(val_18 == null)
            {
                goto label_34;
            }
            
            val_18 = 0;
            goto label_34;
            label_25:
            val_19 = 0;
            val_20 = 0;
            val_13 = 137134080;
            if(!=0)
            {
                    bool val_21 = static_value_082C8000;
                var val_19 = static_value_082C8000 + 176;
                var val_20 = 0;
                val_19 = val_19 + 8;
                val_20 = val_20 + 1;
                val_19 = val_19 + 16;
                Dispose();
            }
            
            if( == 1)
            {
                goto label_53;
            }
            
            label_7:
            derOut.WriteByte(value:  0);
            derOut.WriteByte(value:  0);
            return;
            label_53:
            if( == false)
            {
                goto label_7;
            }
            
            goto label_7;
        }
    
    }

}
