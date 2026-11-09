using UnityEngine;
internal class X962NamedCurves.C2tnb239v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb239v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "2000000000000000000000000000000F4D42FFE1492A4993F1CAD666E447", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  239, k:  36, a:  new Org.BouncyCastle.Math.BigInteger(str:  "32010857077C5431123A46B808906756F543423E8D27877578125778AC76", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "790408F2EEDAF392B012EDEFB3392F30F4327C0CA3F31FC383C422AA8C16", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0257927098FA932E7C0A96D3FD5B706EF7E5F5C156E16B7E7C86038552E91D")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2tnb239v1Holder()
    {
        X962NamedCurves.C2tnb239v1Holder.Instance = new X962NamedCurves.C2tnb239v1Holder();
    }

}
