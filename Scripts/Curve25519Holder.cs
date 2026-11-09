using UnityEngine;
internal class CustomNamedCurves.Curve25519Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private CustomNamedCurves.Curve25519Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519 val_1 = new Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519();
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_1, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_1, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "042AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD245A20AE19A1B8A086B4E01EDD2C7748D14C923D4D7E6D7C61B229E9C5A27ECED3D9")), n:  val_1.Order, h:  val_1.Cofactor, seed:  0);
    }
    private static CustomNamedCurves.Curve25519Holder()
    {
        CustomNamedCurves.Curve25519Holder.Instance = new CustomNamedCurves.Curve25519Holder();
    }

}
