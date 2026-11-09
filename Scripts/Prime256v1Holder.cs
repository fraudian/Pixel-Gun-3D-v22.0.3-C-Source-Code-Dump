using UnityEngine;
internal class X962NamedCurves.Prime256v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.Prime256v1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "ffffffff00000000ffffffffffffffffbce6faada7179e84f3b9cac2fc632551", radix:  16);
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(value:  "115792089210356248762697446949407573530086143415290314195533631308867097853951"), a:  new Org.BouncyCastle.Math.BigInteger(str:  "ffffffff00000001000000000000000000000000fffffffffffffffffffffffc", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "5ac635d8aa3a93e7b3ebbd55769886bc651d06b0cc53b0f63bce3c3e27d2604b", radix:  16), order:  val_1, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "036b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c296")), n:  val_1, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "c49d360886e704936a6678e1139d26b7819f7e90"));
    }
    private static X962NamedCurves.Prime256v1Holder()
    {
        X962NamedCurves.Prime256v1Holder.Instance = new X962NamedCurves.Prime256v1Holder();
    }

}
