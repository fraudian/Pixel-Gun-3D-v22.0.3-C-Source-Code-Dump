using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class BufferedAeadBlockCipher : BufferedCipherBase
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public BufferedAeadBlockCipher(Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher cipher)
        {
            this = new System.Object();
            if(cipher != null)
            {
                    this.cipher = cipher;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "cipher");
        }
        public override string get_AlgorithmName()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.AlgorithmName;
        }
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_4 = parameters;
            if(val_4 != null)
            {
                    val_4 = val_4.Parameters;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.cipher.Init(forEncryption:  forEncryption, parameters:  val_4);
        }
        public override int GetBlockSize()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetBlockSize();
        }
        public override int GetUpdateOutputSize(int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetUpdateOutputSize(len:  length);
        }
        public override int GetOutputSize(int length)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.GetOutputSize(len:  length);
        }
        public override int ProcessByte(byte input, byte[] output, int outOff)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.ProcessByte(input:  input, outBytes:  output, outOff:  outOff);
        }
        public override byte[] ProcessByte(byte input)
        {
            System.Array val_3;
            if(this >= 1)
            {
                    val_3 = new byte[-123094608];
            }
            else
            {
                    val_3 = 0;
            }
            
            if(this < 1)
            {
                    return (System.Byte[])val_3;
            }
            
            if(this >= this)
            {
                    return (System.Byte[])val_3;
            }
            
            byte[] val_2 = new byte[-123094608];
            System.Array.Copy(sourceArray:  val_3, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -123094608);
            val_3 = val_2;
            return (System.Byte[])val_3;
        }
        public override byte[] ProcessBytes(byte[] input, int inOff, int length)
        {
            var val_4;
            System.Array val_5;
            val_4 = length;
            if(input == null)
            {
                goto label_1;
            }
            
            if(val_4 < 1)
            {
                goto label_2;
            }
            
            if(this < 1)
            {
                goto label_3;
            }
            
            val_5 = new byte[-122940560];
            goto label_4;
            label_2:
            val_5 = 0;
            return (System.Byte[])val_5;
            label_3:
            val_5 = 0;
            label_4:
            val_4 = this;
            if(this < 1)
            {
                    return (System.Byte[])val_5;
            }
            
            if(val_4 >= this)
            {
                    return (System.Byte[])val_5;
            }
            
            byte[] val_2 = new byte[-122940560];
            System.Array.Copy(sourceArray:  val_5, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -122940560);
            val_5 = val_2;
            return (System.Byte[])val_5;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "input");
        }
        public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.ProcessBytes(inBytes:  input, inOff:  inOff, len:  length, outBytes:  output, outOff:  outOff);
        }
        public override byte[] DoFinal()
        {
            System.Array val_3;
            byte[] val_1 = new byte[-122519856];
            val_3 = val_1;
            if(this >= val_1.Length)
            {
                    return (System.Byte[])val_3;
            }
            
            byte[] val_2 = new byte[-122519856];
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  -122519856);
            val_3 = val_2;
            return (System.Byte[])val_3;
        }
        public override byte[] DoFinal(byte[] input, int inOff, int inLen)
        {
            System.Array val_4;
            System.Array val_5;
            if(input != null)
            {
                    byte[] val_1 = new byte[-122365808];
                val_4 = val_1;
                if(inLen >= 1)
            {
                    val_5 = this;
            }
            else
            {
                    val_5 = 0;
            }
            
                if(null >= val_1.Length)
            {
                    return (System.Byte[])val_4;
            }
            
                byte[] val_2 = new byte[914907136];
                val_5 = val_2;
                System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  val_2, destinationIndex:  0, length:  914907136);
                val_4 = val_5;
                return (System.Byte[])val_4;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "input");
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.cipher.DoFinal(outBytes:  output, outOff:  outOff);
        }
        public override void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
