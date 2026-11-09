using UnityEngine;
internal class X962NamedCurves.C2tnb239v3Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb239v3Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "0CCCCCCCCCCCCCCCCCCCCCCCCCCCCCAC4912D2D9DF903EF9888B8A0E4CFF", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  10);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  239, k:  36, a:  new Org.BouncyCastle.Math.BigInteger(str:  "01238774666A67766D6676F778E676B66999176666E687666D8766C66A9F", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "6A941977BA9F6A435199ACFC51067ED587F519C5ECB541B8E44111DE1D40", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0370F6E9D04D289C4E89913CE3530BFDE903977D42B146D539BF1BDE4E9C92")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2tnb239v3Holder()
    {
        X962NamedCurves.C2tnb239v3Holder.Instance = new X962NamedCurves.C2tnb239v3Holder();
    }

}
