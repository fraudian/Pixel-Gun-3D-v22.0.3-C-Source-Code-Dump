using UnityEngine;

namespace Org.BouncyCastle.Crypto.Modes
{
    public class SicBlockCipher : IBlockCipher
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private readonly int blockSize;
        private readonly byte[] counter;
        private readonly byte[] counterOut;
        private byte[] IV;
        
        // Properties
        public virtual string AlgorithmName { get; }
        public virtual bool IsPartialBlockOkay { get; }
        
        // Methods
        public SicBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher)
        {
            this.cipher = cipher;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.blockSize = cipher.GetBlockSize();
            this.counter = new byte[0];
            this.counterOut = new byte[0];
            this.IV = new byte[0];
        }
        public virtual Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher()
        {
            return (Org.BouncyCastle.Crypto.IBlockCipher)this.cipher;
        }
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            int val_12;
            Org.BouncyCastle.Crypto.IBlockCipher val_13;
            var val_15;
            var val_16;
            object val_18;
            if(parameters == null)
            {
                goto label_3;
            }
            
            System.Byte[] val_2 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  parameters.GetIV());
            this.IV = val_2;
            val_12 = this.blockSize;
            if(val_2 == null)
            {
                    val_12 = this.blockSize;
            }
            
            if(this.blockSize < val_2.Length)
            {
                goto label_5;
            }
            
            val_13 = System.Math.Min(val1:  8, val2:  ((val_12 < 0) ? (val_12 + 1) : (val_12)) >> 1);
            int val_12 = this.IV.Length;
            val_12 = this.blockSize - val_12;
            if(val_12 > val_13)
            {
                goto label_9;
            }
            
            if(parameters.Parameters == null)
            {
                goto typeof(Org.BouncyCastle.Crypto.Modes.SicBlockCipher).__il2cppRuntimeField_228;
            }
            
            val_13 = this.cipher;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13.Init(forEncryption:  true, parameters:  parameters.Parameters);
            goto typeof(Org.BouncyCastle.Crypto.Modes.SicBlockCipher).__il2cppRuntimeField_228;
            label_3:
            val_15 = 1152921551416296224;
            val_16 = new System.ArgumentException(message:  "CTR/SIC mode requires ParametersWithIV", paramName:  "parameters");
            goto label_16;
            label_5:
            val_18 = "CTR/SIC mode requires IV no greater than: ";
            goto label_17;
            label_9:
            int val_14 = this.blockSize;
            val_14 = val_14 - val_13;
            val_18 = "CTR/SIC mode requires IV of at least: ";
            label_17:
            val_15 = 1152921551416296224;
            val_16 = new System.ArgumentException(message:  val_18 + val_14 + " bytes.");
            label_16:
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.cipher.AlgorithmName + "/SIC"("/SIC");
        }
        public virtual bool get_IsPartialBlockOkay()
        {
            return true;
        }
        public virtual int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetBlockSize();
        }
        public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
        {
            System.Byte[] val_6;
            var val_8;
            val_6 = output;
            var val_7 = 0;
            val_7 = val_7 + 1;
            int val_2 = this.cipher.ProcessBlock(inBuf:  this.counter, inOff:  0, outBuf:  this.counterOut, outOff:  0);
            val_8 = 0;
            goto label_6;
            label_14:
            byte val_8 = this.counterOut[0];
            val_8 = (input[(long)inOff + val_8]) ^ val_8;
            val_8 = 1;
            val_6[(long)outOff + val_8] = val_8;
            label_6:
            if(val_8 < this.counterOut.Length)
            {
                goto label_14;
            }
            
            int val_5 = this.counter.Length - 1;
            label_19:
            if((val_5 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            val_6 = this.counter;
            byte val_10 = val_6[(long)val_5];
            val_5 = val_5 - 1;
            val_10 = val_10 + 1;
            val_6[(long)val_5] = val_10;
            if((val_10 & 255) == 0)
            {
                goto label_19;
            }
            
            label_16:
            if(this.counter != null)
            {
                    return (int)this.counter.Length;
            }
            
            return (int)this.counter.Length;
        }
        public virtual void Reset()
        {
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.counter, b:  0);
            System.Array.Copy(sourceArray:  this.IV, sourceIndex:  0, destinationArray:  this.counter, destinationIndex:  0, length:  this.IV.Length);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
