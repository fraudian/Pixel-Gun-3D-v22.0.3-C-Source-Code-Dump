using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsRsaSigner : AbstractTlsSigner
    {
        // Methods
        public override byte[] GenerateRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash)
        {
            var val_5;
            var val_8 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_5;
            }
            
            var val_5 = mem[137170944] + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_4:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (mem[137170944] + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_7 = val_5;
            val_7 = val_7 + 1;
            val_8 = val_8 + val_7;
            val_5 = val_8 + 296;
            label_5:
            Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom val_2 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  privateKey, random:  SecureRandom);
            if(hash == null)
            {
                goto label_6;
            }
            
            if(this != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_11;
            label_6:
            if(this != null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            this.BlockUpdate(input:  hash, inOff:  0, length:  hash.Length);
            var val_10 = 0;
            val_10 = val_10 + 1;
            return this.GenerateSignature();
        }
        public override bool VerifyRawSignature(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash)
        {
            var val_4;
            if(hash == null)
            {
                goto label_1;
            }
            
            if(this != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_6;
            label_1:
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            val_4 = 0;
            this.BlockUpdate(input:  hash, inOff:  0, length:  hash.Length);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 5;
            return this.VerifySignature(signature:  sigBytes);
        }
        public override Org.BouncyCastle.Crypto.ISigner CreateSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
        {
            var val_3;
            var val_6 = mem[137170944];
            if((mem[137170944] + 286) == 0)
            {
                goto label_5;
            }
            
            var val_3 = mem[137170944] + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_4:
            if(((mem[137170944] + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[137170944] + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_6 = val_6 + val_5;
            val_3 = val_6 + 296;
            label_5:
            Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom val_2 = new Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(parameters:  privateKey, random:  SecureRandom);
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsRsaSigner).__il2cppRuntimeField_2A8;
        }
        public override Org.BouncyCastle.Crypto.ISigner CreateVerifyer(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsRsaSigner).__il2cppRuntimeField_2A8;
        }
        public override bool IsValidPublicKey(Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
        {
            return (bool)0 & 1;
        }
        protected virtual Org.BouncyCastle.Crypto.ISigner MakeSigner(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, bool raw, bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters cp)
        {
            var val_13;
            var val_14;
            Org.BouncyCastle.Crypto.IDigest val_15;
            Org.BouncyCastle.Crypto.IDigest val_17;
            var val_2 = (algorithm != 0) ? 1 : 0;
            val_2 = val_2 ^ (Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  137170944));
            if(val_2 == true)
            {
                goto label_5;
            }
            
            if(algorithm != null)
            {
                    if((algorithm & 255) != 1)
            {
                goto label_5;
            }
            
            }
            
            if(raw == false)
            {
                goto label_6;
            }
            
            Org.BouncyCastle.Crypto.Digests.NullDigest val_4 = null;
            val_13 = 0;
            val_14 = val_4;
            val_4 = new Org.BouncyCastle.Crypto.Digests.NullDigest();
            if(algorithm != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            if(algorithm == null)
            {
                goto label_9;
            }
            
            val_13 = 0;
            val_15 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  algorithm);
            label_7:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner val_7 = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(digest:  val_15, digestOid:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetOidForHashAlgorithm(hashAlgorithm:  algorithm));
            if(val_7 != null)
            {
                goto label_19;
            }
            
            label_20:
            label_19:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_7.Init(forSigning:  forSigning, parameters:  cp);
            return (Org.BouncyCastle.Crypto.ISigner)val_7;
            label_9:
            Org.BouncyCastle.Crypto.Tls.CombinedHash val_10 = null;
            val_17 = val_10;
            val_10 = new Org.BouncyCastle.Crypto.Tls.CombinedHash();
            label_8:
            if((new Org.BouncyCastle.Crypto.Signers.GenericSigner(engine:  this, digest:  val_10)) != null)
            {
                goto label_19;
            }
            
            goto label_20;
            label_5:
            System.InvalidOperationException val_12 = new System.InvalidOperationException();
        }
        protected virtual Org.BouncyCastle.Crypto.IAsymmetricBlockCipher CreateRsaImpl()
        {
            return (Org.BouncyCastle.Crypto.IAsymmetricBlockCipher)new Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
        }
        public TlsRsaSigner()
        {
        
        }
    
    }

}
