using UnityEngine;
internal class SecNamedCurves.Secp128r2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private SecNamedCurves.Secp128r2Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_5 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "3FFFFFFF7FFFFFFFBE0024720613B5A3");
        Org.BouncyCastle.Math.BigInteger val_6 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
        Org.BouncyCastle.Math.EC.FpCurve val_7 = new Org.BouncyCastle.Math.EC.FpCurve(q:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFF"), a:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "D6031998D1B3BBFEBF59CC9BBFF9AEE1"), b:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "5EEEFCA380D02919DC2C6558BB6D8A5D"), order:  val_5, cofactor:  val_6);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_7, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_7, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "047B6AA5D85E572983E6FB32A7CDEBC14027B6916A894D3AEE7106FE805FC34B44")), n:  val_5, h:  val_6, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "004D696E67687561517512D8F03431FCE63B88F4"));
    }
    private static SecNamedCurves.Secp128r2Holder()
    {
        SecNamedCurves.Secp128r2Holder.Instance = new SecNamedCurves.Secp128r2Holder();
    }

}
