using UnityEngine;
internal class X962NamedCurves.C2pnb304w1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb304w1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "0101D556572AABAC800101D556572AABAC8001022D5C91DD173F8FB561DA6899164443051D", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  46);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  48, k1:  1, k2:  2, k3:  11, a:  new Org.BouncyCastle.Math.BigInteger(str:  "00FD0D693149A118F651E6DCE6802085377E5F882D1B510B44160074C1288078365A0396C8E681", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "00BDDB97E555A50A908E43B01C798EA5DAA6788F1EA2794EFCF57166B8C14039601E55827340BE", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "02197B07845E9BE2D96ADB0F5F3C7F2CFFBD7A3EB8B6FEC35C7FD67F26DDF6285A644F740A2614")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2pnb304w1Holder()
    {
        X962NamedCurves.C2pnb304w1Holder.Instance = new X962NamedCurves.C2pnb304w1Holder();
    }

}
