using UnityEngine;
internal class CustomNamedCurves.SecT193R1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.SecT193R1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve val_2 = new Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_2, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_2, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0401F481BC5F0FF84A74AD6CDF6FDEF4BF6179625372D8C0C5E10025E399F2903712CCF3EA9E3A1AD17FB0B3201B6AF7CE1B05")), n:  val_2.Order, h:  val_2.Cofactor, seed:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "103FAEC74D696E676875615175777FC5B191EF30"));
    }
    private static CustomNamedCurves.SecT193R1Holder()
    {
        CustomNamedCurves.SecT193R1Holder.Instance = new CustomNamedCurves.SecT193R1Holder();
    }

}
