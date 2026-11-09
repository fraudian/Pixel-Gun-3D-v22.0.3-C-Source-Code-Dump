using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP256r1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP256r1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "A9FB57DBA1EEA9BC3E660A909D838D718C397AA3B561A6F7901E0E82974856A7", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5377", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "7D5A0975FC2C3057EEF67530417AFFE7FB8055C126DC5C6CE94A4B44F330B5D9", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "26DC5C6CE94A4B44F330B5D9BBD77CBF958416295CF7E1CE6BCCDC18FF8C07B6", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "048BD2AEB9CB7E57CB2C4B482FFC81B7AFB9DE27E1E3BD23C23A4453BD9ACE3262547EF835C3DAC4FD97F8461A14611DC9C27745132DED8E545C1D54C72F046997")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP256r1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP256r1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP256r1Holder();
    }

}
