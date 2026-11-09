using UnityEngine;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
    public class Gost3410ParamSetParameters : Asn1Encodable
    {
        // Fields
        private readonly int keySize;
        private readonly Org.BouncyCastle.Asn1.DerInteger p;
        private readonly Org.BouncyCastle.Asn1.DerInteger q;
        private readonly Org.BouncyCastle.Asn1.DerInteger a;
        
        // Properties
        public int KeySize { get; }
        public Org.BouncyCastle.Math.BigInteger P { get; }
        public Org.BouncyCastle.Math.BigInteger Q { get; }
        public Org.BouncyCastle.Math.BigInteger A { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetInstance(object obj)
        {
            object val_8;
            Org.BouncyCastle.Asn1.Asn1Sequence val_9;
            var val_10;
            val_8 = obj;
            if(val_8 == null)
            {
                    return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_10;
            }
            
            val_9 = 0;
            new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters() = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(seq:  val_9);
            val_10 = new Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters();
            return (Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)val_10;
        }
        public Gost3410ParamSetParameters(int keySize, Org.BouncyCastle.Math.BigInteger p, Org.BouncyCastle.Math.BigInteger q, Org.BouncyCastle.Math.BigInteger a)
        {
            val_1 = new System.Object();
            this.keySize = keySize;
            this.p = new Org.BouncyCastle.Asn1.DerInteger(value:  Org.BouncyCastle.Math.BigInteger val_1 = p);
            this.q = new Org.BouncyCastle.Asn1.DerInteger(value:  q);
            this.a = new Org.BouncyCastle.Asn1.DerInteger(value:  a);
        }
        private Gost3410ParamSetParameters(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            this = new System.Object();
            if(seq == 4)
            {
                    this.keySize = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq).Value.IntValue;
                this.p = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.q = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                this.a = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  "Wrong number of elements in sequence", paramName:  "seq");
        }
        public int get_KeySize()
        {
            return (int)this.keySize;
        }
        public Org.BouncyCastle.Math.BigInteger get_P()
        {
            if(this.p != null)
            {
                    return this.p.PositiveValue;
            }
            
            return this.p.PositiveValue;
        }
        public Org.BouncyCastle.Math.BigInteger get_Q()
        {
            if(this.q != null)
            {
                    return this.q.PositiveValue;
            }
            
            return this.q.PositiveValue;
        }
        public Org.BouncyCastle.Math.BigInteger get_A()
        {
            if(this.a != null)
            {
                    return this.a.PositiveValue;
            }
            
            return this.a.PositiveValue;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[4];
            Org.BouncyCastle.Asn1.DerInteger val_2 = new Org.BouncyCastle.Asn1.DerInteger(value:  this.keySize);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.p;
            val_1[2] = this.q;
            val_1[3] = this.a;
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_1);
        }
    
    }

}
