using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X9ECParameters : Asn1Encodable
    {
        // Fields
        private Org.BouncyCastle.Asn1.X9.X9FieldID fieldID;
        private Org.BouncyCastle.Math.EC.ECCurve curve;
        private Org.BouncyCastle.Asn1.X9.X9ECPoint g;
        private Org.BouncyCastle.Math.BigInteger n;
        private Org.BouncyCastle.Math.BigInteger h;
        private byte[] seed;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECCurve Curve { get; }
        public Org.BouncyCastle.Math.EC.ECPoint G { get; }
        public Org.BouncyCastle.Math.BigInteger N { get; }
        public Org.BouncyCastle.Math.BigInteger H { get; }
        public Org.BouncyCastle.Asn1.X9.X9Curve CurveEntry { get; }
        public Org.BouncyCastle.Asn1.X9.X9FieldID FieldIDEntry { get; }
        public Org.BouncyCastle.Asn1.X9.X9ECPoint BaseEntry { get; }
        
        // Methods
        public static Org.BouncyCastle.Asn1.X9.X9ECParameters GetInstance(object obj)
        {
            object val_3 = obj;
            if(val_3 == null)
            {
                    return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_3;
            }
            
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_2 = null;
            val_3 = val_2;
            val_2 = new Org.BouncyCastle.Asn1.X9.X9ECParameters(seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  val_3 = obj));
            return (Org.BouncyCastle.Asn1.X9.X9ECParameters)val_3;
        }
        public X9ECParameters(Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            var val_18;
            var val_19;
            var val_20;
            Org.BouncyCastle.Asn1.Asn1OctetString val_21;
            Org.BouncyCastle.Asn1.X9.X9ECPoint val_22;
            Org.BouncyCastle.Math.EC.ECCurve val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            if(seq != null)
            {
                    val_19 = seq;
                if(val_19 != null)
            {
                    val_18 = 0;
                val_18 = 0;
                val_19 = 0;
            }
            
                val_20 = null;
                val_20 = null;
                if((val_19.Value & 1) != 0)
            {
                    Org.BouncyCastle.Asn1.X9.X9Curve val_7 = new Org.BouncyCastle.Asn1.X9.X9Curve(fieldID:  Org.BouncyCastle.Asn1.X9.X9FieldID.GetInstance(obj:  seq), seq:  Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  seq));
                this.curve = (Org.BouncyCastle.Asn1.X9.X9Curve)[1152921553488102144].curve;
                val_22 = seq;
                if(val_22 != null)
            {
                    val_23 = this.curve;
                val_21 = 0;
                val_22 = new Org.BouncyCastle.Asn1.X9.X9ECPoint();
            }
            else
            {
                    val_23 = this.curve;
                val_22 = new Org.BouncyCastle.Asn1.X9.X9ECPoint();
                val_21 = 0;
            }
            
                val_22 = new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_23, s:  val_21);
                this.g = val_22;
                val_25 = seq;
                if(val_25 != null)
            {
                    val_24 = 0;
                val_24 = 0;
                val_25 = 0;
            }
            
                this.n = val_25.Value;
                this.seed = Org.BouncyCastle.Utilities.Arrays.Clone(data:  (Org.BouncyCastle.Asn1.X9.X9Curve)[1152921553488102144].seed);
                if(seq != 6)
            {
                    return;
            }
            
                val_26 = seq;
                if(val_26 != null)
            {
                    val_26 = 0;
            }
            
                this.h = val_26.Value;
                return;
            }
            
            }
            
            val_27 = new System.ArgumentException(message:  "bad version in X9ECParameters");
        }
        public X9ECParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n)
        {
        
        }
        public X9ECParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Asn1.X9.X9ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h)
        {
        
        }
        public X9ECParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h)
        {
        
        }
        public X9ECParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Math.EC.ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h, byte[] seed)
        {
            Org.BouncyCastle.Asn1.X9.X9ECPoint val_1 = new Org.BouncyCastle.Asn1.X9.X9ECPoint(p:  g, compressed:  false);
        }
        public X9ECParameters(Org.BouncyCastle.Math.EC.ECCurve curve, Org.BouncyCastle.Asn1.X9.X9ECPoint g, Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger h, byte[] seed)
        {
            Org.BouncyCastle.Math.BigInteger val_11;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            Org.BouncyCastle.Math.BigInteger val_17;
            Org.BouncyCastle.Asn1.X9.X9FieldID val_18;
            var val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            string val_27;
            var val_28;
            val_11 = n;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            this.curve = curve;
            this.g = val_1;
            this.n = val_11;
            this.h = h;
            this.seed = seed;
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  curve)) == false)
            {
                goto label_1;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_7;
            label_1:
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(c:  curve)) == false)
            {
                goto label_8;
            }
            
            if(curve == null)
            {
                goto label_10;
            }
            
            val_14 = null;
            val_13 = val_14;
            val_15 = curve;
            if(val_15 != null)
            {
                goto label_12;
            }
            
            val_13 = 0;
            goto label_13;
            label_10:
            val_14 = null;
            label_13:
            val_15 = 0;
            label_12:
            if(mem[282584257676957] == 0)
            {
                goto label_14;
            }
            
            var val_14 = mem[282584257676847];
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_16:
            if(((mem[282584257676847] + 8) + -8) == val_14)
            {
                goto label_15;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < mem[282584257676957])
            {
                goto label_16;
            }
            
            label_14:
            val_13 = val_14;
            goto label_17;
            label_7:
            val_17 = curve.Characteristic;
            Org.BouncyCastle.Asn1.X9.X9FieldID val_7 = null;
            val_18 = val_7;
            val_7 = new Org.BouncyCastle.Asn1.X9.X9FieldID(primeP:  val_17);
            goto label_18;
            label_15:
            val_15 = val_15 + (((mem[282584257676847] + 8)) << 4);
            val_16 = val_15 + 296;
            label_17:
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Int32[] val_10 = val_15.MinimalPolynomial.GetExponentsPresent();
            if(val_10 == null)
            {
                goto label_24;
            }
            
            val_20 = val_10;
            val_21 = val_10.Length;
            if(val_21 != 3)
            {
                goto label_25;
            }
            
            label_30:
            val_17 = val_10[1];
            val_18 = new Org.BouncyCastle.Asn1.X9.X9FieldID();
            val_22 = val_17;
            val_23 = val_10[0];
            val_24 = 0;
            val_25 = 0;
            goto label_29;
            label_24:
            val_20 = 24;
            val_21 = 28563616;
            if(28563616 == 3)
            {
                goto label_30;
            }
            
            label_25:
            if(val_21 != 5)
            {
                goto label_31;
            }
            
            val_17 = val_10[2];
            val_11 = val_10[1];
            Org.BouncyCastle.Asn1.X9.X9FieldID val_11 = null;
            val_18 = val_11;
            val_22 = val_17;
            val_23 = val_10[0];
            val_24 = val_11;
            val_25 = val_10[1];
            label_29:
            val_11 = new Org.BouncyCastle.Asn1.X9.X9FieldID(m:  val_22, k1:  val_23, k2:  val_24, k3:  val_25);
            label_18:
            this.fieldID = val_18;
            return;
            label_8:
            val_27 = "\'curve\' is of an unsupported type";
            goto label_40;
            label_31:
            System.ArgumentException val_12 = null;
            val_27 = "Only trinomial and pentomial curves are supported";
            label_40:
            val_12 = new System.ArgumentException(message:  val_27);
            val_28 = val_12;
        }
        public Org.BouncyCastle.Math.EC.ECCurve get_Curve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)this.curve;
        }
        public Org.BouncyCastle.Math.EC.ECPoint get_G()
        {
            if(this.g != null)
            {
                    return this.g.Point;
            }
            
            return this.g.Point;
        }
        public Org.BouncyCastle.Math.BigInteger get_N()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.n;
        }
        public Org.BouncyCastle.Math.BigInteger get_H()
        {
            return (Org.BouncyCastle.Math.BigInteger)this.h;
        }
        public byte[] GetSeed()
        {
            return (System.Byte[])this.seed;
        }
        public Org.BouncyCastle.Asn1.X9.X9Curve get_CurveEntry()
        {
            return (Org.BouncyCastle.Asn1.X9.X9Curve)new Org.BouncyCastle.Asn1.X9.X9Curve(curve:  this.curve, seed:  this.seed);
        }
        public Org.BouncyCastle.Asn1.X9.X9FieldID get_FieldIDEntry()
        {
            return (Org.BouncyCastle.Asn1.X9.X9FieldID)this.fieldID;
        }
        public Org.BouncyCastle.Asn1.X9.X9ECPoint get_BaseEntry()
        {
            return (Org.BouncyCastle.Asn1.X9.X9ECPoint)this.g;
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            var val_9;
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable[5];
            val_9 = null;
            val_9 = null;
            val_1[0] = new Org.BouncyCastle.Asn1.DerInteger(value:  Org.BouncyCastle.Math.BigInteger.One);
            val_1[1] = this.fieldID;
            val_1[2] = new Org.BouncyCastle.Asn1.X9.X9Curve(curve:  this.curve, seed:  this.seed);
            val_1[3] = this.g;
            val_1[4] = new Org.BouncyCastle.Asn1.DerInteger(value:  this.n);
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_5 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  val_1);
            if(this.h == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_5);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_6 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_6[0] = new Org.BouncyCastle.Asn1.DerInteger(value:  this.h);
            val_5.Add(objs:  val_6);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_5);
        }
    
    }

}
