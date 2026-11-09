using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class TlsDsaSigner : AbstractTlsSigner
    {
        // Properties
        protected abstract byte SignatureAlgorithm { get; }
        
        // Methods
        public override byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash)
        {
            int val_6;
            var val_7;
            val_6 = algorithm;
            var val_9 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_5;
            }
            
            var val_6 = mem[137170944] + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_4:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (mem[137170944] + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_8 = val_6;
            val_8 = val_8 + 1;
            val_9 = val_9 + val_8;
            val_7 = val_9 + 296;
            label_5:
            Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom val_2 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  privateKey, random:  SecureRandom);
            if(val_6 == null)
            {
                goto label_6;
            }
            
            if(hash == null)
            {
                goto label_7;
            }
            
            label_19:
            val_6 = hash.Length;
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_20;
            label_6:
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_17;
            label_7:
            if(this != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_17:
            label_20:
            this.BlockUpdate(input:  hash, inOff:  16, length:  20);
            var val_12 = 0;
            val_12 = val_12 + 1;
            return this.GenerateSignature();
        }
        public override bool VerifyRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash)
        {
            var val_6;
            if(algorithm == null)
            {
                goto label_1;
            }
            
            if(hash == null)
            {
                goto label_2;
            }
            
            label_14:
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_7;
            label_1:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_12;
            label_2:
            if(this != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_7:
            val_6 = 0;
            goto label_15;
            label_12:
            val_6 = 16;
            label_15:
            this.BlockUpdate(input:  hash, inOff:  16, length:  20);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 5;
            return this.VerifySignature(signature:  sigBytes);
        }
        public override Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsDsaSigner).__il2cppRuntimeField_2B8;
        }
        public override Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsDsaSigner).__il2cppRuntimeField_2B8;
        }
        protected virtual Org.BouncyCastle.Crypto.ICipherParameters MakeInitParameters(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters cp)
        {
            return (Org.BouncyCastle.Crypto.ICipherParameters)cp;
        }
        protected virtual Org.BouncyCastle.Crypto.ISigner MakeSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters cp)
        {
            var val_11;
            Org.BouncyCastle.Crypto.IDigest val_12;
            var val_2 = (algorithm != 0) ? 1 : 0;
            val_2 = val_2 ^ (Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  137170944));
            if(val_2 == true)
            {
                goto label_5;
            }
            
            if(algorithm == null)
            {
                goto label_4;
            }
            
            if((algorithm & 255) != this)
            {
                goto label_5;
            }
            
            val_11 = algorithm;
            if(raw == false)
            {
                goto label_6;
            }
            
            label_8:
            Org.BouncyCastle.Crypto.Digests.NullDigest val_4 = null;
            val_12 = val_4;
            val_4 = new Org.BouncyCastle.Crypto.Digests.NullDigest();
            goto label_7;
            label_4:
            val_11 = 2;
            if(raw == true)
            {
                goto label_8;
            }
            
            label_6:
            val_12 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  2);
            label_7:
            Org.BouncyCastle.Crypto.Signers.DsaDigestSigner val_6 = new Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(signer:  this, digest:  val_12);
            bool val_7 = forSigning;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_6.Init(forSigning:  forSigning, parameters:  this);
            return (Org.BouncyCastle.Crypto.ISigner)val_6;
            label_5:
            System.InvalidOperationException val_10 = new System.InvalidOperationException();
        }
        protected abstract byte get_SignatureAlgorithm(); // 0
        protected abstract Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(byte hashAlgorithm); // 0
        protected TlsDsaSigner()
        {
        
        }
    
    }

}
