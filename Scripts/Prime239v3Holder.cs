using UnityEngine;
internal class X962NamedCurves.Prime239v3Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime239v3Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff7fffff975deb41b3a6057c3c432146526551", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "883423532389192164791648750360308885314476597252960362792450860609699839"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "255705fa2a306654b1f4cb03d6a750a30c250102d4988717d9ba15ab6d3e", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "036768ae8e18bb92cfcf005c949aa2c6d94853d0e660bbf854b1c9505fe95a")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "7d7374168ffe3471b60a857686a19475d3bfa2ff"));
    }
    private static X962NamedCurves.Prime239v3Holder()
    {
        X962NamedCurves.Prime239v3Holder.Instance = new X962NamedCurves.Prime239v3Holder();
    }

}
