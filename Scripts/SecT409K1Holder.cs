using UnityEngine;
internal class CustomNamedCurves.SecT409K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT409K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve val_1 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_1, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_1, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "040060F05F658F49C1AD3AB1890F7184210EFD0987E307C84C27ACCFB8F9F67CC2C460189EB5AAAA62EE222EB1B35540CFE902374601E369050B7C4E42ACBA1DACBF04299C3460782F918EA427E6325165E9EA10E3DA5F6C42E9C55215AA9CA27A5863EC48D8E0286B")), n:  val_1.Order, h:  val_1.Cofactor, seed:  0);
    }
    private static CustomNamedCurves.SecT409K1Holder()
    {
        CustomNamedCurves.SecT409K1Holder.Instance = new CustomNamedCurves.SecT409K1Holder();
    }

}
