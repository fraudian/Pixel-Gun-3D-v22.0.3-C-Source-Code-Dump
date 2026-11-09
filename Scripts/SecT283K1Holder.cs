using UnityEngine;
internal class CustomNamedCurves.SecT283K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT283K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve val_1 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_1, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_1, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "040503213F78CA44883F1A3B8162F188E553CD265F23C1567A16876913B0C2AC245849283601CCDA380F1C9E318D90F95D07E5426FE87E45C0E8184698E45962364E34116177DD2259")), n:  val_1.Order, h:  val_1.Cofactor, seed:  0);
    }
    private static CustomNamedCurves.SecT283K1Holder()
    {
        CustomNamedCurves.SecT283K1Holder.Instance = new CustomNamedCurves.SecT283K1Holder();
    }

}
