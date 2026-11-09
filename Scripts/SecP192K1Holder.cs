using UnityEngine;
internal class CustomNamedCurves.SecP192K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecP192K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger[] val_3 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(str:  "71169be7330b3038edb025f1", radix:  16);
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
        val_3[1] = new Org.BouncyCastle.Math.BigInteger(str:  "-b3fb3400dec5c4adceb8655c", radix:  16);
        Org.BouncyCastle.Math.BigInteger[] val_6 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(str:  "12511cfe811d0f4e6bc688b4d", radix:  16);
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
        val_6[1] = new Org.BouncyCastle.Math.BigInteger(str:  "71169be7330b3038edb025f1", radix:  16);
        Org.BouncyCastle.Math.EC.ECCurve val_13 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.ConfigureCurveGlv(c:  new Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve(), p:  new Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(beta:  new Org.BouncyCastle.Math.BigInteger(str:  "bb85691939b869c1d087f601554b96b80cb4f55b35f433c2", radix:  16), lambda:  new Org.BouncyCastle.Math.BigInteger(str:  "3d84f26c12238d7b4f3d516613c1759033b1a5800175d0b1", radix:  16), v1:  val_3, v2:  val_6, g1:  new Org.BouncyCastle.Math.BigInteger(str:  "71169be7330b3038edb025f1d0f9", radix:  16), g2:  new Org.BouncyCastle.Math.BigInteger(str:  "b3fb3400dec5c4adceb8655d4c94", radix:  16), bits:  208));
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_13, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_13, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04DB4FF10EC057E9AE26B07D0280B7F4341DA5D1B1EAE06C7D9B2F2F6D9C5628A7844163D015BE86344082AA88D95E2F9D")), n:  val_13, h:  val_13, seed:  0);
    }
    private static CustomNamedCurves.SecP192K1Holder()
    {
        CustomNamedCurves.SecP192K1Holder.Instance = new CustomNamedCurves.SecP192K1Holder();
    }

}
