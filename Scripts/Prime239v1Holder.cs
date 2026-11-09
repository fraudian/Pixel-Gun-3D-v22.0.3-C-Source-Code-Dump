using UnityEngine;
internal class X962NamedCurves.Prime239v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime239v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff7fffff9e5e9a9f5d9071fbd1522688909d0b", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "883423532389192164791648750360308885314476597252960362792450860609699839"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "6b016c3bdcf18941d0d654921475ca71a9db2fb27d1d37796185c2942c0a", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "020ffa963cdca8816ccc33b8642bedf905c3d358573d3f27fbbd3b3cb9aaaf")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "e43bb460f0b80cc0c0b075798e948060f8321b7d"));
    }
    private static X962NamedCurves.Prime239v1Holder()
    {
        X962NamedCurves.Prime239v1Holder.Instance = new X962NamedCurves.Prime239v1Holder();
    }

}
