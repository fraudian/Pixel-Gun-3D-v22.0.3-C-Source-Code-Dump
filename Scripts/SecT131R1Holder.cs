using UnityEngine;
internal class CustomNamedCurves.SecT131R1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT131R1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "040081BAF91FDF9833C40F9C181343638399078C6E7EA38C001F73C8134B1B4EF9E150")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "4D696E676875615175985BD3ADBADA21B43A97E2"));
    }
    private static CustomNamedCurves.SecT131R1Holder()
    {
        CustomNamedCurves.SecT131R1Holder.Instance = new CustomNamedCurves.SecT131R1Holder();
    }

}
