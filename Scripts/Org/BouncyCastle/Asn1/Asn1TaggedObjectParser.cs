using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public interface Asn1TaggedObjectParser : IAsn1Convertible
    {
        // Properties
        public abstract int TagNo { get; }
        
        // Methods
        public abstract int get_TagNo(); // 0
        public abstract Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit); // 0
    
    }

}
