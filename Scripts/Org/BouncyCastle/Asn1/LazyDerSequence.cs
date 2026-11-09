using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    internal class LazyDerSequence : DerSequence
    {
        // Fields
        private byte[] encoded;
        
        // Properties
        public override Org.BouncyCastle.Asn1.Asn1Encodable Item { get; }
        public override int Count { get; }
        
        // Methods
        internal LazyDerSequence(byte[] encoded)
        {
            this = new Org.BouncyCastle.Asn1.Asn1Sequence(capacity:  0);
            this.encoded = encoded;
        }
        private void Parse()
        {
            System.Byte[] val_4;
            var val_5;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            val_4 = this.encoded;
            if(val_4 == null)
            {
                goto label_1;
            }
            
            new Org.BouncyCastle.Asn1.LazyAsn1InputStream() = new Org.BouncyCastle.Asn1.Asn1InputStream(input:  val_4);
            label_4:
            Org.BouncyCastle.Asn1.Asn1Object val_3 = new Org.BouncyCastle.Asn1.LazyAsn1InputStream().ReadObject();
            if(val_3 == null)
            {
                goto label_3;
            }
            
            this.AddObject(obj:  val_3);
            goto label_4;
            label_1:
            val_5 = 0;
            goto label_6;
            label_3:
            val_4 = 0;
            val_5 = 0;
            this.encoded = 0;
            label_6:
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if( != 1)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public override Org.BouncyCastle.Asn1.Asn1Encodable get_Item(int index)
        {
            this.Parse();
            return this.Item[index];
        }
        public override System.Collections.IEnumerator GetEnumerator()
        {
            this.Parse();
            return this.GetEnumerator();
        }
        public override int get_Count()
        {
            this.Parse();
            return this.Count;
        }
        internal override void Encode(Org.BouncyCastle.Asn1.DerOutputStream derOut)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            if(this.encoded != null)
            {
                    derOut.WriteEncoded(tag:  48, bytes:  this.encoded);
            }
            else
            {
                    this.Encode(derOut:  derOut);
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(55 == 55)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
    
    }

}
