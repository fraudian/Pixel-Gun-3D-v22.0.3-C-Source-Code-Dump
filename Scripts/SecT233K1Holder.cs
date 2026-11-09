using UnityEngine;
internal class CustomNamedCurves.SecT233K1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT233K1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve val_1 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_1, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_1, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04017232BA853A7E731AF129F22FF4149563A419C26BF50A4C9D6EEFAD612601DB537DECE819B7F70F555A67C427A8CD9BF18AEB9B56E0C11056FAE6A3")), n:  val_1.Order, h:  val_1.Cofactor, seed:  0);
    }
    private static CustomNamedCurves.SecT233K1Holder()
    {
        CustomNamedCurves.SecT233K1Holder.Instance = new CustomNamedCurves.SecT233K1Holder();
    }

}
