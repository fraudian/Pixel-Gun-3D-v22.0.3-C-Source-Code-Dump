using UnityEngine;
internal class AnssiNamedCurves.Frp256v1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private AnssiNamedCurves.Frp256v1Holder()
    {
    
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        var val_9;
        Org.BouncyCastle.Math.BigInteger val_4 = Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex(hex:  "F1FD178C0B3AD58F10126DE8CE42435B53DC67E140D2BF941FFDD459C6D655E1");
        val_9 = null;
        val_9 = null;
        Org.BouncyCastle.Math.EC.FpCurve val_5 = new Org.BouncyCastle.Math.EC.FpCurve(q:  Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex(hex:  "F1FD178C0B3AD58F10126DE8CE42435B3961ADBCABC8CA6DE8FCF353D86E9C03"), a:  Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex(hex:  "F1FD178C0B3AD58F10126DE8CE42435B3961ADBCABC8CA6DE8FCF353D86E9C00"), b:  Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex(hex:  "EE353FCA5428A9300D4ABA754A44C00FDFEC0C9AE4B1A1803075ED967B7BB73F"), order:  val_4, cofactor:  Org.BouncyCastle.Math.BigInteger.One);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "04B6B3D4C356C139EB31183D4749D423958C27D2DCAF98B70164C97A2DD98F5CFF6142E0F7C8B204911F9271F0F3ECEF8C2701C307E8E4C9E183115A1554062CFB")), n:  val_4, h:  Org.BouncyCastle.Math.BigInteger.One, seed:  0);
    }
    private static AnssiNamedCurves.Frp256v1Holder()
    {
        AnssiNamedCurves.Frp256v1Holder.Instance = new AnssiNamedCurves.Frp256v1Holder();
    }

}
