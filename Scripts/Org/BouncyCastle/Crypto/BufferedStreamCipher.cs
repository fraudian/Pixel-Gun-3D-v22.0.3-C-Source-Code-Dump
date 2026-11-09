using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class BufferedStreamCipher : BufferedCipherBase
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.IStreamCipher cipher;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public BufferedStreamCipher(Org.BouncyCastle.Crypto.IStreamCipher cipher)
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
            return 0;
        }
        public override int GetOutputSize(int inputLen)
        {
            return (int)inputLen;
        }
        public override int GetUpdateOutputSize(int inputLen)
        {
            return (int)inputLen;
        }
        public override byte[] ProcessByte(byte input)
        {
            byte[] val_1 = new byte[1];
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1[0] = this.cipher.ReturnByte(input:  input);
            return (System.Byte[])val_1;
        }
        public override int ProcessByte(byte input, byte[] output, int outOff)
        {
            if(output.Length > outOff)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                output[(long)outOff] = this.cipher.ReturnByte(input:  input);
                return 1;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_3 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "output buffer too short");
        }
        public override byte[] ProcessBytes(byte[] input, int inOff, int length)
        {
            System.Byte[] val_3;
            if(length >= 1)
            {
                    byte[] val_1 = new byte[0];
                val_3 = val_1;
                var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    val_3 = 0;
                return val_3;
            }
            
            this.cipher.ProcessBytes(input:  input, inOff:  inOff, length:  length, output:  val_1, outOff:  0);
            return val_3;
        }
        public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            int val_2 = length;
            if(val_2 >= 1)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
            }
            else
            {
                    val_2 = 0;
                return val_2;
            }
            
            this.cipher.ProcessBytes(input:  input, inOff:  inOff, length:  val_2 = length, output:  output, outOff:  outOff);
            return val_2;
        }
        public override byte[] DoFinal()
        {
            null = null;
            return (System.Byte[])Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
        }
        public override byte[] DoFinal(byte[] input, int inOff, int length)
        {
            var val_1;
            System.Byte[] val_2;
            var val_3;
            val_1 = this;
            if(length > 0)
            {
                    val_2 = val_1;
                return val_2;
            }
            
            val_1 = 1152921505521913856;
            val_3 = null;
            val_3 = null;
            val_2 = Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
            return val_2;
        }
        public override void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
    
    }

}
