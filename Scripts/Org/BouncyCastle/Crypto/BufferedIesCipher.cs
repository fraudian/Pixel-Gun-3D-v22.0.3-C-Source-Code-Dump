using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public class BufferedIesCipher : BufferedCipherBase
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Engines.IesEngine engine;
        private bool forEncryption;
        private System.IO.MemoryStream buffer;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public BufferedIesCipher(Org.BouncyCastle.Crypto.Engines.IesEngine engine)
        {
            this.buffer = new System.IO.MemoryStream();
            this = new System.Object();
            if(engine != null)
            {
                    this.engine = engine;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "engine");
        }
        public override string get_AlgorithmName()
        {
            return "IES";
        }
        public override void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            this.forEncryption = forEncryption;
            System.Exception val_2 = Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException(message:  "IES");
        }
        public override int GetBlockSize()
        {
            return 0;
        }
        public override int GetOutputSize(int inputLen)
        {
            if(this.engine != null)
            {
                    System.IO.MemoryStream val_4 = this.buffer;
                val_4 = (val_4 + inputLen) + ((this.forEncryption == false) ? (-20) : 20);
                return (int)val_4;
            }
            
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  "cipher not initialised");
        }
        public override int GetUpdateOutputSize(int inputLen)
        {
            return 0;
        }
        public override byte[] ProcessByte(byte input)
        {
            if(this.buffer != null)
            {
                    return 0;
            }
            
            return 0;
        }
        public override byte[] ProcessBytes(byte[] input, int inOff, int length)
        {
            var val_4;
            string val_6;
            if(input == null)
            {
                goto label_1;
            }
            
            if((inOff & 2147483648) != 0)
            {
                goto label_2;
            }
            
            if((length & 2147483648) != 0)
            {
                goto label_3;
            }
            
            if((length + inOff) > input.Length)
            {
                goto label_4;
            }
            
            if(this.buffer != null)
            {
                    return 0;
            }
            
            return 0;
            label_1:
            System.ArgumentNullException val_2 = null;
            val_4 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "input");
            goto label_6;
            label_2:
            val_6 = "inOff";
            goto label_8;
            label_3:
            val_6 = "length";
            goto label_8;
            label_4:
            System.ArgumentException val_3 = null;
            val_6 = "invalid offset/length specified for input array";
            label_8:
            val_4 = val_3;
            val_3 = new System.ArgumentException(message:  val_6);
            label_6:
        }
        public override byte[] DoFinal()
        {
            if(this.buffer == null)
            {
                goto label_1;
            }
            
            label_4:
            this.engine = ???;
            goto typeof(Org.BouncyCastle.Crypto.Engines.IesEngine).__il2cppRuntimeField_178;
            label_1:
            if(this.engine != 0)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public override byte[] DoFinal(byte[] input, int inOff, int length)
        {
            goto typeof(Org.BouncyCastle.Crypto.BufferedIesCipher).__il2cppRuntimeField_338;
        }
        public override void Reset()
        {
            if(this.buffer == null)
            {
                
            }
        
        }
    
    }

}
