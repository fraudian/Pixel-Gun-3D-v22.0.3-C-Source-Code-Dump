using UnityEngine;
internal class CustomNamedCurves.SecT113R2Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT113R2Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0401A57A6A7B26CA5EF52FCDB816479700B3ADC94ED1FE674C06E695BABA1D")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "10C0FB15760860DEF1EEF4D696E676875615175D"));
    }
    private static CustomNamedCurves.SecT113R2Holder()
    {
        CustomNamedCurves.SecT113R2Holder.Instance = new CustomNamedCurves.SecT113R2Holder();
    }

}
