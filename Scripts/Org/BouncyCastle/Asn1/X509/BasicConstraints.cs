using UnityEngine;

namespace Org.BouncyCastle.Asn1.X509
{
    public class BasicConstraints : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.DerBoolean cA;
        private readonly Org.BouncyCastle.Asn1.DerInteger pathLenConstraint;
        
        // Properties
        public Org.BouncyCastle.Math.BigInteger PathLenConstraint { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X509.BasicConstraints GetInstance(Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
        {
            return Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(obj:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  obj, explicitly:  explicitly));
        }
        public static Org.BouncyCastle.Asn1.X509.BasicConstraints GetInstance(object obj)
        {
            Org.BouncyCastle.Asn1.X509.X509Extension val_10;
            var val_11;
            val_10 = obj;
            if(val_10 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.BasicConstraints)val_11;
            }
            
            val_11 = Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject(ext:  val_10);
            return (Org.BouncyCastle.Asn1.X509.BasicConstraints)val_11;
        }
        private BasicConstraints(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            object val_6;
            var val_7;
            var val_8;
            if(seq < 1)
            {
                    return;
            }
            
            val_7 = 0;
            val_6 = seq;
            val_8 = 0;
            this.cA = Org.BouncyCastle.Asn1.DerBoolean.GetInstance(obj:  val_6);
            if(seq < 2)
            {
                    return;
            }
            
            if(this.cA != null)
            {
                    this.pathLenConstraint = Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj:  seq);
                return;
            }
            
            System.ArgumentException val_5 = new System.ArgumentException(message:  "wrong sequence in constructor", paramName:  "seq");
        }
        public BasicConstraints(bool cA)
        {
            var val_1;
            if(cA == false)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.cA = Org.BouncyCastle.Asn1.DerBoolean.True;
        }
        public BasicConstraints(int pathLenConstraint)
        {
            null = null;
            this.cA = Org.BouncyCastle.Asn1.DerBoolean.True;
            this.pathLenConstraint = new Org.BouncyCastle.Asn1.DerInteger(value:  pathLenConstraint);
        }
        public bool IsCA()
        {
            if(this.cA == null)
            {
                    return (bool)this.cA;
            }
            
            return this.cA.IsTrue;
        }
        public Org.BouncyCastle.Math.BigInteger get_PathLenConstraint()
        {
            if(this.pathLenConstraint == null)
            {
                    return (Org.BouncyCastle.Math.BigInteger)this.pathLenConstraint;
            }
            
            return this.pathLenConstraint.Value;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            T[] val_6 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>();
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_6 = System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            if(this.cA != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable[] val_3 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
                val_6 = val_3;
                val_6[0] = this.cA;
                val_2.Add(objs:  val_3);
            }
            
            if(this.pathLenConstraint == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_4 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_6 = this.pathLenConstraint;
            val_4[0] = val_6;
            val_2.Add(objs:  val_4);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
        public override string ToString()
        {
            System.Object[] val_11;
            var val_12;
            var val_13;
            if(this.pathLenConstraint == null)
            {
                goto label_1;
            }
            
            object[] val_1 = new object[4];
            val_11 = val_1;
            val_11[0] = "BasicConstraints: isCa(";
            if(this.cA == null)
            {
                goto label_6;
            }
            
            val_12 = this.cA.IsTrue;
            goto label_7;
            label_1:
            if(this.cA == null)
            {
                goto label_8;
            }
            
            val_13 = this.cA.IsTrue;
            return (string)"BasicConstraints: isCa("("BasicConstraints: isCa(") + val_13.ToString() + ")";
            label_6:
            val_12 = 0;
            label_7:
            val_11[1] = val_12.ToString();
            val_11[2] = "), pathLenConstraint = ";
            val_11[3] = this.pathLenConstraint.Value;
            string val_6 = +val_1;
            return (string)"BasicConstraints: isCa("("BasicConstraints: isCa(") + val_13.ToString() + ")";
            label_8:
            val_13 = 0;
            return (string)"BasicConstraints: isCa("("BasicConstraints: isCa(") + val_13.ToString() + ")";
        }
    
    }

}
