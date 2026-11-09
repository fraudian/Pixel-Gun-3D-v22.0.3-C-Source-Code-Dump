using UnityEngine;
internal class CustomNamedCurves.SecP224K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecP224K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger[] val_3 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_4 = new Org.BouncyCastle.Math.BigInteger(str:  "6b8cf07d4ca75c88957d9d670591", radix:  16);
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
        val_3[1] = new Org.BouncyCastle.Math.BigInteger(str:  "-b8adf1378a6eb73409fa6c9c637d", radix:  16);
        Org.BouncyCastle.Math.BigInteger[] val_6 = new Org.BouncyCastle.Math.BigInteger[2];
        Org.BouncyCastle.Math.BigInteger val_7 = new Org.BouncyCastle.Math.BigInteger(str:  "1243ae1b4d71613bc9f780a03690e", radix:  16);
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
        val_6[1] = new Org.BouncyCastle.Math.BigInteger(str:  "6b8cf07d4ca75c88957d9d670591", radix:  16);
        Org.BouncyCastle.Math.EC.ECCurve val_13 = Org.BouncyCastle.Crypto.EC.CustomNamedCurves.ConfigureCurveGlv(c:  new Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve(), p:  new Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(beta:  new Org.BouncyCastle.Math.BigInteger(str:  "fe0e87005b4e83761908c5131d552a850b3f58b749c37cf5b84d6768", radix:  16), lambda:  new Org.BouncyCastle.Math.BigInteger(str:  "60dcd2104c4cbc0be6eeefc2bdd610739ec34e317f9b33046c9e4788", radix:  16), v1:  val_3, v2:  val_6, g1:  new Org.BouncyCastle.Math.BigInteger(str:  "6b8cf07d4ca75c88957d9d67059037a4", radix:  16), g2:  new Org.BouncyCastle.Math.BigInteger(str:  "b8adf1378a6eb73409fa6c9c637ba7f5", radix:  16), bits:  240));
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_13, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_13, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04A1455B334DF099DF30FC28A169A467E9E47075A90F7E650EB6B7A45C7E089FED7FBA344282CAFBD6F7E319F7C0B0BD59E2CA4BDB556D61A5")), n:  val_13, h:  val_13, seed:  0);
    }
    private static CustomNamedCurves.SecP224K1Holder()
    {
        CustomNamedCurves.SecP224K1Holder.Instance = new CustomNamedCurves.SecP224K1Holder();
    }

}
