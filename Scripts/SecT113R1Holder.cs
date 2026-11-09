using UnityEngine;
internal class CustomNamedCurves.SecT113R1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT113R1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04009D73616F35F4AB1407D73562C10F00A52830277958EE84D1315ED31886")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "10E723AB14D696E6768756151756FEBF8FCB49A9"));
    }
    private static CustomNamedCurves.SecT113R1Holder()
    {
        CustomNamedCurves.SecT113R1Holder.Instance = new CustomNamedCurves.SecT113R1Holder();
    }

}
