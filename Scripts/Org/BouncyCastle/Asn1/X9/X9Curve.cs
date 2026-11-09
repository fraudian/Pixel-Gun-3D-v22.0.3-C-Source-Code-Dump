using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public class X9Curve : Asn1Encodable
    {
        // Fields
        private readonly Org.BouncyCastle.Math.EC.ECCurve curve;
        private readonly byte[] seed;
        private readonly Org.BouncyCastle.Asn1.DerObjectIdentifier fieldIdentifier;
        
        // Properties
        public Org.BouncyCastle.Math.EC.ECCurve Curve { get; }
        
        // Methods
        public X9Curve(Org.BouncyCastle.Math.EC.ECCurve curve)
        {
        
        }
        public X9Curve(Org.BouncyCastle.Math.EC.ECCurve curve, byte[] seed)
        {
            var val_6;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_7;
            var val_8;
            var val_9;
            if(curve == null)
            {
                goto label_1;
            }
            
            this.curve = curve;
            this.seed = Org.BouncyCastle.Utilities.Arrays.Clone(data:  seed);
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c:  curve)) == false)
            {
                goto label_2;
            }
            
            val_6 = null;
            val_6 = null;
            val_7 = 1152921505546678288;
            goto label_5;
            label_2:
            if((Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(c:  curve)) == false)
            {
                goto label_6;
            }
            
            val_8 = null;
            val_8 = null;
            val_7 = 1152921505546678296;
            label_5:
            this.fieldIdentifier = val_7;
            return;
            label_1:
            System.ArgumentNullException val_4 = null;
            val_9 = val_4;
            val_4 = new System.ArgumentNullException(paramName:  "curve");
            goto label_9;
            label_6:
            System.ArgumentException val_5 = null;
            val_9 = val_5;
            val_5 = new System.ArgumentException(message:  "This type of ECCurve is not implemented");
            label_9:
        }
        public X9Curve(Org.BouncyCastle.Asn1.X9.X9FieldID fieldID, Org.BouncyCastle.Asn1.Asn1Sequence seq)
        {
            Org.BouncyCastle.Math.BigInteger val_45;
            Org.BouncyCastle.Math.BigInteger val_46;
            var val_47;
            var val_48;
            Org.BouncyCastle.Asn1.Asn1Object val_49;
            var val_50;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_51;
            object val_52;
            var val_53;
            Org.BouncyCastle.Asn1.Asn1Object val_54;
            var val_55;
            var val_56;
            var val_57;
            Org.BouncyCastle.Asn1.Asn1OctetString val_58;
            Org.BouncyCastle.Math.BigInteger val_59;
            Org.BouncyCastle.Asn1.Asn1OctetString val_60;
            Org.BouncyCastle.Math.BigInteger val_61;
            Org.BouncyCastle.Math.EC.ECCurve val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            int val_74;
            int val_75;
            var val_76;
            var val_77;
            var val_78;
            Org.BouncyCastle.Asn1.Asn1OctetString val_79;
            Org.BouncyCastle.Asn1.Asn1OctetString val_80;
            var val_81;
            string val_83;
            var val_84;
            val_45 = fieldID;
            val_1 = new Org.BouncyCastle.Asn1.Asn1Encodable();
            if(val_45 == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.fieldIdentifier = fieldID.id;
            val_46 = 1152921505546674176;
            val_47 = null;
            val_47 = null;
            val_48 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((fieldID.id.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField)) == false)
            {
                goto label_6;
            }
            
            val_49 = fieldID.parameters;
            if(val_49 == null)
            {
                goto label_7;
            }
            
            val_48 = 0;
            val_48 = 0;
            val_49 = 0;
            goto label_12;
            label_6:
            val_50 = null;
            val_50 = null;
            val_51 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
            val_52 = val_51;
            val_53 = public System.Boolean Org.BouncyCastle.Asn1.Asn1Encodable::Equals(object obj);
            if((this.fieldIdentifier.Equals(obj:  val_52)) == false)
            {
                goto label_16;
            }
            
            val_54 = fieldID.parameters;
            if(val_54 != null)
            {
                    val_55 = 0;
            }
            
            val_54 = 0;
            val_56 = mem[282584257677167];
            val_57 = val_54;
            if(val_57 == 0)
            {
                goto label_20;
            }
            
            val_56 = 0;
            val_56 = 0;
            val_57 = 0;
            goto label_25;
            label_7:
            label_12:
            val_45 = val_49.Value;
            val_58 = val_1;
            val_59 = 1152921505540763648;
            if(val_58 != null)
            {
                    val_58 = 0;
            }
            
            new Org.BouncyCastle.Asn1.X9.X9FieldElement() = new Org.BouncyCastle.Asn1.X9.X9FieldElement(p:  val_45, s:  val_58);
            val_60 = val_1;
            if(val_60 != null)
            {
                    val_60 = 0;
            }
            
            new Org.BouncyCastle.Asn1.X9.X9FieldElement() = new Org.BouncyCastle.Asn1.X9.X9FieldElement(p:  val_45, s:  val_60);
            val_51 = (Org.BouncyCastle.Asn1.X9.X9FieldElement)[1152921553486906016].f;
            Org.BouncyCastle.Math.EC.FpCurve val_15 = null;
            val_52 = val_45;
            val_61 = (Org.BouncyCastle.Asn1.X9.X9FieldElement)[1152921553486901920].f;
            val_62 = val_15;
            val_15 = new Org.BouncyCastle.Math.EC.FpCurve(q:  val_52, a:  val_61, b:  val_51);
            goto label_36;
            label_20:
            label_25:
            val_45 = val_57.Value.IntValue;
            val_63 = mem[282584257677167];
            val_64 = null;
            val_65 = val_54;
            val_64 = null;
            if(val_65 != 0)
            {
                    val_63 = 0;
                val_63 = 0;
                val_65 = 0;
            }
            
            val_66 = mem[282584257677167];
            val_67 = val_54;
            if((val_65 & 1) == 0)
            {
                goto label_46;
            }
            
            if(val_67 == 0)
            {
                goto label_47;
            }
            
            val_68 = 0;
            val_68 = 0;
            val_69 = 0;
            goto label_52;
            label_46:
            if(val_67 != 0)
            {
                    val_70 = 0;
            }
            
            val_71 = 0;
            val_72 = mem[282584257677167];
            val_73 = val_71;
            if(val_73 == 0)
            {
                goto label_56;
            }
            
            val_72 = 0;
            val_72 = 0;
            val_73 = 0;
            goto label_61;
            label_47:
            label_52:
            val_74 = val_67.Value.IntValue;
            val_51 = 0;
            val_75 = 0;
            goto label_63;
            label_56:
            label_61:
            val_74 = val_73.Value.IntValue;
            val_76 = mem[282584257677167];
            val_77 = val_71;
            if(val_77 != 0)
            {
                    val_76 = 0;
                val_76 = 0;
                val_77 = 0;
            }
            
            val_75 = val_77.Value.IntValue;
            val_68 = mem[282584257677167];
            val_78 = val_71;
            if(val_78 != 0)
            {
                    val_68 = 0;
                val_68 = 0;
                val_78 = 0;
            }
            
            val_51 = val_78.Value.IntValue;
            label_63:
            val_79 = val_1;
            if(val_79 != null)
            {
                    val_79 = 0;
            }
            
            new Org.BouncyCastle.Asn1.X9.X9FieldElement() = new Org.BouncyCastle.Asn1.X9.X9FieldElement(m:  val_45, k1:  val_74, k2:  val_75, k3:  val_51, s:  val_79);
            val_80 = val_1;
            if(val_80 != null)
            {
                    val_80 = 0;
            }
            
            new Org.BouncyCastle.Asn1.X9.X9FieldElement() = new Org.BouncyCastle.Asn1.X9.X9FieldElement(m:  val_45, k1:  val_74, k2:  val_75, k3:  val_51, s:  val_80);
            val_59 = (Org.BouncyCastle.Asn1.X9.X9FieldElement)[1152921553486942880].f;
            val_46 = (Org.BouncyCastle.Asn1.X9.X9FieldElement)[1152921553486946976].f;
            Org.BouncyCastle.Math.EC.F2mCurve val_41 = null;
            val_52 = val_45;
            val_61 = val_74;
            val_62 = val_41;
            val_41 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  val_52, k1:  val_61, k2:  val_75, k3:  val_51, a:  val_59, b:  val_46);
            label_36:
            this.curve = val_62;
            label_16:
            if(val_1 != 3)
            {
                    return;
            }
            
            val_45 = 1152921505542520832;
            this.seed = val_1;
            return;
            label_1:
            val_83 = "fieldID";
            goto label_95;
            label_2:
            val_83 = "seq";
            label_95:
            null = new System.ArgumentNullException(paramName:  val_83);
            val_81 = 1152921553486816224;
            val_84 = X0;
        }
        public Org.BouncyCastle.Math.EC.ECCurve get_Curve()
        {
            return (Org.BouncyCastle.Math.EC.ECCurve)this.curve;
        }
        public byte[] GetSeed()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.seed);
        }
        public override Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
        {
            Org.BouncyCastle.Math.EC.ECFieldElement val_12;
            var val_13;
            var val_14;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_15;
            Org.BouncyCastle.Asn1.Asn1EncodableVector val_2 = new Org.BouncyCastle.Asn1.Asn1EncodableVector(v:  System.Array.Empty<Org.BouncyCastle.Asn1.Asn1Encodable>());
            val_12 = 1152921505546674176;
            val_13 = null;
            val_13 = null;
            if((this.fieldIdentifier.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField)) == true)
            {
                goto label_4;
            }
            
            val_14 = null;
            val_15 = this.fieldIdentifier;
            val_14 = null;
            if((val_15.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField)) == false)
            {
                goto label_8;
            }
            
            label_4:
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_5 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            .f = this.curve;
            val_5[0] = new Org.BouncyCastle.Asn1.X9.X9FieldElement();
            val_2.Add(objs:  val_5);
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_7 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            val_15 = val_7;
            val_12 = this.curve;
            .f = val_12;
            val_15[0] = new Org.BouncyCastle.Asn1.X9.X9FieldElement();
            val_2.Add(objs:  val_7);
            label_8:
            if(this.seed == null)
            {
                    return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
            }
            
            Org.BouncyCastle.Asn1.Asn1Encodable[] val_9 = new Org.BouncyCastle.Asn1.Asn1Encodable[1];
            Org.BouncyCastle.Asn1.DerBitString val_10 = null;
            val_15 = val_10;
            val_10 = new Org.BouncyCastle.Asn1.DerBitString(data:  this.seed);
            val_9[0] = val_15;
            val_2.Add(objs:  val_9);
            return (Org.BouncyCastle.Asn1.Asn1Object)new Org.BouncyCastle.Asn1.DerSequence(v:  val_2);
        }
    
    }

}
