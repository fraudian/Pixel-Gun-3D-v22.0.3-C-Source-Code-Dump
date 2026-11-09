using UnityEngine;
internal class X962NamedCurves.Prime239v2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime239v2Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff800000cfa7e8594377d414c03821bc582063", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "883423532389192164791648750360308885314476597252960362792450860609699839"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "617fab6832576cbbfed50d99f0249c3fee58b94ba0038c7ae84c8c832f2c", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0238af09d98727705120c921bb5e9e26296a3cdcf2f35757a0eafd87b830e7")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "e8b4011604095303ca3b8099982be09fcb9ae616"));
    }
    private static X962NamedCurves.Prime239v2Holder()
    {
        X962NamedCurves.Prime239v2Holder.Instance = new X962NamedCurves.Prime239v2Holder();
    }

}
