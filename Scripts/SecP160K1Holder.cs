using UnityEngine;
internal class CustomNamedCurves.SecP160K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecP160K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger[] val_3 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(str:  "9162fbe73984472a0a9e", radix:  16);
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_4 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_3[0] = val_4;
        val_3[1] = new Org.BouncyCastle.Math.BigInteger(str:  "-96341f1138933bc2f505", radix:  16);
        Org.BouncyCastle.Math.BigInteger[] val_6 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(str:  "127971af8721782ecffa3", radix:  16);
        if(val_6 == null)
        {
            goto label_10;
        }
        
        if(val_7 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_7 == null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_6[0] = val_7;
        val_6[1] = new Org.BouncyCastle.Math.BigInteger(str:  "9162fbe73984472a0a9e", radix:  16);
        Org.BouncyCastle.Math.EC.ECCurve val_13 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.ConfigureCurveGlv(c:  new Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve(), p:  new Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(beta:  new Org.BouncyCastle.Math.BigInteger(str:  "9ba48cba5ebcb9b6bd33b92830b2a2e0e192f10a", radix:  16), lambda:  new Org.BouncyCastle.Math.BigInteger(str:  "c39c6c3b3a36d7701b9c71a1f5804ae5d0003f4", radix:  16), v1:  val_3, v2:  val_6, g1:  new Org.BouncyCastle.Math.BigInteger(str:  "9162fbe73984472a0a9d0590", radix:  16), g2:  new Org.BouncyCastle.Math.BigInteger(str:  "96341f1138933bc2f503fd44", radix:  16), bits:  176));
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_13, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_13, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "043B4C382CE37AA192A4019E763036F4F5DD4D7EBB938CF935318FDCED6BC28286531733C3F03C4FEE")), n:  val_13, h:  val_13, seed:  0);
    }
    private static CustomNamedCurves.SecP160K1Holder()
    {
        CustomNamedCurves.SecP160K1Holder.Instance = new CustomNamedCurves.SecP160K1Holder();
    }

}
