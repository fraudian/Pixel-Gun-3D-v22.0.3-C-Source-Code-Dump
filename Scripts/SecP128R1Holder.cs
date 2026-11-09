using UnityEngine;
internal class CustomNamedCurves.SecP128R1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecP128R1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04161FF7528B899B2D0C28607CA52C5B86CF5AC8395BAFEB13C02DA292DDED7A83")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "000E0D4D696E6768756151750CC03A4473D03679"));
    }
    private static CustomNamedCurves.SecP128R1Holder()
    {
        CustomNamedCurves.SecP128R1Holder.Instance = new CustomNamedCurves.SecP128R1Holder();
    }

}
