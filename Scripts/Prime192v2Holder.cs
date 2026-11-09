using UnityEngine;
internal class X962NamedCurves.Prime192v2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime192v2Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "fffffffffffffffffffffffe5fb1a724dc80418648d8dd31", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "6277101735386680763835789423207666416083908700390324961279"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "fffffffffffffffffffffffffffffffefffffffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "cc22d6dfb95c6b25e49c0d6364a4e5980c393aa21668d953", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "03eea2bae7e1497842f2de7769cfe9c989c072ad696f48034a")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "31a92ee2029fd10d901b113e990710f0d21ac6b6"));
    }
    private static X962NamedCurves.Prime192v2Holder()
    {
        X962NamedCurves.Prime192v2Holder.Instance = new X962NamedCurves.Prime192v2Holder();
    }

}
