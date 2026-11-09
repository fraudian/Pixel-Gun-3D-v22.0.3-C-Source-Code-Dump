using UnityEngine;
internal class X962NamedCurves.C2tnb191v3Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb191v3Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "155555555555555555555555610C0B196812BFB6288A3EA3", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  6);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  191, k:  9, a:  new Org.BouncyCastle.Math.BigInteger(str:  "6C01074756099122221056911C77D77E77A777E7E7E77FCB", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "71FE1AF926CF847989EFEF8DB459F66394D90F32AD3F15E8", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "03375D4CE24FDE434489DE8746E71786015009E66E38A926DD")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2tnb191v3Holder()
    {
        X962NamedCurves.C2tnb191v3Holder.Instance = new X962NamedCurves.C2tnb191v3Holder();
    }

}
