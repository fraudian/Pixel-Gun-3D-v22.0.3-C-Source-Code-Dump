using UnityEngine;
internal class X962NamedCurves.C2pnb176w1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb176w1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "010092537397ECA4F6145799D62B0A19CE06FE26AD", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  110);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  176, k1:  1, k2:  2, k3:  43, a:  new Org.BouncyCastle.Math.BigInteger(str:  "00E4E6DB2995065C407D9D39B8D0967B96704BA8E9C90B", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "005DDA470ABE6414DE8EC133AE28E9BBD7FCEC0AE0FFF2", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "038D16C2866798B600F9F08BB4A8E860F3298CE04A5798")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2pnb176w1Holder()
    {
        X962NamedCurves.C2pnb176w1Holder.Instance = new X962NamedCurves.C2pnb176w1Holder();
    }

}
