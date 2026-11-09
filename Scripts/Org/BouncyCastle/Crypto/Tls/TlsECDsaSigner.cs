using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsECDsaSigner : TlsDsaSigner
    {
        // Properties
        protected override byte SignatureAlgorithm { get; }
        
        // Methods
        public override bool IsValidPublicKey(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            var val_2 = 0;
            return (bool);
        }
        protected override Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(byte hashAlgorithm)
        {
            return (Org.BouncyCastle.Crypto.IDsa)new Org.BouncyCastle.Crypto.Signers.ECDsaSigner(kCalculator:  new Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(digest:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  hashAlgorithm)));
        }
        protected override byte get_SignatureAlgorithm()
        {
            return 3;
        }
        public TlsECDsaSigner()
        {
            val_1 = new Org.BouncyCastle.Crypto.Tls.AbstractTlsSigner();
        }
    
    }

}
