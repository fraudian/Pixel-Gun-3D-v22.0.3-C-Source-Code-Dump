using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public class LazyAsn1InputStream : Asn1InputStream
    {
        // Methods
        public LazyAsn1InputStream(byte[] input)
        {
        
        }
        public LazyAsn1InputStream(System.IO.Stream inputStream)
        {
        
        }
        internal override Org.BouncyCastle.Asn1.DerSequence CreateDerSequence(Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
        {
            return (Org.BouncyCastle.Asn1.DerSequence)new Org.BouncyCastle.Asn1.LazyDerSequence(encoded:  dIn.ToArray());
        }
        internal override Org.BouncyCastle.Asn1.DerSet CreateDerSet(Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
        {
            return (Org.BouncyCastle.Asn1.DerSet)new Org.BouncyCastle.Asn1.LazyDerSet(encoded:  dIn.ToArray());
        }
    
    }

}
