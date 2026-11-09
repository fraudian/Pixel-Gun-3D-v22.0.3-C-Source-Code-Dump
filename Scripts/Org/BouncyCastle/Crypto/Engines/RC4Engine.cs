using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    public class RC4Engine : IStreamCipher
    {
        // Fields
        private static readonly int STATE_LENGTH;
        private byte[] engineState;
        private int x;
        private int y;
        private byte[] workingKey;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            if(parameters != null)
            {
                    System.Byte[] val_1 = parameters.GetKey();
                this.workingKey = val_1;
                this.SetKey(keyBytes:  val_1);
                return;
            }
            
            System.ArgumentException val_4 = new System.ArgumentException(message:  "invalid parameter passed to RC4 init - "("invalid parameter passed to RC4 init - ") + Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)(Org.BouncyCastle.Utilities.Platform.GetTypeName(obj:  parameters)));
        }
        public virtual string get_AlgorithmName()
        {
            return "RC4";
        }
        public virtual byte ReturnByte(byte input)
        {
            int val_3;
            int val_3 = this.x;
            val_3 = val_3 + 1;
            int val_1 = val_3 & 255;
            this.x = val_1;
            byte val_4 = this.engineState[val_1];
            val_4 = this.y + val_4;
            val_4 = val_4 & 255;
            this.y = val_4;
            val_3 = this.engineState.Length;
            if(this.workingKey >= val_3)
            {
                    val_3 = this.engineState.Length;
            }
            
            this.engineState[this.x] = this.engineState[this.workingKey];
            this.engineState[this.y] = this.engineState[(long)this.x];
            int val_9 = this.y;
            byte val_8 = this.engineState[val_9];
            val_8 = val_8 + this.engineState[this.x];
            val_9 = val_8 & 255;
            return (byte)this.engineState[val_9] ^ input;
        }
        public virtual void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
        {
            int val_3;
            System.Byte[] val_4;
            int val_5;
            int val_6;
            val_3 = outOff;
            val_4 = output;
            val_5 = inOff;
            Org.BouncyCastle.Crypto.Check.DataLength(buf:  input, off:  val_5, len:  length, msg:  "input buffer too short");
            Org.BouncyCastle.Crypto.Check.OutputLength(buf:  val_4, off:  val_3, len:  length, msg:  "output buffer too short");
            if(length < 1)
            {
                    return;
            }
            
            int val_11 = length;
            do
            {
                int val_3 = this.x;
                val_3 = val_3 + 1;
                int val_1 = val_3 & 255;
                this.x = val_1;
                byte val_4 = this.engineState[val_1];
                val_4 = this.y + val_4;
                val_4 = val_4 & 255;
                this.y = val_4;
                val_6 = this.engineState.Length;
                if(this.workingKey >= val_6)
            {
                    val_6 = this.engineState.Length;
            }
            
                this.engineState[this.x] = this.engineState[this.workingKey];
                this.engineState[this.y] = this.engineState[(long)this.x];
                System.Byte[] val_2 = input + (long)val_5;
                int val_9 = this.y;
                byte val_8 = this.engineState[val_9];
                val_8 = val_8 + this.engineState[this.x];
                val_9 = val_8 & 255;
                byte val_10 = this.engineState[val_9];
                val_4 = val_4;
                val_10 = val_10 ^ ((input + (long)(int)(inOff)) + 32);
                val_3 = val_3 + 1;
                val_11 = val_11 - 1;
                val_5 = val_5 + 1;
                val_4[(long)val_3] = val_10;
            }
            while(val_11 != 0);
        
        }
        public virtual void Reset()
        {
            this.SetKey(keyBytes:  this.workingKey);
        }
        private void SetKey(byte[] keyBytes)
        {
            var val_5;
            byte val_6;
            var val_7;
            var val_8;
            var val_9;
            int val_10;
            this.x = 0;
            this.y = 0;
            this.workingKey = keyBytes;
            if(this.engineState == null)
            {
                    val_5 = null;
                val_5 = null;
                this.engineState = new byte[0];
            }
            
            val_6 = 0;
            goto label_4;
            label_9:
            this.engineState[0] = val_6;
            val_6 = 1;
            label_4:
            val_7 = null;
            val_7 = null;
            if(val_6 < Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH)
            {
                goto label_9;
            }
            
            val_8 = 0;
            var val_6 = 0;
            val_9 = 0;
            goto label_10;
            label_24:
            val_6 = (val_6 + keyBytes[0]) + this.engineState[0];
            val_6 = val_6 & 255;
            val_10 = this.engineState.Length;
            if(val_6 >= val_10)
            {
                    val_10 = this.engineState.Length;
            }
            
            this.engineState[0] = this.engineState[val_6];
            this.engineState[val_6] = this.engineState[0];
            val_7 = null;
            val_8 = 1;
            val_9 = 1 - ((1 / keyBytes.Length) * keyBytes.Length);
            label_10:
            val_7 = null;
            if(val_8 < Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH)
            {
                goto label_24;
            }
        
        }
        public RC4Engine()
        {
        
        }
        private static RC4Engine()
        {
            Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH = 256;
        }
    
    }

}
