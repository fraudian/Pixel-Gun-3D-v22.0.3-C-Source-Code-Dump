using UnityEngine;
internal class X962NamedCurves.C2tnb191v2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb191v2Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "20000000000000000000000050508CB89F652824E06B8173", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  191, k:  9, a:  new Org.BouncyCastle.Math.BigInteger(str:  "401028774D7777C7B7666D1366EA432071274F89FF01E718", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "0620048D28BCBD03B6249C99182B7C8CD19700C362C46A01", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "023809B2B7CC1B28CC5A87926AAD83FD28789E81E2C9E3BF10")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2tnb191v2Holder()
    {
        X962NamedCurves.C2tnb191v2Holder.Instance = new X962NamedCurves.C2tnb191v2Holder();
    }

}
