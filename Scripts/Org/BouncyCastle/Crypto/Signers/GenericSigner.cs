using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class GenericSigner : ISigner
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;
        private readonly Org.BouncyCastle.Crypto.IDigest digest;
        private bool forSigning;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public GenericSigner(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine, Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.engine = engine;
            this.digest = digest;
        }
        public virtual string get_AlgorithmName()
        {
            string[] val_1 = new string[5];
            val_1[0] = "Generic(";
            var val_6 = 0;
            val_6 = val_6 + 1;
            string val_3 = this.engine.AlgorithmName;
            if(val_1 == null)
            {
                goto label_10;
            }
            
            if(val_3 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_3 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_1[1] = val_3;
            val_1[2] = "/";
            var val_7 = 0;
            val_7 = val_7 + 1;
            string val_5 = this.digest.AlgorithmName;
            if(val_1 == null)
            {
                goto label_24;
            }
            
            if(val_5 != null)
            {
                goto label_25;
            }
            
            goto label_28;
            label_24:
            if(val_5 == null)
            {
                goto label_28;
            }
            
            label_25:
            label_28:
            val_1[3] = val_5;
            val_1[4] = ")";
            return +val_1;
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
            
            val_13 = "Signing requires private key.";
            goto label_11;
            label_8:
            if(val_11.IsPrivate == true)
            {
                goto label_13;
            }
            
            label_10:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.engine.Init(forEncryption:  forSigning, parameters:  parameters);
            return;
            label_13:
            val_13 = "Verification requires public key.";
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
            if(this.forSigning == false)
            {
                goto label_1;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_2 = this.digest.GetDigestSize();
            byte[] val_3 = new byte[0];
            var val_9 = 0;
            val_9 = val_9 + 1;
            int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
            if(val_3 == null)
            {
                goto label_12;
            }
            
            label_19:
            var val_10 = 0;
            val_10 = val_10 + 1;
            return this.engine.ProcessBlock(inBuf:  val_3, inOff:  0, inLen:  val_3.Length);
            label_12:
            if(this.engine != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_1:
            System.InvalidOperationException val_7 = new System.InvalidOperationException(message:  "GenericSigner not initialised for signature generation.");
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            Org.BouncyCastle.Crypto.IAsymmetricBlockCipher val_13;
            System.Array val_15;
            var val_16;
            if(this.forSigning != true)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                int val_2 = this.digest.GetDigestSize();
                byte[] val_3 = new byte[0];
                var val_15 = 0;
                val_15 = val_15 + 1;
                int val_5 = this.digest.DoFinal(output:  val_3, outOff:  0);
                val_13 = this.engine;
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_15 = val_13.ProcessBlock(inBuf:  signature, inOff:  0, inLen:  signature.Length);
                if(val_7.Length < val_3.Length)
            {
                    int val_8 = val_3.Length & 4294967295;
                byte[] val_9 = new byte[0];
                val_13 = val_9;
                System.Array.Copy(sourceArray:  val_15, sourceIndex:  0, destinationArray:  val_9, destinationIndex:  val_9.Length - val_7.Length, length:  val_7.Length);
                val_15 = val_13;
            }
            
                return (bool)Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  val_9, b:  val_3);
            }
            
            val_16 = new System.InvalidOperationException(message:  "GenericSigner not initialised for verification");
            if(0 == 1)
            {
                    if((null & 1) != 0)
            {
                    return (bool)Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  val_9, b:  val_3);
            }
            
                mem[8] = null;
                val_16 = 8;
            }
        
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
        }
    
    }

}
