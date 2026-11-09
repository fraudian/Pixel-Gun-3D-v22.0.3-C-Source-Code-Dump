using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class Gost3410DigestSigner : ISigner
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private readonly Org.BouncyCastle.Crypto.IDsa dsaSigner;
        private bool forSigning;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public Gost3410DigestSigner(Org.BouncyCastle.Crypto.IDsa signer, Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.digest = digest;
            this.dsaSigner = signer;
        }
        public virtual string get_AlgorithmName()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            return this.digest.AlgorithmName + "with" + this.dsaSigner.AlgorithmName;
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_11;
            string val_13;
            this.forSigning = forSigning;
            if(parameters != null)
            {
                    val_11 = parameters;
            }
            
            val_11 = 0;
            if(forSigning == false)
            {
                goto label_8;
            }
            
            if(val_11.IsPrivate == true)
            {
                goto label_10;
            }
            
            val_13 = "Signing Requires Private Key.";
            goto label_11;
            label_8:
            if(val_11.IsPrivate == true)
            {
                goto label_13;
            }
            
            label_10:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.dsaSigner.Init(forSigning:  forSigning, parameters:  parameters);
            return;
            label_13:
            val_13 = "Verification Requires Public Key.";
            label_11:
            null = new Org.BouncyCastle.Security.InvalidKeyException(message:  val_13);
        }
        public virtual void Update(byte input)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  inOff, length:  length);
        }
        public virtual byte[] GenerateSignature()
        {
            var val_16;
            var val_18;
            var val_19;
            var val_20;
            if(this.forSigning != false)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                int val_2 = this.digest.GetDigestSize();
                byte[] val_3 = new byte[0];
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_16 = 0;
                int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_16 = 2;
                Org.BouncyCastle.Math.BigInteger[] val_7 = this.dsaSigner.GenerateSignature(message:  val_3);
                byte[] val_8 = new byte[64];
                val_7[1].ToByteArrayUnsigned().CopyTo(array:  val_8, index:  32 - val_10.Length);
                val_7[0].ToByteArrayUnsigned().CopyTo(array:  val_8, index:  64 - val_9.Length);
                return (System.Byte[])val_8;
            }
            
            val_18 = 1152921549880610256;
            val_19 = new System.InvalidOperationException(message:  "GOST3410DigestSigner not initialised for signature generation.");
            mem[8] = null;
            val_20 = 8;
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            System.Byte[] val_9;
            var val_13;
            var val_14;
            var val_15;
            val_9 = signature;
            if(this.forSigning != true)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                int val_2 = this.digest.GetDigestSize();
                byte[] val_3 = new byte[0];
                var val_12 = 0;
                val_12 = val_12 + 1;
                int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
                new Org.BouncyCastle.Math.BigInteger() = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_9, offset:  32, length:  32);
                new Org.BouncyCastle.Math.BigInteger() = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  val_9, offset:  0, length:  32);
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_9 = ???;
                return this.dsaSigner.VerifySignature(message:  val_3, r:  new Org.BouncyCastle.Math.BigInteger(), s:  new Org.BouncyCastle.Math.BigInteger());
            }
            
            val_13 = 1152921549880949168;
            val_14 = new System.InvalidOperationException(message:  "DSADigestSigner not initialised for verification");
            mem[8] = null;
            val_15 = 8;
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
        }
    
    }

}
