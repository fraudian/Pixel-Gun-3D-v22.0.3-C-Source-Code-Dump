using UnityEngine;
internal class X962NamedCurves.C2tnb239v2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb239v2Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "1555555555555555555555555555553C6F2885259C31E3FCDF154624522D", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  6);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  239, k:  36, a:  new Org.BouncyCastle.Math.BigInteger(str:  "4230017757A767FAE42398569B746325D45313AF0766266479B75654E65F", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "5037EA654196CFF0CD82B2C14A2FCF2E3FF8775285B545722F03EACDB74B", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0228F9D04E900069C8DC47A08534FE76D2B900B7D7EF31F5709F200C4CA205")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2tnb239v2Holder()
    {
        X962NamedCurves.C2tnb239v2Holder.Instance = new X962NamedCurves.C2tnb239v2Holder();
    }

}
