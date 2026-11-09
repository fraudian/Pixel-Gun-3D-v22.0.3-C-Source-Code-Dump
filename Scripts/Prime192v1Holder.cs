using UnityEngine;
internal class X962NamedCurves.Prime192v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime192v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "ffffffffffffffffffffffff99def836146bc9b1b4d22831", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "6277101735386680763835789423207666416083908700390324961279"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "fffffffffffffffffffffffffffffffefffffffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "64210519e59c80e70fa7e9ab72243049feb8deecc146b9b1", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "03188da80eb03090f67cbf20eb43a18800f4ff0afd82ff1012")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "3045AE6FC8422f64ED579528D38120EAE12196D5"));
    }
    private static X962NamedCurves.Prime192v1Holder()
    {
        X962NamedCurves.Prime192v1Holder.Instance = new X962NamedCurves.Prime192v1Holder();
    }

}
