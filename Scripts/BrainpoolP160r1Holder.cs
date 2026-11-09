using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP160r1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP160r1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "E95E4A5F737059DC60DF5991D45029409E60FC09", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "E95E4A5F737059DC60DFC7AD95B3D8139515620F", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "340E7BE2A280EB74E2BE61BADA745D97E8F7C300", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "1E589A8595423412134FAA2DBDEC95C8D8675E58", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04BED5AF16EA3F6A4F62938C4631EB5AF7BDBCDBC31667CB477A1A8EC338F94741669C976316DA6321")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP160r1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP160r1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP160r1Holder();
    }

}
