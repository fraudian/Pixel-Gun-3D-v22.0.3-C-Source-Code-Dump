using UnityEngine;
internal class CustomNamedCurves.SecP256K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecP256K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger[] val_3 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(str:  "3086d221a7d46bcde86c90e49284eb15", radix:  16);
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
        val_3[1] = new Org.BouncyCastle.Math.BigInteger(str:  "-e4437ed6010e88286f547fa90abfe4c3", radix:  16);
        Org.BouncyCastle.Math.BigInteger[] val_6 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(str:  "114ca50f7a8e2f3f657c1108d9d44cfd8", radix:  16);
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
        val_6[1] = new Org.BouncyCastle.Math.BigInteger(str:  "3086d221a7d46bcde86c90e49284eb15", radix:  16);
        Org.BouncyCastle.Math.EC.ECCurve val_13 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.ConfigureCurveGlv(c:  new Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve(), p:  new Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(beta:  new Org.BouncyCastle.Math.BigInteger(str:  "7ae96a2b657c07106e64479eac3434e99cf0497512f58995c1396c28719501ee", radix:  16), lambda:  new Org.BouncyCastle.Math.BigInteger(str:  "5363ad4cc05c30e0a5261c028812645a122e22ea20816678df02967c1b23bd72", radix:  16), v1:  val_3, v2:  val_6, g1:  new Org.BouncyCastle.Math.BigInteger(str:  "3086d221a7d46bcde86c90e49284eb153dab", radix:  16), g2:  new Org.BouncyCastle.Math.BigInteger(str:  "e4437ed6010e88286f547fa90abfe4c42212", radix:  16), bits:  16));
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_13, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_13, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0479BE667EF9DCBBAC55A06295CE870B07029BFCDB2DCE28D959F2815B16F81798483ADA7726A3C4655DA4FBFC0E1108A8FD17B448A68554199C47D08FFB10D4B8")), n:  val_13, h:  val_13, seed:  0);
    }
    private static CustomNamedCurves.SecP256K1Holder()
    {
        CustomNamedCurves.SecP256K1Holder.Instance = new CustomNamedCurves.SecP256K1Holder();
    }

}
