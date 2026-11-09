using UnityEngine;
internal class CustomNamedCurves.SecT131R2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT131R2Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "040356DCD8F2F95031AD652D23951BB366A80648F06D867940A5366D9E265DE9EB240F")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "985BD3ADBAD4D696E676875615175A21B43A97E3"));
    }
    private static CustomNamedCurves.SecT131R2Holder()
    {
        CustomNamedCurves.SecT131R2Holder.Instance = new CustomNamedCurves.SecT131R2Holder();
    }

}
