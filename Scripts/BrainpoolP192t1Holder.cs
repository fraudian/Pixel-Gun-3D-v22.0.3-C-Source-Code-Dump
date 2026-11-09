using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP192t1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP192t1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "C302F41D932A36CDA7A3462F9E9E916B5BE8F1029AC4ACC1", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86297", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86294", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "13D56FFAEC78681E68F9DEB43B35BEC2FB68542E27897B79", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "043AE9E58C82F63C30282E1FE7BBF43FA72C446AF6F4618129097E2C5667C2223A902AB5CA449D0084B7E5B3DE7CCC01C9")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP192t1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP192t1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP192t1Holder();
    }

}
