using UnityEngine;
internal class CustomNamedCurves.SecT163K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT163K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve val_1 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_1, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_1, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0402FE13C0537BBC11ACAA07D793DE4E6D5E5C94EEE80289070FB05D38FF58321F2E800536D538CCDAA3D9")), n:  val_1.Order, h:  val_1.Cofactor, seed:  0);
    }
    private static CustomNamedCurves.SecT163K1Holder()
    {
        CustomNamedCurves.SecT163K1Holder.Instance = new CustomNamedCurves.SecT163K1Holder();
    }

}
