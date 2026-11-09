using UnityEngine;
internal class X962NamedCurves.C2pnb163v2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb163v2Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_8;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "03FFFFFFFFFFFFFFFFFFFDF64DE1151ADBB78F10A7", radix:  16);
        val_8 = null;
        val_8 = null;
        Org.BouncyCastle.Math.EC.F2mCurve val_4 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  163, k1:  1, k2:  2, k3:  8, a:  new Org.BouncyCastle.Math.BigInteger(str:  "0108B39E77C4B108BED981ED0E890E117C511CF072", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "0667ACEB38AF4E488C407433FFAE4F1C811638DF20", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.Two);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_4, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_4, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "030024266E4EB5106D0A964D92C4860E2671DB9B6CC5")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.Two, seed:  0);
    }
    private static X962NamedCurves.C2pnb163v2Holder()
    {
        X962NamedCurves.C2pnb163v2Holder.Instance = new X962NamedCurves.C2pnb163v2Holder();
    }

}
