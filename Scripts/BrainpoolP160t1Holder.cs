using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP160t1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP160t1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "E95E4A5F737059DC60DF5991D45029409E60FC09", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "E95E4A5F737059DC60DFC7AD95B3D8139515620F", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "E95E4A5F737059DC60DFC7AD95B3D8139515620C", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "7A556B6DAE535B7B51ED2C4D7DAA7A0B5C55F380", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04B199B13B9B34EFC1397E64BAEB05ACC265FF2378ADD6718B7C7C1961F0991B842443772152C9E0AD")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP160t1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP160t1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP160t1Holder();
    }

}
