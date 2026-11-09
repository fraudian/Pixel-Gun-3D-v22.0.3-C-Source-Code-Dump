using UnityEngine;
internal class X962NamedCurves.C2tnb191v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2tnb191v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_9;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "40000000000000000000000004A20E90C39067C893BBB9A5", radix:  16);
        val_9 = null;
        val_9 = null;
        Org.BouncyCastle.Math.EC.F2mCurve val_4 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  191, k:  9, a:  new Org.BouncyCastle.Math.BigInteger(str:  "2866537B676752636A68F56554E12640276B649EF7526267", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "2E45EF571F00786F67B0081B9495A3D95462F5DE0AA185EC", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.Two);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_4, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_4, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0236B3DAF8A23206F9C4F299D7B21A9C369137F2C84AE1AA0D")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.Two, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "4E13CA542744D696E67687561517552F279A8C84"));
    }
    private static X962NamedCurves.C2tnb191v1Holder()
    {
        X962NamedCurves.C2tnb191v1Holder.Instance = new X962NamedCurves.C2tnb191v1Holder();
    }

}
