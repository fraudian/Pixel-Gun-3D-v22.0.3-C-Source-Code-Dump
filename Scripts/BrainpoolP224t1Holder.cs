using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP224t1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP224t1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "D7C134AA264366862A18302575D0FB98D116BC4B6DDEBCA3A5A7939F", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "D7C134AA264366862A18302575D1D787B09F075797DA89F57EC8C0FF", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "D7C134AA264366862A18302575D1D787B09F075797DA89F57EC8C0FC", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "4B337D934104CD7BEF271BF60CED1ED20DA14C08B3BB64F18A60888D", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "046AB1E344CE25FF3896424E7FFE14762ECB49F8928AC0C76029B4D5800374E9F5143E568CD23F3F4D7C0D4B1E41C8CC0D1C6ABD5F1A46DB4C")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP224t1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP224t1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP224t1Holder();
    }

}
