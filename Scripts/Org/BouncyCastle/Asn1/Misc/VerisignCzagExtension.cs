using UnityEngine;

namespace Org.BouncyCastle.Asn1.Misc
{
    public class VerisignCzagExtension : DerIA5String
    {
        // Methods
        public VerisignCzagExtension(Org.BouncyCastle.Asn1.DerIA5String str)
        {
            Org.BouncyCastle.Asn1.DerIA5String val_1 = str;
            val_1 = new Org.BouncyCastle.Asn1.DerIA5String(str:  val_1);
        }
        public override string ToString()
        {
            return "VerisignCzagExtension: "("VerisignCzagExtension: ") + this.GetString();
        }
    
    }

}
