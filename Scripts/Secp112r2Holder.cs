using UnityEngine;
internal class SecNamedCurves.Secp112r2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private SecNamedCurves.Secp112r2Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_5 = Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "36DF0AAFD8B8D7597CA10520D04B");
        Org.BouncyCastle.Math.BigInteger val_6 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  4);
        Org.BouncyCastle.Math.EC.FpCurve val_7 = new Org.BouncyCastle.Math.EC.FpCurve(q:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "DB7C2ABF62E35E668076BEAD208B"), a:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "6127C24C05F38A0AAAF65C0EF02C"), b:  Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex(hex:  "51DEF1815DB5ED74FCC34C85D709"), order:  val_5, cofactor:  val_6);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_7, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_7, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "044BA30AB5E892B4E1649DD0928643ADCD46F5882E3747DEF36E956E97")), n:  val_5, h:  val_6, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "002757A1114D696E6768756151755316C05E0BD4"));
    }
    private static SecNamedCurves.Secp112r2Holder()
    {
        SecNamedCurves.Secp112r2Holder.Instance = new SecNamedCurves.Secp112r2Holder();
    }

}
