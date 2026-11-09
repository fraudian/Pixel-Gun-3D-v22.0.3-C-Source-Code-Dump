using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class DerTaggedObject : Asn1TaggedObject
    {
        // Methods
        public DerTaggedObject(int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
        
        }
        public DerTaggedObject(bool explicitly, int tagNo, Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            bool val_1 = explicitly;
        }
        public DerTaggedObject(int tagNo)
        {
            null = null;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Byte[] val_9;
            if(this.IsEmpty() == false)
            {
                goto label_1;
            }
            
            val_6 = new byte[0];
            val_7 = 160;
            val_8 = 137150464;
            val_9 = val_6;
            goto label_3;
            label_1:
            System.Byte[] val_3 = GetDerEncoded();
            if(true == 0)
            {
                goto label_5;
            }
            
            val_7 = 160;
            val_8 = this;
            val_9 = val_3;
            label_3:
            derOut.WriteEncoded(flags:  160, tagNo:  1605293808, bytes:  val_9);
            return;
            label_5:
            byte val_6 = val_3[0];
            val_6 = val_6 | 128;
            byte val_4 = val_6 & 160;
            if(derOut != null)
            {
                    derOut.WriteTag(flags:  val_4, tagNo:  1605293808);
            }
            else
            {
                    0.WriteTag(flags:  val_4, tagNo:  1605293808);
            }
            
            derOut.Write(buffer:  val_3, offset:  1, count:  val_3.Length - 1);
        }
    
    }

}
