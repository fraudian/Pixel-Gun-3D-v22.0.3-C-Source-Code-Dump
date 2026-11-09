using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    internal class MacCFBBlockCipher : IBlockCipher
    {
        // Fields
        private byte[] IV;
        private byte[] cfbV;
        private byte[] cfbOutV;
        private readonly int blockSize;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        
        // Properties
        public string AlgorithmName { get; }
        public bool IsPartialBlockOkay { get; }
        
        // Methods
        public MacCFBBlockCipher(Org.BouncyCastle.Crypto.IBlockCipher cipher, int bitBlockSize)
        {
            int val_2 = (bitBlockSize < 0) ? (bitBlockSize + 7) : bitBlockSize;
            val_2 = val_2 >> 3;
            this.cipher = cipher;
            this.blockSize = val_2;
            var val_12 = 0;
            val_12 = val_12 + 1;
            int val_4 = cipher.GetBlockSize();
            this.IV = new byte[0];
            var val_13 = 0;
            val_13 = val_13 + 1;
            int val_7 = cipher.GetBlockSize();
            this.cfbV = new byte[0];
            var val_14 = 0;
            val_14 = val_14 + 1;
            int val_10 = cipher.GetBlockSize();
            this.cfbOutV = new byte[0];
        }
        public void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            System.Array val_5;
            Org.BouncyCastle.Crypto.ICipherParameters val_6;
            System.Byte[] val_7;
            int val_8;
            System.Array val_9;
            var val_10;
            System.Array val_11;
            var val_12;
            val_6 = parameters;
            if(val_6 != null)
            {
                    val_5 = val_6.GetIV();
                val_7 = this.IV;
                if(this.IV == null)
            {
                    val_7 = this.IV;
            }
            
                val_8 = this.IV.Length;
                if(val_1.Length < this.IV.Length)
            {
                    val_9 = val_5;
                val_10 = 0;
                val_11 = val_7;
                val_12 = val_8 - val_1.Length;
                val_8 = val_1.Length;
            }
            else
            {
                    val_9 = val_5;
                val_10 = 0;
                val_11 = val_7;
                val_12 = 0;
            }
            
                System.Array.Copy(sourceArray:  val_9, sourceIndex:  0, destinationArray:  val_11, destinationIndex:  0, length:  val_8);
                val_6 = val_6.Parameters;
            }
            
            this.Reset();
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  val_6);
        }
        public string get_AlgorithmName()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            int val_5 = this.blockSize;
            val_5 = val_5 << 3;
            return (string)this.cipher.AlgorithmName + "/CFB"("/CFB") + val_5;
        }
        public bool get_IsPartialBlockOkay()
        {
            return true;
        }
        public int GetBlockSize()
        {
            return (int)this.blockSize;
        }
        public int ProcessBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
        {
            System.Byte[] val_9;
            int val_11;
            int val_12;
            string val_14;
            if((this.blockSize + inOff) > input.Length)
            {
                goto label_2;
            }
            
            if((this.blockSize + outOff) > outBytes.Length)
            {
                goto label_4;
            }
            
            val_9 = this.cfbOutV;
            var val_10 = 0;
            val_10 = val_10 + 1;
            int val_4 = this.cipher.ProcessBlock(inBuf:  this.cfbV, inOff:  0, outBuf:  val_9, outOff:  0);
            val_11 = this.blockSize;
            if(val_11 >= 1)
            {
                    do
            {
                byte val_11 = this.cfbOutV[0];
                val_11 = (input[(long)inOff + 0]) ^ val_11;
                outBytes[(long)outOff + 0] = val_11;
                val_11 = this.blockSize;
                val_9 = 0 + 1;
            }
            while(val_9 < val_11);
            
            }
            
            val_12 = val_11;
            if(this.cfbV == null)
            {
                    val_12 = this.blockSize;
            }
            
            System.Array.Copy(sourceArray:  this.cfbV, sourceIndex:  val_11, destinationArray:  this.cfbV, destinationIndex:  0, length:  this.cfbV.Length - val_12);
            System.Array.Copy(sourceArray:  outBytes, sourceIndex:  outOff, destinationArray:  this.cfbV, destinationIndex:  this.cfbV.Length - this.blockSize, length:  this.blockSize);
            return (int)this.blockSize;
            label_2:
            val_14 = "input buffer too short";
            goto label_20;
            label_4:
            val_14 = "output buffer too short";
            label_20:
            null = new Org.BouncyCastle.Crypto.DataLengthException(message:  val_14);
        }
        public void Reset()
        {
            this.IV.CopyTo(array:  this.cfbV, index:  0);
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.cipher.Reset();
        }
        public void GetMacBlock(byte[] mac)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            int val_2 = this.cipher.ProcessBlock(inBuf:  this.cfbV, inOff:  0, outBuf:  mac, outOff:  0);
        }
    
    }

}
