using UnityEngine;
internal class CustomNamedCurves.SecT163R2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT163R2Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0403F0EBA16286A2D57EA0991168D4994637E8343E3600D51FBC6C71A0094FA2CDD545B11C5C0C797324F1")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "85E25BFE5C86226CDB12016F7553F9D0E693A268"));
    }
    private static CustomNamedCurves.SecT163R2Holder()
    {
        CustomNamedCurves.SecT163R2Holder.Instance = new CustomNamedCurves.SecT163R2Holder();
    }

}
