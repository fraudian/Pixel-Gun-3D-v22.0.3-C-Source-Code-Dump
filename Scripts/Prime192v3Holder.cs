using UnityEngine;
internal class X962NamedCurves.Prime192v3Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime192v3Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "ffffffffffffffffffffffff7a62d031c83f4294f640ec13", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "6277101735386680763835789423207666416083908700390324961279"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "fffffffffffffffffffffffffffffffefffffffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "22123dc2395a05caa7423daeccc94760a7d462256bd56916", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "027d29778100c65a1da1783716588dce2b8b4aee8e228f1896")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "c469684435deb378c4b65ca9591e2a5763059a2e"));
    }
    private static X962NamedCurves.Prime192v3Holder()
    {
        X962NamedCurves.Prime192v3Holder.Instance = new X962NamedCurves.Prime192v3Holder();
    }

}
