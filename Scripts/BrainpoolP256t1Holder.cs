using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP256t1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP256t1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "A9FB57DBA1EEA9BC3E660A909D838D718C397AA3B561A6F7901E0E82974856A7", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5377", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5374", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "662C61C430D84EA4FE66A7733D0B76B7BF93EBC4AF2F49256AE58101FEE92B04", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04A3E8EB3CC1CFE7B7732213B23A656149AFA142C47AAFBC2B79A191562E1305F42D996C823439C56D7F7B22E14644417E69BCB6DE39D027001DABE8F35B25C9BE")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP256t1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP256t1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP256t1Holder();
    }

}
