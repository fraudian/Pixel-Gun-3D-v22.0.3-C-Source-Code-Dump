using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP320r1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP320r1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "D35E472036BC4FB7E13C785ED201E065F98FCFA5B68F12A32D482EC7EE8658E98691555B44C59311", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E27", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "3EE30B568FBAB0F883CCEBD46D3F3BB8A2A73513F5EB79DA66190EB085FFA9F492F375A97D860EB4", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "520883949DFDBC42D3AD198640688A6FE13F41349554B49ACC31DCCD884539816F5EB4AC8FB1F1A6", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0443BD7E9AFB53D8B85289BCC48EE5BFE6F20137D10A087EB6E7871E2A10A599C710AF8D0D39E2061114FDD05545EC1CC8AB4093247F77275E0743FFED117182EAA9C77877AAAC6AC7D35245D1692E8EE1")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP320r1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP320r1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP320r1Holder();
    }

}
