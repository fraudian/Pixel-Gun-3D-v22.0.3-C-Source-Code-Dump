using UnityEngine;
internal class CustomNamedCurves.SecT163R1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT163R1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "040369979697AB43897789566789567F787A7876A65400435EDB42EFAFB2989D51FEFCE3C80988F41FF883")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "24B7B137C8A14D696E6768756151756FD0DA2E5C"));
    }
    private static CustomNamedCurves.SecT163R1Holder()
    {
        CustomNamedCurves.SecT163R1Holder.Instance = new CustomNamedCurves.SecT163R1Holder();
    }

}
