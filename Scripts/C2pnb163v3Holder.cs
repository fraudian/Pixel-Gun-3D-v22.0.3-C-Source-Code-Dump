using UnityEngine;
internal class X962NamedCurves.C2pnb163v3Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb163v3Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_8;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "03FFFFFFFFFFFFFFFFFFFE1AEE140F110AFF961309", radix:  16);
        val_8 = null;
        val_8 = null;
        Org.BouncyCastle.Math.EC.F2mCurve val_4 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  163, k1:  1, k2:  2, k3:  8, a:  new Org.BouncyCastle.Math.BigInteger(str:  "07A526C63D3E25A256A007699F5447E32AE456B50E", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "03F7061798EB99E238FD6F1BF95B48FEEB4854252B", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.Two);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_4, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_4, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0202F9F87B7C574D0BDECF8A22E6524775F98CDEBDCB")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.Two, seed:  0);
    }
    private static X962NamedCurves.C2pnb163v3Holder()
    {
        X962NamedCurves.C2pnb163v3Holder.Instance = new X962NamedCurves.C2pnb163v3Holder();
    }

}
