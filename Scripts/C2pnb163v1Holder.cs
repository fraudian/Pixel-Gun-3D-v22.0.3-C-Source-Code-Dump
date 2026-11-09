using UnityEngine;
internal class X962NamedCurves.C2pnb163v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb163v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_9;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "0400000000000000000001E60FC8821CC74DAEAFC1", radix:  16);
        val_9 = null;
        val_9 = null;
        Org.BouncyCastle.Math.EC.F2mCurve val_4 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  163, k1:  1, k2:  2, k3:  8, a:  new Org.BouncyCastle.Math.BigInteger(str:  "072546B5435234A422E0789675F432C89435DE5242", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "00C9517D06D5240D3CFF38C74B20B6CD4D6F9DD4D9", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.Two);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_4, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_4, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0307AF69989546103D79329FCC3D74880F33BBE803CB")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.Two, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "D2C0FB15760860DEF1EEF4D696E6768756151754"));
    }
    private static X962NamedCurves.C2pnb163v1Holder()
    {
        X962NamedCurves.C2pnb163v1Holder.Instance = new X962NamedCurves.C2pnb163v1Holder();
    }

}
