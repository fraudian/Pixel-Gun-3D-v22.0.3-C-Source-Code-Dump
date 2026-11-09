using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP320t1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP320t1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "D35E472036BC4FB7E13C785ED201E065F98FCFA5B68F12A32D482EC7EE8658E98691555B44C59311", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E27", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E24", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "A7F561E038EB1ED560B3D147DB782013064C19F27ED27C6780AAF77FB8A547CEB5B4FEF422340353", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04925BE9FB01AFC6FB4D3E7D4990010F813408AB106C4F09CB7EE07868CC136FFF3357F624A21BED5263BA3A7A27483EBF6671DBEF7ABB30EBEE084E58A0B077AD42A5A0989D1EE71B1B9BC0455FB0D2C3")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP320t1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP320t1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP320t1Holder();
    }

}
