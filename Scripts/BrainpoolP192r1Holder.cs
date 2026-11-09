using UnityEngine;
internal class TeleTrusTNamedCurves.BrainpoolP192r1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private TeleTrusTNamedCurves.BrainpoolP192r1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "C302F41D932A36CDA7A3462F9E9E916B5BE8F1029AC4ACC1", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = new Org.BouncyCastle.Math.BigInteger(str:  "01", radix:  16);
        Org.BouncyCastle.Math.EC.FpCurve val_6 = new Org.BouncyCastle.Math.EC.FpCurve(q:  new Org.BouncyCastle.Math.BigInteger(str:  "C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86297", radix:  16), a:  new Org.BouncyCastle.Math.BigInteger(str:  "6A91174076B1E0E19C39C031FE8685C1CAE040E5C69A28EF", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "469A28EF7C28CCA3DC721D044F4496BCCA7EF4146FBF25C9", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_6, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_6, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04C0A0647EAAB6A48753B033C56CB0F0900A2F5C4853375FD614B690866ABD5BB88B5F4828C1490002E6773FA2FA299B8F")), n:  val_1, h:  val_2);
    }
    private static TeleTrusTNamedCurves.BrainpoolP192r1Holder()
    {
        TeleTrusTNamedCurves.BrainpoolP192r1Holder.Instance = new TeleTrusTNamedCurves.BrainpoolP192r1Holder();
    }

}
