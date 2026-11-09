using UnityEngine;
internal class X962NamedCurves.C2pnb208w1Holder : X9ECParametersHolder
{
    // Fields
    internal static readonly Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;
    
    // Methods
    private X962NamedCurves.C2pnb208w1Holder()
    {
        val_1 = new System.Object();
    }
    protected override Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
    {
        Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(str:  "0101BAF95C9723C57B6C21DA2EFF2D5ED588BDD5717E212F9D", radix:  16);
        Org.BouncyCastle.Math.BigInteger val_2 = Org.BouncyCastle.Math.BigInteger.ValueOf(value:  72);
        Org.BouncyCastle.Math.EC.F2mCurve val_5 = new Org.BouncyCastle.Math.EC.F2mCurve(m:  208, k1:  1, k2:  2, k3:  83, a:  new Org.BouncyCastle.Math.BigInteger(str:  "0", radix:  16), b:  new Org.BouncyCastle.Math.BigInteger(str:  "00C8619ED45A62E6212E1160349E2BFA844439FAFC2A3FD1638F9E", radix:  16), order:  val_1, cofactor:  val_2);
        return (Org.BouncyCastle.Asn1.X9.X9ECParameters)new Org.BouncyCastle.Asn1.X9.X9ECParameters(curve:  val_5, g:  new Org.BouncyCastle.Asn1.X9.X9ECPoint(c:  val_5, encoding:  Org.BouncyCastle.Utilities.Encoders.Hex.Decode(data:  "0289FDFBE4ABE193DF9559ECF07AC0CE78554E2784EB8C1ED1A57A")), n:  val_1, h:  val_2, seed:  0);
    }
    private static X962NamedCurves.C2pnb208w1Holder()
    {
        X962NamedCurves.C2pnb208w1Holder.Instance = new X962NamedCurves.C2pnb208w1Holder();
    }

}
