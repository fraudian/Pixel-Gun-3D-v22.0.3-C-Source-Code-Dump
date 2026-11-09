using UnityEngine;
internal class SecNamedCurves.Secp112r1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private SecNamedCurves.Secp112r1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_10;
        Org.BouncyCastle.Math.BigInteger val_5 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "DB7C2ABF62E35E7628DFAC6561C5");
        val_10 = null;
        val_10 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "DB7C2ABF62E35E668076BEAD208B"), a:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "DB7C2ABF62E35E668076BEAD2088"), b:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "659EF8BA043916EEDE8911702B22"), order:  val_5, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0409487239995A5EE76B55F9C2F098A89CE5AF8724C0A23E0E0FF77500")), n:  val_5, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "00F50B028E4D696E676875615175290472783FB1"));
    }
    private static SecNamedCurves.Secp112r1Holder()
    {
        SecNamedCurves.Secp112r1Holder.Instance = new SecNamedCurves.Secp112r1Holder();
    }

}
